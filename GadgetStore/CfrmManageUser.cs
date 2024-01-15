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
    public partial class CfrmManageUser : Form
    {
        public CfrmManageUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {

            CfrmHome home = new CfrmHome();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            { 
            }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + txtUserName1.Text + "','" + txtFullName.Text + "','" + txtPassword1.Text + "','" + txtteleohone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Added");
                Con.Close();
                populate();

            }
            catch 
            {

                
            }
        }

        private void CfrmManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtteleohone.Text == "")
            {
                MessageBox.Show("Enter The User Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone = '" + txtteleohone.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + txtUserName1.Text + "',UFullname='" + txtFullName.Text + "',UPassword='" + txtPassword1.Text + "' where Uphone ='" + txtteleohone.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully updated");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }

        private void UsersGV_Click(object sender, EventArgs e)
        {
            txtUserName1.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            txtFullName.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword1.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            txtteleohone.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            txtUserName1.Clear();
            txtFullName.Clear();
            txtPassword1.Clear();
            txtteleohone.Clear();
        }
    }
}
