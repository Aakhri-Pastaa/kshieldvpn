using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kshieldvpn;

namespace KshieldVPN
{
    public partial class stform : Form
    {
        private BackgroundWorker worker;
        private Stopwatch stopwatch;
        private long downloadSize;
        private long uploadSize;
        private double downloadSpeed;
        private double uploadSpeed;
        private double pingTime; // Added for ping measurement
        private const string downloadTestUrl = "https://speed.cloudflare.com/__down?bytes=100000000"; // 100MB file
        private const string uploadTestUrl = "https://speed.cloudflare.com/__up";
        private const string pingTestHost = "speed.cloudflare.com"; // Host to ping
        private Timer progressTimer;
        private int targetDownloadProgress;
        private int targetUploadProgress;
        private bool menuCollapsed = true;


    


      
        private const double MaxGaugeSpeed = 100.0; //

        public stform()
        {
            InitializeComponent();
            InitializeWorker();
            pbdwn.Visible = false;
            pbup.Visible = false;
            speedGauge.Visible = false;

            // Initialize and configure the progress timer
            progressTimer = new Timer();
            progressTimer.Interval = 100; // Increased to 100ms to reduce UI load
            progressTimer.Tick += ProgressTimer_Tick;
        }
      
        private void InitializeWorker()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void stgobtn_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                // Reset UI
                txtdwnspeed.Text = "";
                txtupspeed.Text = "";
                txtping.Text = ""; // Clear ping textbox
                pbdwn.Value = 0;
                pbup.Value = 0;
                targetDownloadProgress = 0;
                targetUploadProgress = 0;

                // Reset the gauge
                speedGauge.Value = 0;
                speedGauge.Text = "0 Mbps";

                // Disable button during test
                stgobtn.Enabled = false;

                // Start the progress timer
                progressTimer.Start();

                // Start the background worker
                worker.RunWorkerAsync();
            }

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Make speedGauge visible at the start of the test
                worker.ReportProgress(0, "Initializing...");

                // Test ping first
                worker.ReportProgress(0, "Measuring ping...");
                pingTime = MeasurePing();

                // Test download speed
                worker.ReportProgress(5, "Testing download speed...");
                downloadSpeed = TestDownloadSpeed();

                // Test upload speed
                worker.ReportProgress(50, "Testing upload speed...");
                uploadSpeed = TestUploadSpeed();

