using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CfrmPhones : Form
    {
        public CfrmPhones()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");


        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl where Uname = '" + txtUserName.Text + "' and Upassword = '" + txtPassword.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                CfrmHome cust = new CfrmHome();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Psssword");
            }
            Con.Close();
        }

        private void CfrmPhones_Load(object sender, EventArgs e)
        {

        }
    }
}
