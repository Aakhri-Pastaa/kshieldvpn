using Kshieldvpn;
using KshieldVPN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kshieldvpn
{
    public partial class Login_Form : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Login_Form()
        {
            InitializeComponent();
        }
        //git test
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = Form2.HashPassword(enteredPassword).Trim();
            storedHash = storedHash.Trim();

            // Debugging output
            Debug.WriteLine("Entered Hash: [" + enteredHash + "]\nStored Hash: [" + storedHash + "]");

            return string.Equals(enteredHash, storedHash, StringComparison.OrdinalIgnoreCase);

        }
       
        String sql = "Data Source=LAPTOP-3MTSTMEJ\\SQLEXPRESS01;Initial Catalog=KshieldVPN;Integrated Security=True;TrustServerCertificate=True";


        private void Login_Form_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(sql);
                cn.Open();

                string userEmail = KshieldVPN.Properties.Settings.Default.UserEmail;

                if (!string.IsNullOrEmpty(userEmail))
                {
                    // Set session
                    SessionManager.IsLoggedIn = true;
                    SessionManager.Email = userEmail;
                    SessionManager.IsPremium = CheckIfUserIsPremium(userEmail);

                    // Create main form but don't show it yet
                    Kshieldvpn1 home = new Kshieldvpn1();

                    // Use BeginInvoke to delay opening the main form and closing this one
                    this.BeginInvoke(new Action(() => {
                        home.Show();
                        this.Hide(); // Just hide instead of close
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidateLoginInputs()
        {
            // Basic email regex pattern
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }

            return true;
        }
        private bool CheckIfUserIsPremium(string email)
        {
            bool isPremium = false;

            using (SqlConnection cn = new SqlConnection(sql))
            {
                cn.Open();
                string query = "SELECT IsPremium FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Email", email);

                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    isPremium = Convert.ToBoolean(result);
                }
            }

            return isPremium;
        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }




        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (ValidateLoginInputs())
            {
                if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPass.Text))
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(sql))
                        {
                            cn.Open();

                            // Secure parametrized query
                            SqlCommand cmd = new SqlCommand("SELECT Password, IsPremium FROM Users WHERE Email = @Email", cn);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                string hashedPassword = dr.GetString(0);
                                bool isPremium = false;

                                if (!dr.IsDBNull(1))
                                    isPremium = dr.GetBoolean(1); // Get premium status

                                if (VerifyPassword(txtPass.Text, hashedPassword))
                                {
                                    dr.Close();

                                    // Save email in app settings
                                    KshieldVPN.Properties.Settings.Default.RememberMe = true;
                                    KshieldVPN.Properties.Settings.Default.UserEmail = txtEmail.Text;
                                    KshieldVPN.Properties.Settings.Default.Save();

                                    SessionManager.Email = txtEmail.Text;
                                    SessionManager.IsPremium = isPremium;
                                    SessionManager.IsLoggedIn = true;

                                    // Open main form
                                    Kshieldvpn1 home = new Kshieldvpn1();
                                    home.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    dr.Close();
                                    MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("No account available with this email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frpwd_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
    
        }

        /*private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                ep.SetError(txtUser, "Username should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtUser, "");
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                e.Cancel = true;
                txtPass.Focus();
                eppwd.SetError(txtPass, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                eppwd.SetError(txtPass, "");
            }
        }*/
    //}
//}