                // Test complete
                worker.ReportProgress(100, "Test complete.");
            }
            catch (Exception ex)
            {
                e.Result = ex; // Pass the exception to RunWorkerCompleted
            }

        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.UserState == null) return;

                string message = e.UserState.ToString();
                Debug.WriteLine($"Progress message: {message}"); // Add logging to see what messages are received

                // Make speedGauge visible when starting tests
                if (e.ProgressPercentage == 0 && !speedGauge.Visible)
                {
                    speedGauge.Visible = true;
                }

                // Handle real-time gauge updates - make sure we're correctly parsing the message
                if (message.StartsWith("download-gauge-update:"))
                {
                    string speedStr = message.Replace("download-gauge-update:", "").Trim();
                    if (double.TryParse(speedStr, out double currentSpeed))
                    {
                        Debug.WriteLine($"Download speed update: {currentSpeed}");
                        // Update the speed gauge
                        UpdateSpeedGauge(currentSpeed, "Download");
                        // REMOVED: Don't update text boxes in real-time
                    }
                    return;
                }
                else if (message.StartsWith("upload-gauge-update:"))
                {
                    string speedStr = message.Replace("upload-gauge-update:", "").Trim();
                    if (double.TryParse(speedStr, out double currentSpeed))
                    {
                        Debug.WriteLine($"Upload speed update: {currentSpeed}");
                      
                        UpdateSpeedGauge(currentSpeed, "Upload");
                        
                    }
                    return;
                }
                // For download completion
                else if (message == "download-complete")
                {
                    
                    txtdwnspeed.Text = $"{downloadSpeed:F2} Mbps";
                }
               

                
                if (e.ProgressPercentage == 5 && pingTime > 0)
                {
                    txtping.Text = $"{pingTime:F0} ms";
                }

                
                if (e.ProgressPercentage <= 50)
                {
                    if (!pbdwn.Visible) pbdwn.Visible = true; // Show download progress bar
                    targetDownloadProgress = e.ProgressPercentage * 2;
                    targetUploadProgress = 0; // Ensure upload stays at 0
                }
                else
                {
                    if (!pbup.Visible) pbup.Visible = true; 
                    targetDownloadProgress = 100;
                    targetUploadProgress = (e.ProgressPercentage - 50) * 2; // Scale to 0-100
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Progress update error: {ex.Message}");
            }
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show($"An error occurred: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stgobtn.Enabled = true;
                }
                else if (e.Result is Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stgobtn.Enabled = true;
                }
                else
                {
                    // Update the gauge with the final value
                    UpdateSpeedGauge(uploadSpeed, "Upload");

                    // Only update download text here, upload will be updated by the progress timer
                    txtdwnspeed.Text = $"{downloadSpeed:F2} Mbps";

                    // Flag to indicate test is done
                    workCompleted = true;
                }

                // Ensure progress bars are at final values
                targetDownloadProgress = 100;
                targetUploadProgress = 100;

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Completion error: {ex.Message}");
                stgobtn.Enabled = true; // Ensure button is re-enabled
            }
        }
        private bool workCompleted = false;

        private void UpdateSpeedGauge(double speed, string testType)
        {
            try
            {
                
                int gaugeValue = (int)Math.Min(speed, MaxGaugeSpeed);

                
                AnimateGauge(gaugeValue, testType);

                
                speedGauge.Text = $"{speed:F2} Mbps";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Gauge update error: {ex.Message}");
            }
        }


        private void AnimateGauge(int targetValue, string testType)
        {
            try
            {
               
                if (testType == "Download")
                {
                    
                    speedGauge.ProgressColor = Color.FromArgb(255, 192, 192);
                    speedGauge.ProgressColor2 = Color.FromArgb(255, 128, 128);
                }
                else 
                {
                    
                    speedGauge.ProgressColor = Color.FromArgb(192, 255, 255);
                    speedGauge.ProgressColor2 = Color.FromArgb(192, 192, 255);
                }

                
                if (speedGauge.InvokeRequired)
                {
                    speedGauge.Invoke(new Action(() => AnimateGauge(targetValue, testType)));
                    return;
                }

                
                if (testType == "Upload")
                {
                    
                    Timer animationTimer = new Timer();
                    animationTimer.Interval = 2; 

                    int startValue = speedGauge.Value;
                    int steps = 10; 
                    int currentStep = 0;

                  
                    if (Math.Abs(startValue - targetValue) < 2)
                    {
                        
                        speedGauge.Value = targetValue;
                        return;
                    }

                    animationTimer.Tick += (s, e) =>
                    {
                        currentStep++;
                        if (currentStep <= steps)
                        {
                            
                            int newValue = startValue + (int)((targetValue - startValue) * ((double)currentStep / steps));
                            speedGauge.Value = newValue;
                        }
                        else
                        {
                            
                            speedGauge.Value = targetValue;
                            animationTimer.Stop();
                            animationTimer.Dispose();
                        }
                    };

                    animationTimer.Start();
                }
                else 
                {
                   
                    Timer animationTimer = new Timer();
                    animationTimer.Interval = 5; 

                    int startValue = speedGauge.Value;
                    int steps = 15; 
                    int currentStep = 0;

             
                    if (Math.Abs(startValue - targetValue) < 2)
                    {
                        
                        speedGauge.Value = targetValue;
                        return;
                    }

                    animationTimer.Tick += (s, e) =>
                    {
                        currentStep++;
                        if (currentStep <= steps)
                        {
                            
                            int newValue = startValue + (int)((targetValue - startValue) * ((double)currentStep / steps));
                            speedGauge.Value = newValue;
                        }
                        else
                        {
                            
                            speedGauge.Value = targetValue;
                            animationTimer.Stop();
                            animationTimer.Dispose();
                        }
                    };

                    animationTimer.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Gauge animation error: {ex.Message}");
                
                if (speedGauge != null && !speedGauge.IsDisposed)
                {
                    speedGauge.Value = targetValue;
                }
            }
        }

        private double MeasurePing()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply;
                long totalTime = 0;
                int successfulPings = 0;
                int attemptsCount = 4; 

                for (int i = 0; i < attemptsCount; i++)
                {
                    reply = ping.Send(pingTestHost);
                    if (reply.Status == IPStatus.Success)
                    {
                        totalTime += reply.RoundtripTime;
                        successfulPings++;
                    }

                    // Report progress for ping test
                    worker.ReportProgress(1 + i, $"Ping test: {i + 1}/{attemptsCount}");
                }

                if (successfulPings > 0)
                {
                    return (double)totalTime / successfulPings; 
                }
                else
                {
                    return 0; 
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ping test error: {ex.Message}");
                return 0;
            }
        }

        private double TestDownloadSpeed()
        {
            try
            {
                stopwatch = new Stopwatch();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(downloadTestUrl);
                request.Method = "GET";
                request.Timeout = 30000; // 30 second timeout

                stopwatch.Start();

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    byte[] buffer = new byte[8192]; // Larger buffer for efficiency
                    int bytesRead;
                    downloadSize = 0;
                    long totalSize = response.ContentLength > 0 ? response.ContentLength : 100000000;
                    long lastReportSize = 0;
                    long lastSpeedUpdateTime = stopwatch.ElapsedMilliseconds;
                    long lastSpeedUpdateSize = 0;

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        downloadSize += bytesRead;

                        
                        if (downloadSize - lastReportSize > 1024 * 1024)
                        {
                            double progress = (double)downloadSize / totalSize * 50;
                            worker.ReportProgress((int)progress, $"Downloading: {downloadSize / 1024 / 1024} MB");
                            lastReportSize = downloadSize;
                        }

                       
                        long currentTime = stopwatch.ElapsedMilliseconds;
                        if (currentTime - lastSpeedUpdateTime >= 500)
                        {
                            
                            long sizeChange = downloadSize - lastSpeedUpdateSize;
                            double timeChangeSeconds = (currentTime - lastSpeedUpdateTime) / 1000.0;
                            double currentSpeed = (sizeChange * 8.0) / timeChangeSeconds / 1000000.0; // Mbps

                           
                            double currentProgress = (double)downloadSize / totalSize * 50;

                          
                            worker.ReportProgress((int)currentProgress, $"download-gauge-update:{currentSpeed:F2}");

                            lastSpeedUpdateTime = currentTime;
                            lastSpeedUpdateSize = downloadSize;
                        }

                        
                        if (worker.CancellationPending)
                        {
                            return 0;
                        }
                    }
                }

                stopwatch.Stop();

               
                double seconds = stopwatch.ElapsedMilliseconds / 1000.0;
                double bits = downloadSize * 8.0;
                double finalSpeed = bits / seconds / 1000000.0; 

            
                worker.ReportProgress(50, "download-complete");

                return finalSpeed;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Download test error: {ex.Message}");
                return 0;
            }
        }

        private double TestUploadSpeed()
        {
            try
            {
                stopwatch = new Stopwatch();

               
                byte[] testData = new byte[5 * 1024 * 1024];
                new Random().NextBytes(testData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uploadTestUrl);
                request.Method = "POST";
                request.ContentType = "application/octet-stream";
                request.ContentLength = testData.Length;
                request.Timeout = 30000; 

                stopwatch.Start();

                using (Stream stream = request.GetRequestStream())
                {
                    
                    int chunkSize = 1024 * 32;
                    uploadSize = 0;
                    long lastReportSize = 0;
                    long lastSpeedUpdateTime = stopwatch.ElapsedMilliseconds;
                    long lastSpeedUpdateSize = 0;

                    for (int i = 0; i < testData.Length; i += chunkSize)
                    {
                        int bytesToWrite = Math.Min(chunkSize, testData.Length - i);
                        stream.Write(testData, i, bytesToWrite);
                        uploadSize += bytesToWrite;

                        
                        if (uploadSize - lastReportSize > 128 * 1024) 
                        {
                            double progress = (double)uploadSize / testData.Length * 50;
                            worker.ReportProgress(50 + (int)progress, $"Uploading: {uploadSize / 1024 / 1024} MB");
                            lastReportSize = uploadSize;
                        }

                       
                        long currentTime = stopwatch.ElapsedMilliseconds;
                        if (currentTime - lastSpeedUpdateTime >= 100) 
                        {
                           
                            long sizeChange = uploadSize - lastSpeedUpdateSize;
                            double timeChangeSeconds = (currentTime - lastSpeedUpdateTime) / 1000.0;

                           
                            if (timeChangeSeconds > 0)
                            {
                                double currentSpeed = (sizeChange * 8.0) / timeChangeSeconds / 1000000.0; // Mbps

                              
                                Random rnd = new Random();
                                currentSpeed = currentSpeed * (0.98 + rnd.NextDouble() * 0.04); // +/- 2% fluctuation

                                
                                double currentProgress = (double)uploadSize / testData.Length * 50;

                              
                                worker.ReportProgress(50 + (int)currentProgress, $"upload-gauge-update:{currentSpeed:F2}");
                            }

                            lastSpeedUpdateTime = currentTime;
                            lastSpeedUpdateSize = uploadSize;
                        }

                        
                        System.Threading.Thread.Sleep(1);

                        if (worker.CancellationPending)
                        {
                            return 0;
                        }
                    }
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    
                }

                stopwatch.Stop();

                double seconds = stopwatch.ElapsedMilliseconds / 1000.0;
                double bits = uploadSize * 8.0;
                return bits / seconds / 1000000.0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Upload test error: {ex.Message}");
                return 0;
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            try
            {
              
                if (InvokeRequired)
                {
                    Invoke(new Action(() => ProgressTimer_Tick(sender, e)));
                    return;
                }

               
                if (pbdwn.Value < targetDownloadProgress)
                    pbdwn.Value = Math.Min(pbdwn.Value + 1, targetDownloadProgress);

                if (pbup.Value < targetUploadProgress)
                    pbup.Value = Math.Min(pbup.Value + 1, targetUploadProgress);

                
                if (pbup.Value == 100 && workCompleted && string.IsNullOrEmpty(txtupspeed.Text))
                {
                    // Now that upload progress bar is complete, update the upload speed text
                    txtupspeed.Text = $"{uploadSpeed:F2} Mbps";
                }

                // Check if we're done and progress bars are fully at 100%
                if (pbdwn.Value == 100 && pbup.Value == 100 && workCompleted)
                {
                    progressTimer.Stop();
                    // Re-enable the button
                    stgobtn.Enabled = true;
                    // Reset the flag for the next test
                    workCompleted = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Progress timer error: {ex.Message}");
                progressTimer.Stop(); // Stop the timer on error
            }

        }

        private void stform_Load(object sender, EventArgs e)
        {

        }

        private void menu_icon_Click(object sender, EventArgs e)
        {
            menupanel.Visible = !menupanel.Visible;
        }


        private void vpnhome_Click(object sender, EventArgs e)
        {
            // Look for existing main form
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

        private void dnsleak_Click(object sender, EventArgs e)
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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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
        }
    }
}
