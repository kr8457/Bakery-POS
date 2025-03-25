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
    public partial class CashierMainform : Form
    {
        public CashierMainform()
        {
            InitializeComponent();
            label5.Text = "Welcome, " + UserSession.UserName + "(" + UserSession.Role + ")";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CashierMainform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
