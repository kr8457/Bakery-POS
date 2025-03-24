using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_POS
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            label5.Text = "Welcome, " + Login.UserName + "(" + Login.Role + ")";

        }

        private void LoadControl(UserControl control)
        {
            panel1.Controls.Clear(); // Clear existing controls
            control.Dock = DockStyle.Fill; // Make it fill the panel
            panel1.Controls.Add(control);
            control.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message"
         , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }




        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message"
        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }



        private void Admin_db(object sender, EventArgs e)
        {

            LoadControl(new admindb());
        }

        private void Adminaddusers(object sender, EventArgs e)
        {
            LoadControl(new AdminAddUser());
        }

        private void adminaddcategories(object sender, EventArgs e)
        {
            LoadControl(new AdminAddCategories());
        }

        private void adminaddproducts(object sender, EventArgs e)
        {
            LoadControl(new AdminAddProducts());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void admindb1_Load(object sender, EventArgs e)
        {

        }
    }
}