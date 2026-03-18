using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Http;
using Kshieldvpn;

namespace KshieldVPN
{
    public partial class Kshieldvpn1 : Form
    {
        private bool isConnected = false;
        private Process vpnProcess = null;

        public Kshieldvpn1()
        {
            InitializeComponent();
          
            button3.Enabled = true; 
            button2.Enabled = true;  
        }

        //Form load event
        private void Kshieldvpn1_Load(object sender, EventArgs e)
        {
            ApplyPremiumFeatureAccess();

        }

        // Connect button click event handler
        private async void connectbtn_Click(object sender, EventArgs e)
        {
            // Check if a server is selected
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                MessageBox.Show("Please select a server to connect.", "Server Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check connection status
            if (isConnected)
            {
                MessageBox.Show("Already connected to a VPN server.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Determine config file path based on server selection
            string configFilePath = null;
            if (comboBox.Text == "California")
            {
                configFilePath = @"C:\Program Files\OpenVPN\bin\prof_cali.ovpn";
                ConnectToOpenVPNUsingTerminal(configFilePath);
            }
            else if (comboBox.Text == "Paris")
            {
                if (!SessionManager.IsPremium)
                {
                    MessageBox.Show("This server is available for premium users only.", "Premium Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    configFilePath = @"C:\Program Files\OpenVPN\bin\prof_paris.ovpn";
                    ConnectToOpenVPNUsingTerminal(configFilePath);

                }
            }
            else if (comboBox.Text == "Seoul")
            {
                if (!SessionManager.IsPremium)
                {
                    MessageBox.Show("This server is available for premium users only.", "Premium Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    configFilePath = @"C:\Program Files\OpenVPN\bin\prof_1.ovpn";
                    ConnectToOpenVPNUsingTerminal(configFilePath);
                }
            }
            else if (comboBox.Text == "Dublin")
            {
                if (!SessionManager.IsPremium)
                {
                    MessageBox.Show("This server is available for premium users only.", "Premium Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    configFilePath = @"C:\Program Files\OpenVPN\bin\prof_ire.ovpn";
                    ConnectToOpenVPNUsingTerminal(configFilePath);
                }
            }
            else if (comboBox.Text == "Tokyo")
            {
                if (!SessionManager.IsPremium)
                {
                    MessageBox.Show("This server is available for premium users only.", "Premium Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    configFilePath = @"C:\Program Files\OpenVPN\bin\prof_tokyo.ovpn";
                    ConnectToOpenVPNUsingTerminal(configFilePath);
                }
            }
            else
            {
                MessageBox.Show("Select a valid server.", "Server Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // Disconnect button click event handler
        private void disconnectbtn_Click(object sender, EventArgs e)
        {

            DisconnectVpn();
            MessageBox.Show("You've disconnected from the server.");
        }

        // Toggle side menu panel visibility
        private void menu_icon_Click(object sender, EventArgs e)
        {
            menupanel.Visible = !menupanel.Visible;
        }

        // Speed Test button click event handler
        private void sptestbtn_Click(object sender, EventArgs e)
        {
            stform sp = new stform();
            sp.Show();
            this.Hide();

        }

        // DNS Leak Test button click event handler
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsPremium)
            {
                MessageBox.Show("This feature is available for premium users only.\nUpgrade to unlock it!",
                                "Premium Feature",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Open DNS leak form if user is premium
            dnsleakform dnsleakform = new dnsleakform();
            dnsleakform.Show();
            this.Hide();
        }

        // Premium button click handler
        private async void premium_Click(object sender, EventArgs e)
        {
            try
            {
                string userEmail = KshieldVPN.Properties.Settings.Default.UserEmail;
                string apiUrl = $"https://localhost:44359/api/payment/create-checkout-session?email={Uri.EscapeDataString(userEmail)}";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                        string url = json.url;

                        // Open Stripe Checkout in browser
                        Process.Start(url);

                        // Let the user know they'll need to log back in
                        MessageBox.Show("Payment page opened. After completing payment, please log in again to activate your premium features.", "Payment Initiated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Force logout using existing logout functionality
                        ForceLogout();
                    }
                    else
                    {
                        MessageBox.Show("Failed to initiate payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForceLogout()
        {
            // Clear session info
            SessionManager.ClearSession();

            // Clear saved login info
            KshieldVPN.Properties.Settings.Default.UserEmail = "";
            KshieldVPN.Properties.Settings.Default.RememberMe = false;
            KshieldVPN.Properties.Settings.Default.Save();

            // Open Login Form
            Login_Form loginForm = new Login_Form();
            loginForm.Show();

            // Close current window
            this.Close();
        }
        private void ApplyPremiumFeatureAccess()
        {
            // For DNS Leak Test
            if (!SessionManager.IsPremium)
            {
                guna2Button1.Enabled = true; // Still clickable
                guna2Button1.Click -= PremiumOnlyWarning;
            }
            else
            {
                guna2Button1.Click -= PremiumOnlyWarning;
                guna2Button1.Click += guna2Button1_Click; // Actual method
            }
        }
        private void PremiumOnlyWarning(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is available for premium users only.",
                            "Premium Feature",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Logout button click event handler
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear session info
                SessionManager.ClearSession();

                // Clear saved login info
                KshieldVPN.Properties.Settings.Default.UserEmail = "";
                KshieldVPN.Properties.Settings.Default.RememberMe = false;
                KshieldVPN.Properties.Settings.Default.Save();

                // Open Login Form
                Login_Form loginForm = new Login_Form();
                loginForm.Show();

                // Close current window
                this.Hide();
            }
        }

        #region VPN and Utility Methods (Simulated and OpenVPN)

        // Connect to OpenVPN using terminal
        private async void ConnectToOpenVPNUsingTerminal(string configFilePath)
        {
            try
            {
                string authScriptPath = @"C:\Program Files\OpenVPN\bin\cred.txt";
                string openvpnPath = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                string arguments = $"--config \"{configFilePath}\" --auth-user-pass \"{authScriptPath}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = openvpnPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,  // Hides the window
                    WindowStyle = ProcessWindowStyle.Hidden // Prevents popup
                };

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();
                    MessageBox.Show("VPN Connected Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Read output asynchronously (prevents blocking)
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();

                    Debug.WriteLine("VPN Output: " + output);
                    Debug.WriteLine("VPN Error: " + error);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async void DisconnectVpn()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "taskkill",
                    Arguments = "/f /im openvpn.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true // Prevents CMD from flashing
                };

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();
                    await Task.Run(() => process.WaitForExit());  // Ensures process completes before proceeding
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while disconnecting: {ex.Message}");
            }
        }

        // Event handler for VPN process exit
        private void VpnProcess_Exited(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                // If called from a different thread, invoke on UI thread
                Invoke(new Action(() => VpnProcess_Exited(sender, e)));
                return;
            }

            isConnected = false;
            button2.Enabled = true;
            button3.Enabled = true;
            MessageBox.Show("VPN connection unexpectedly terminated.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
        #endregion
    }
}
