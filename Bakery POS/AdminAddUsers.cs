using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bakery_POS
{
    public partial class AdminAddUsers : Form
    {
        public AdminAddUsers()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminAddUsers_Load(object sender, EventArgs e)
        {
           
        
            if (username.Text == "" || password.Text == ""
                || role.SelectedIndex == -1 || status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connString = "server=localhost;database=mydb;user=root;password=khalid;";
                using (MySqlConnection connect = new MySqlConnection(connString))
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";

                        using (MySqlCommand cmd = new MySqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", username.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(username.Text.Trim()
                                    + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                                    "VALUES(@usern, @pass, @role, @status, @date)";

                                using (MySqlCommand insertD = new MySqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                }

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    
}
