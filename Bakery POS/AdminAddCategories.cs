using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bakery_POS
{
    public partial class AdminAddCategories : UserControl
    {
        string connectionString = "server=localhost;database=mydb;uid=root;pwd=khalid;";

        public AdminAddCategories()
        {
            InitializeComponent();
            LoadCategories();
            dgvCategories.CellClick += dgvCategories_CellClick; // Ensure event is assigned
        }

        private void LoadCategories()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, category, COALESCE(date, CURDATE()) AS date FROM categories", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategories.DataSource = dt;

                // Ensure correct column names
                dgvCategories.Columns[0].HeaderText = "ID";
                dgvCategories.Columns[1].HeaderText = "Category";
                dgvCategories.Columns[2].HeaderText = "Date";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (category.Text.Trim() == "")
            {
                MessageBox.Show("Enter a category name!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO categories (category, date) VALUES (@category, CURDATE())";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@category", category.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            LoadCategories();
            category.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);
                string newCategory = category.Text.Trim();

                if (string.IsNullOrEmpty(newCategory))
                {
                    MessageBox.Show("Enter a valid category name!");
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE categories SET category=@category WHERE id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@category", newCategory);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadCategories();
                category.Clear();
            }
            else
            {
                MessageBox.Show("Select a category to update!");
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM categories WHERE id=@id";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadCategories();
                    category.Clear();
                }
            }
            else
            {
                MessageBox.Show("Select a category to remove!");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            category.Clear();
            dgvCategories.ClearSelection();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                category.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                dgvCategories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AdminAddCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
