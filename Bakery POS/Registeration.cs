using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;  // Import MySQL Library

namespace Bakery_POS
{
    public partial class Registeration : Form
    {
        // Database connection string
        private string connectionString = "server=localhost;database=mydb;user=root;password=khalid;";

        public Registeration()
        {
            InitializeComponent();
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
            string user = username.Text.Trim();
            string oldPass = password.Text;
            string newPass = confirmpassword.Text;
            string confirmNewPass = confirmpassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(oldPass) ||
                string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmNewPass))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != confirmNewPass)
            {
                MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verify old password
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @oldpassword";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", user);
                        checkCmd.Parameters.AddWithValue("@oldpassword", oldPass);  // You should use hashing for passwords

                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists == 0)
                        {
                            MessageBox.Show("Incorrect old password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update password
                    string updateQuery = "UPDATE users SET password = @newpassword WHERE username = @username";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@username", user);
                        updateCmd.Parameters.AddWithValue("@newpassword", newPass);  // Use hashing for security

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password change failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
        private void closebutton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';      // Show password
                confirmpassword.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';       // Hide password
                confirmpassword.PasswordChar = '*';
            }
        }




        private void password_TextChanged(object sender, EventArgs e) { }
        private void username_TextChanged(object sender, EventArgs e) { }
      
      
       






    }


}

