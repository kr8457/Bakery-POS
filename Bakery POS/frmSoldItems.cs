using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class frmSoldItems : Form
    {
        public frmSoldItems()
        {
            InitializeComponent();
        }

        private void frmSoldItems_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // Assuming this is a close button
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Preview Clicked!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell {e.RowIndex}, {e.ColumnIndex} clicked!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Date Changed: " + dateTimePicker1.Value.ToShortDateString());
        }

        private void cbCashier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cashier Selected: " + cbCashier.SelectedItem?.ToString());
        }
    }
}
