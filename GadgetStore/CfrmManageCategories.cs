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
    public partial class CfrmManageCategories : Form
    {
        public CfrmManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values(" + txtCategoryId.Text + ",'" + txtCategoryName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Succesfully Added");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == "")
            {
                MessageBox.Show("Enter The Category ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTbl where CategoryId = '" + txtCategoryId.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CategoryId='" + txtCategoryId.Text + "',CategoryName='" + txtCategoryName.Text + "' where CategoryId ='" + txtCategoryId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Succesfully updated");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void CfrmManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CfrmHome home = new CfrmHome();
            home.Show();
            this.Hide();
        }

        private void CategoryGV_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            txtCategoryName.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
        }
    }
}
