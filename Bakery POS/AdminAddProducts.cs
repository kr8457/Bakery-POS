using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bakery_POS
{
    public partial class AdminAddProducts : UserControl
    {
        // MySQL Connection String
        string connectionString = "server=localhost;user=root;database=mydb;password=khalid;";

        public AdminAddProducts()
        {
            InitializeComponent();
            this.Load += AdminAddProducts_Load;
        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[] { "Sweet", "Bakery" });
            cmbStatus.Items.AddRange(new string[] { "Available", "Out of Stock" });
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtPrice.Text == "" || txtStock.Text == "" || cmbCategory.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO products (Name, Category, PricePerKg, PricePerUnit, StockQuantity, UnitType, date_added, status) " +
                                   "VALUES (@name, @category, @pricePerKg, @pricePerUnit, @stock, @unitType, @dateAdded, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@pricePerKg", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@pricePerUnit", DBNull.Value);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@unitType", "kg");
                    cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully!");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Select a product to remove.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM products WHERE ProductID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtProductID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Removed!");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Select a product to update.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE products SET Name=@name, Category=@category, PricePerKg=@price, StockQuantity=@stock, status=@status WHERE ProductID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtProductID.Text);
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Updated!");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                // Assigning values with NULL check
                txtProductID.Text = row.Cells["ProductID"].Value?.ToString() ?? "";
                txtProductName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                cmbCategory.Text = row.Cells["Category"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["PricePerKg"].Value?.ToString() ?? row.Cells["PricePerUnit"].Value?.ToString() ?? "";
                txtStock.Text = row.Cells["StockQuantity"].Value?.ToString() ?? "";
                cmbStatus.Text = row.Cells["status"].Value?.ToString() ?? "";
            }
        }
    }
}
