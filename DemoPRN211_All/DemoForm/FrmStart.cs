using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Goi thang Timer thuc hien countdown
            timer1.Start();
        }

        int n = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            n--;
            if (n==0)
            {
                timer1.Stop();
                FrmStudent f = new FrmStudent();
                f.Show();
                this.Hide();
            }
            lblStart.Text = n.ToString();
        }
    }
}
