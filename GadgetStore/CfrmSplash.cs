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
    public partial class CfrmSplash : Form
    {
        public CfrmSplash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            progressBar2.Value = startpoint;
            if (progressBar1.Value == 100 && progressBar2.Value == 100) 
            {
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                timer1.Stop();
                CfrmPhones login = new CfrmPhones();
                this.Hide();
                login.Show();
            }
        }

        private void CfrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
