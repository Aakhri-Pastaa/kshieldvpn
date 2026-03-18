using Guna.UI2.WinForms;
using Kshieldvpn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KshieldVPN
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
          

        }
        private bool ValidateInputs()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(emailtxt.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailtxt.Focus();
                return false;
            }
            else if (!Regex.IsMatch(emailtxt.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailtxt.Focus();
                return false;
            }
           

            return true;

        }

        private async void rstpwd_Click(object sender, EventArgs e)
        {
            string email = emailtxt.Text;

                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(new { Email = email });
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("https://localhost:44359/api/auth/send-reset-link", content);

                    if (response.IsSuccessStatusCode)
                        MessageBox.Show("Reset link sent to your email.");
                    else
                        MessageBox.Show("Failed to send link.");
                }
            }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form f2 = new Login_Form();
            f2.ShowDialog();
        }
    }
    }

