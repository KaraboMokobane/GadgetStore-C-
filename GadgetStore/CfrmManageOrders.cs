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
    public partial class CfrmManageOrders : Form
    {
        public CfrmManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable table = new DataTable();

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
                oCustomerGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void populateProducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                oProductsGV.DataSource = ds.Tables[0];
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
                cmboCategory.ValueMember = "CategoryName";
                cmboCategory.DataSource = dt;
                //cmbSearch.ValueMember = "CategoryName";
                //cmbSearch.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void updateproducts()
        {
            
            int id = Convert.ToInt32(oProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(txtQty.Text);

            if (newQty < 0)
            {
                MessageBox.Show("operation Failed");
            }
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProductQty = " + newQty + " where ProductId = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateProducts();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void cmboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
              try
              {
                    Con.Open();
                    string Myquery = "select * from ProductTbl where ProductCategory ='" + cmboCategory.SelectedValue.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    oProductsGV.DataSource = ds.Tables[0];
                    Con.Close();

              }
              catch
              {

              }          
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void CfrmManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillcategory();

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));

            oOrderGV.DataSource = table;
        }

        private void oCustomerGV_Click(object sender, EventArgs e)
        {
            txtoCustomerId.Text = oCustomerGV.SelectedRows[0].Cells[0].Value.ToString();
            txtCusName.Text = oCustomerGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        int flag = 0;
        int stock;

        private void oProductsGV_Click(object sender, EventArgs e)
        {
            product = oProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(txtQty.Text);
            stock = Convert.ToInt32(oProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(oProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        int sum = 0;
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            if (txtQty.Text == "")
            {
                MessageBox.Show("Enter Quantity of Products");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Select The Product");
            }
            else if(Convert.ToUInt32(txtQty.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Available");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(txtQty.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                oOrderGV.DataSource = table;
                flag = 0;
            }

            sum = sum + totprice;
            lblTotAmount.Text = sum.ToString();
            updateproducts();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (txtoOrderId.Text == "" || txtoCustomerId.Text == "" || txtCusName.Text == "" || lblTotAmount.Text == "")
            {
                MessageBox.Show("Fill The data Correctly");
            }
            else
            {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values(" + txtoOrderId.Text + ",'" + txtoCustomerId.Text + "','" + txtCusName.Text + "','" + dateTimePicker1.Text + "'," + lblTotAmount.Text + ")", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
            }
        }
        
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            CfrmViewOrders view = new CfrmViewOrders();
            view.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            CfrmHome home = new CfrmHome();
            home.Show();
            this.Hide();
        }
    }
}
