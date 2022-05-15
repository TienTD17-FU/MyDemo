using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsa_Click(object sender, EventArgs e)
        {
            //chung ta se viet code o day
            if(MessageBox.Show(null,"Ban co muon chuyen nen xanh khong?","Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
