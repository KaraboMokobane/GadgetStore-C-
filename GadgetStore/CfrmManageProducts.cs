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
    public partial class CfrmManageProducts : Form
    {
        public CfrmManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void Filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where productCategory ='" + cmbSearch.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "CategoryName";
                comboBox1.DataSource = dt;
                cmbSearch.ValueMember = "CategoryName";
                cmbSearch.DataSource = dt;
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

        private void CfrmManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + txtProID.Text + ",'" + txtProName.Text + "'," + txtProQty.Text + "," + txtProPrice.Text + ",'" + txtProDesc.Text + "','" + comboBox1.SelectedValue.ToString()+ "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully Added");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProID.Text == "")
            {
                MessageBox.Show("Enter The Category ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProductId = '" + txtProID.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProductName='" + txtProName.Text + "',ProductQty=" + txtProQty.Text + ",ProductPrice=" + txtProPrice.Text + ",ProductDesc='" + txtProDesc.Text + "',ProductCategory='" + comboBox1.SelectedValue.ToString() + "' where ProductId =" + txtProID.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully updated");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            CfrmHome home = new CfrmHome();
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            txtProID.Clear();
            txtProName.Clear();
            txtProQty.Clear();
            txtProPrice.Clear();
            txtProDesc.Clear();
            comboBox1.SelectedValue = "";
        }
        private void ProductGV_Click(object sender, EventArgs e)
        {
            txtProID.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            txtProName.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            txtProQty.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            txtProPrice.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            txtProDesc.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        //OUt
        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    txtProID.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            //    txtProName.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            //    txtProQty.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            //    txtProPrice.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            //    txtProDesc.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            //    comboBox1.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();

        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            //txtProID.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            //txtProName.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            //txtProQty.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            //txtProPrice.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            //txtProDesc.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            //comboBox1.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtProID.Clear();
            txtProName.Clear();
            txtProQty.Clear();
            txtProPrice.Clear();
            txtProDesc.Clear();
            comboBox1.SelectedValue = "";
        }


    }
}
