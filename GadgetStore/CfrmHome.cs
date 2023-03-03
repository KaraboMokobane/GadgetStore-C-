using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CfrmHome : Form
    {
        public CfrmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CfrmManageProducts prod = new CfrmManageProducts();
            prod.Show();
            this.Hide();
        }

        private void picCat_Click(object sender, EventArgs e)
        {
            CfrmManageCategories cat = new CfrmManageCategories();
            cat.Show();
            this.Hide();
        }

        private void picUsers_Click(object sender, EventArgs e)
        {
            CfrmManageUser uesr = new CfrmManageUser();
            uesr.Show();
            this.Hide();
        }

        private void picOrders_Click(object sender, EventArgs e)
        {
            CfrmManageOrders ord = new CfrmManageOrders();
            ord.Show();
            this.Hide();
        }

        private void picCus_Click(object sender, EventArgs e)
        {
            CfrmManageCustomers cus = new CfrmManageCustomers();
            cus.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CfrmPhones login = new CfrmPhones();
            login.Show();
            this.Hide();
        }
    }
}
