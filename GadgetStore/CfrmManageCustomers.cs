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
    public partial class CfrmManageCustomers : Form
    {
        public CfrmManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + txtCustomerId.Text + "','" + txtCustomerName.Text + "','" + txtCustomerPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Added");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void CfrmManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "")
            {
                MessageBox.Show("Enter The Customer ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where cCustomerId = '" + txtCustomerId.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set cCustomerId='" + txtCustomerId.Text + "',cCustomerName='" + txtCustomerName.Text + "',cCustomerPhone='" + txtCustomerPhone.Text + "' where cCustomerId ='" + txtCustomerId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully updated");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void CustomersGV_Click(object sender, EventArgs e)
        {
            try
            {

                txtCustomerId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
                txtCustomerName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
                txtCustomerPhone.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();

                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl  where CustId = " + txtCustomerId.Text + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblLable.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmt) from OrderTbl  where CustId = " + txtCustomerId.Text + "", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                lblAmount.Text = dt1.Rows[0][0].ToString();

                SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl  where CustId = " + txtCustomerId.Text + "", Con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                lblDate.Text = dt2.Rows[0][0].ToString();

                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error. \nInsert valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CfrmHome home = new CfrmHome();
            home.Show();
            this.Hide();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {

            //txtCustomerId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            //txtCustomerName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            //txtCustomerPhone.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCustomerId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            //txtCustomerName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            //txtCustomerPhone.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            //Con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl  where CusId = " + txtCustomerId.Text + "", Con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //lblLable.Text = dt.Rows[0][0].ToString();
            //Con.Close();
        }
    }
}
