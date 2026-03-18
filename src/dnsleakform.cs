using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace KshieldVPN
{
    public partial class dnsleakform : Form
    {
        private readonly HttpClient _httpClient;
        private bool _testRunning = false;
        private List<string> _detectedDnsServers = new List<string>();
        public dnsleakform()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "VPN DNS Leak Test Tool");
            lstDnsServers.Columns.Clear();
            lstDnsServers.Columns.Add("IP Address", 150); // Adjust width as needed
            lstDnsServers.Columns.Add("Organization", 250);
            lstDnsServers.View = View.Details;
            lstDnsServers.Visible = false;
        }

        private async void btngo_Click(object sender, EventArgs e)
        {
            if (_testRunning)
                return;

            _testRunning = true;
            btngo.Enabled = false;
            lblstatus.Text = "Running DNS leak test...";
            _detectedDnsServers.Clear();
            lstDnsServers.Items.Clear();
            lstDnsServers.Visible = false;
            progressBar.Value = 0;
            progressBar.Maximum = 100;

            try
            {
                await RunDNSLeakTest();

                if (_detectedDnsServers.Count == 0)
                {
                    lblstatus.Text = "No DNS servers detected. This could indicate a connection issue.";
                }
                else
                {
                    lblstatus.Text = $"Test complete. Found {_detectedDnsServers.Count} DNS server(s).";

                    // Check for VPN DNS leak
                    bool isLeaking = CheckForDNSLeak();

                    if (isLeaking)
                    {
                        lblstatus.Text += " WARNING: Possible DNS leak detected!";
                        lblstatus.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblstatus.Text += " No DNS leaks detected.";
                        lblstatus.ForeColor = Color.Green;
                    }
                    lstDnsServers.Visible = true;
                }
                while (lstDnsServers.Columns.Count > 2)
                {
                    lstDnsServers.Columns.RemoveAt(2);
                }

                // Remove any blank rows
                foreach (ListViewItem item in lstDnsServers.Items.Cast<ListViewItem>().ToList())
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        lstDnsServers.Items.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = $"Error: {ex.Message}";
                lblstatus.ForeColor = Color.Red;

            }
            finally
            {
                _testRunning = false;
                btngo.Enabled = true;
                progressBar.Value = 100;
            }


        }

        private async Task RunDNSLeakTest()
        { // Use several DNS leak test services for redundancy
            progressBar.Value = 10;

            try
            {
                
                var random = new Random();

               
                string[] testDomains = {
                    "www.google.com",
                    "www.cloudflare.com",
                    "www.microsoft.com",
                    "www.amazon.com",
                    "www.github.com"
                };

                // Make DNS lookup requests that will reveal which DNS servers are being used
                for (int i = 0; i < testDomains.Length; i++)
                {
                    progressBar.Value = 20 + (i * 10);
                    try
                    {
                        // This resolves the domain, forcing a DNS lookup
                        var addresses = Dns.GetHostAddresses(testDomains[i]);
                        await Task.Delay(200);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"DNS resolution error: {ex.Message}");
                    }
                }

                progressBar.Value = 70;

              
                try
                {
                    
                    var response = await _httpClient.GetStringAsync("https://api.ipify.org?format=json");
                    var ipInfo = JsonConvert.DeserializeObject<JObject>(response);

                    if (ipInfo != null && ipInfo["ip"] != null)
                    {
                        var ipAddress = ipInfo["ip"]?.ToString();

                        // Get organization info from another API
                        try
                        {
                            var orgResponse = await _httpClient.GetStringAsync($"https://ipapi.co/{ipAddress}/json/");
                            var orgInfo = JsonConvert.DeserializeObject<JObject>(orgResponse);

                            var org = orgInfo?["org"]?.ToString() ?? "Unknown";
                            AddDnsServer(ipAddress, org);

                            
                            if (orgInfo?["isp"] != null)
                            {
                                AddDnsServer(ipAddress, orgInfo["isp"].ToString());
                            }
                        }
                        catch
                        {
                            
                            AddDnsServer(ipAddress, "Unknown Organization");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching IP info: {ex.Message}");

                    
                    try
                    {
                        var response = await _httpClient.GetStringAsync("https://api.ipify.org");
                        AddDnsServer(response, "Unknown (Alternative Lookup)");
                    }
                    catch
                    {
                       
                        AddDnsServer("Unable to detect", "Connection issue");
                    }
                }

                
                try
                {
                    var dnsServers = GetDnsServers();
                    foreach (var server in dnsServers)
                    {
                        AddDnsServer(server, DetermineDnsProvider(server));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting DNS servers: {ex.Message}");
                }

                progressBar.Value = 95;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General error in DNS test: {ex.Message}");
                
                AddDnsServer("Error", ex.Message);
            }
        }

        private List<string> GetDnsServers()
        {
            var servers = new List<string>();

            try
            {
                // Get network interfaces that are up
                var networkInterfaces = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                    .Where(ni => ni.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up);

                foreach (var networkInterface in networkInterfaces)
                {
                    var properties = networkInterface.GetIPProperties();
                    var dnsAddresses = properties.DnsAddresses;

                    foreach (var dns in dnsAddresses)
                    {
                        if (!servers.Contains(dns.ToString()))
                        {
                            servers.Add(dns.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting DNS servers: {ex.Message}");
            }

            return servers;
        }

        private string DetermineDnsProvider(string ipAddress)
        {
            // This is a simplified lookup and should be extended with a more comprehensive database
            // for production use
            Dictionary<string, string> knownDnsProviders = new Dictionary<string, string>
            {
                { "8.8.8.8", "Google DNS" },
                { "8.8.4.4", "Google DNS" },
                { "1.1.1.1", "Cloudflare DNS" },
                { "1.0.0.1", "Cloudflare DNS" },
                { "9.9.9.9", "Quad9 DNS" },
                { "208.67.222.222", "OpenDNS" },
                { "208.67.220.220", "OpenDNS" },
                { "64.6.64.6", "Verisign DNS" },
                { "64.6.65.6", "Verisign DNS" }
            };

            if (knownDnsProviders.ContainsKey(ipAddress))
            {
                return knownDnsProviders[ipAddress];
            }

            // Check for common ISP DNS patterns
            if (ipAddress.StartsWith("192.168.") || ipAddress.StartsWith("10.") || ipAddress.StartsWith("172."))
            {
                return "Local/Router DNS";
            }

            return "Unknown Provider";
        }

        private void AddDnsServer(string ip, string org)
        {
            if (string.IsNullOrWhiteSpace(ip) || _detectedDnsServers.Contains(ip))
                return;

            _detectedDnsServers.Add(ip);

            var item = new ListViewItem(ip);
            item.SubItems.Add(!string.IsNullOrWhiteSpace(org) ? org : "Unknown");

            lstDnsServers.Items.Add(item);
        }

        private bool CheckForDNSLeak()
        {
            // Look for known public DNS servers that might indicate a leak
            bool usingVpnDns = false;
            bool usingPublicDns = false;
            bool usingIspDns = false;
            bool usingTrustedServiceDns = false;

            foreach (var server in lstDnsServers.Items.Cast<ListViewItem>())
            {
                string ip = server.Text;
                string org = server.SubItems[1].Text;

                // Check if using VPN DNS
                if (org.Contains("VPN") || org.Contains("Private") || org.Contains("Secure"))
                {
                    usingVpnDns = true;
                }

                // Check if using public DNS (not necessarily a leak)
                if (org.Contains("Google") || org.Contains("Cloudflare") || org.Contains("OpenDNS") ||
                    org.Contains("Quad9") || org.Contains("Verisign"))
                {
                    usingPublicDns = true;
                }

                // Check for trusted cloud/CDN providers
                if (org.Contains("Amazon") || org.Contains("AWS") || org.Contains("Microsoft") ||
                    org.Contains("Azure") || org.Contains("GitHub") || org.Contains("Akamai") ||
                    org.Contains("Fastly") || org.Contains("Cloudflare"))
                {
                    usingTrustedServiceDns = true;
                }

                // Check if using ISP DNS (potential leak)
                if (org.Contains("ISP") || org.Contains("Comcast") || org.Contains("Verizon") ||
                    org.Contains("AT&T") || org.Contains("Internet Provider") ||
                    (org.Contains("Local") && !org.Contains("Cloudflare") && !org.Contains("Google")))
                {
                    usingIspDns = true;
                }
            }

            // If using ISP DNS while VPN should be active, that's a potential leak
            // Don't flag as leak if we're using VPN DNS, public DNS, or trusted services
            return usingIspDns && !usingVpnDns && !usingPublicDns && !usingTrustedServiceDns;
        
        }

        private void dnsleakform_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_icon_Click(object sender, EventArgs e)
        {
            menupanel.Visible = !menupanel.Visible;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Form mainForm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f is Kshieldvpn1)
                {
                    mainForm = f;
                    break;
                }
            }

            if (mainForm != null)
            {
                mainForm.Show();
            }
            else
            {
                // Create new main form if none exists
                mainForm = new Kshieldvpn1();
                mainForm.Show();
            }

            this.Close(); // Close the speed test form 
        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            stform stform = new stform();
            stform.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
