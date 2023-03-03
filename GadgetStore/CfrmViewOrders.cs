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
    public partial class CfrmViewOrders : Form
    {
        public CfrmViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KMDEEP\Documents\Phonedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populateProducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                vOrderGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void CfrmViewOrders_Load(object sender, EventArgs e)
        {
            populateProducts();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void vOrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
        //    {
        //        printDocument1.Print();
        //    }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order ID: " + vOrderGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Customer ID: " + vOrderGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 136));
            e.Graphics.DrawString("Customer Name: " + vOrderGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Order Date: " + vOrderGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Amount: R" + vOrderGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            e.Graphics.DrawString("Powered By KM Solutions", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));
        }

        private void vOrderGV_Click(object sender, EventArgs e)
        {
            lblName.Text = vOrderGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            string myquery = "delete from OrderTbl where OrderId = '" + lblName.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Deleted");
            Con.Close();
            populateProducts();
        }
    }
}
