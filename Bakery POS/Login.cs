using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bakery_POS
{
    public partial class Login : Form
    {
        private MySqlConnection connection;

        public Login()
        {
            InitializeComponent();

            string connectionString = "Server=localhost;Database=mydb;User ID=root;Password=khalid;";
            connection = new MySqlConnection(connectionString);

            // Move cursor to password field when Enter is pressed in the username field
            textBox1.KeyDown += textBox1_KeyDown;

            // Trigger login when Enter is pressed in the password field
            textBox2.KeyDown += textBox2_KeyDown;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string query = "SELECT password, role FROM users WHERE username = @username;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader.GetString(0);
                        string status = reader.GetString(1);
                        if (password == storedPassword)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            if (status == "Admin")
                            {
                                UserSession.Role = "Admin";
                                UserSession.UserName = username;
                                Mainform mainform = new Mainform();
                                mainform.Show();
                            }
                            else
                            {
                                UserSession.Role = "Cashier";
                                UserSession.UserName = username;
                                CashierMainform cashierMainform = new CashierMainform();
                                cashierMainform.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Move cursor to password field when Enter is pressed in the username field
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the "ding" sound
                textBox2.Focus(); // Move cursor to password field
            }
        }

        // Trigger login when Enter is pressed in the password field
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the "ding" sound
                loginbutton_Click(loginbutton, EventArgs.Empty); // Simulate button click
            }
        }

       


        private void showpasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = showpasswordcheckBox.Checked ? '\0' : '\u2022';
        }
    }

    public static class UserSession
    {
        // These will be used in the cashier mainform for role and username
        public static string UserName { get; set; } = string.Empty;
        public static string Role { get; set; } = string.Empty;
    }


}


