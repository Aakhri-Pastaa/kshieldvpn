using Kshieldvpn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kshieldvpn
{
    public partial class Form2 : Form
    {
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$!%*?&])[A-Za-z\d@#$!%*?&]{8,}$";

            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2TextBox1.Focus();
                return false;
            }
            else if (!Regex.IsMatch(guna2TextBox1.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2TextBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtPass.Text, passwordPattern))
            {
                MessageBox.Show("Password must be at least 8 characters long, include at least:\n• 1 uppercase letter\n• 1 lowercase letter\n• 1 number\n• 1 special character (e.g. @#$!)",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Please confirm your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2TextBox2.Focus();
                return false;
            }
            else if (txtPass.Text != guna2TextBox2.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2TextBox2.Focus();
                return false;
            }

            return true;

        }

       

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())  // Secure hashing algorithm
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes); // Convert to string for storage
            }
        }
        
        string sql = "Data Source=LAPTOP-3MTSTMEJ\\SQLEXPRESS01;Initial Catalog=KshieldVPN;Integrated Security=True;TrustServerCertificate=True";

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs()) { 
                if (guna2TextBox2.Text != string.Empty && txtPass.Text != string.Empty && guna2TextBox1.Text != string.Empty)
                {
                    
                        if (txtPass.Text == guna2TextBox2.Text)
                        {



                            SqlConnection sqlConnection = new SqlConnection(sql);
                            sqlConnection.Open();
                            string query = $"INSERT INTO Users (Email, Password) values ('{guna2TextBox1.Text}','{HashPassword(txtPass.Text)}')";
                            SqlCommand cmd = new SqlCommand(query, sqlConnection);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Focus();

                            this.Hide();
                            Login_Form f = new Login_Form();
                            f.Show();


                        }
                        else
                        {
                            MessageBox.Show("Password doesn't match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form f2 = new Login_Form();
            f2.ShowDialog();
        }

      

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
