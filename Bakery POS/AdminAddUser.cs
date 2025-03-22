using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace Bakery_POS
{
    public partial class AdminAddUser : UserControl
    {
        private int getID = 0; // Initialize getID properly

        public AdminAddUser()
        {
            InitializeComponent();
            DisplayAllUsersData();

            // Attach the corrected CellClick event
            dataGridView2.CellClick += dataGridView1_CellClick;
        }

        public void DisplayAllUsersData()
        {
            UserData uData = new UserData();
            List<User> listData = uData.GetAllUsers();

            dataGridView2.DataSource = listData;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                role.SelectedIndex == -1 ||
                status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                            MessageBox.Show($"{username.Text.Trim()} is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                                "VALUES(@usern, @pass, @role, @status, @date)";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertData, connect))
                            {
                                insertCmd.Parameters.AddWithValue("@usern", username.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@pass", password.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString());
                                insertCmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
                                insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                                insertCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayAllUsersData(); // Refresh DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                role.SelectedIndex == -1 ||
                status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (getID == 0)
            {
                MessageBox.Show("No user selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connString = "server=localhost;database=mydb;user=root;password=khalid;";
            using (MySqlConnection connect = new MySqlConnection(connString))
            {
                try
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @usern AND UserID != @id";

                    using (MySqlCommand cmd = new MySqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", getID);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show($"{username.Text.Trim()} is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string updateData = "UPDATE users SET username = @usern, " +
                                                "password = @pass, role = @role, status = @status WHERE UserID = @id";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateData, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@usern", username.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@pass", password.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString());
                                updateCmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DisplayAllUsersData(); // Refresh DataGridView
                                }
                                else
                                {
                                    MessageBox.Show("User update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure a row is clicked, not the column header
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // ✅ Make sure column names match exactly as in DataGridView
                getID = Convert.ToInt32(row.Cells["UserID"].Value);
                username.Text = row.Cells["username"].Value.ToString(); // Check correct column name
                password.Text = row.Cells["password"].Value.ToString();
                role.SelectedItem = row.Cells["role"].Value.ToString();
                status.SelectedItem = row.Cells["status"].Value.ToString();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {


            if (dataGridView2.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["UserID"].Value);

                string connString = "server=localhost;database=mydb;user=root;password=khalid;";
                using (MySqlConnection connect = new MySqlConnection(connString))
                {
                    connect.Open();
                    string query = "DELETE FROM users WHERE UserID = @UserID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }

                DisplayAllUsersData(); // 🔹 Refresh DataGridView after deleting
                MessageBox.Show("User removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Refresh DataGridView


        private void clear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            role.SelectedIndex = -1;
            status.SelectedIndex = -1;
        }

        private void cuiDataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void cuiDataGridView1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
