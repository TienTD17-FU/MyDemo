using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txta.BackColor = Color.Pink;
        }

        private void txta_Leave(object sender, EventArgs e)
        {
            txta.BackColor = Color.White;
        }

        private void txtb_Enter(object sender, EventArgs e)
        {
            txtb.BackColor = Color.Pink;
        }

        private void txtb_Leave(object sender, EventArgs e)
        {
            txtb.BackColor = Color.White;
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (!txta.Text.Equals("") || !txtb.Text.Equals(""))
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (!txta.Text.Equals("") && !txtb.Text.Equals(""))
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (!txta.Text.Equals("") || !txtb.Text.Equals(""))
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (!txta.Text.Equals("") && !txtb.Text.Equals(""))
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"May co muon thoat khong?","Confirm",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtResult.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Check input
            int a;
            try
            {
                a = Convert.ToInt32(txta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this,"May nhap gi cho a the!","Mang chui");
                return;
            }

            int b;
            try
            {
                b = Convert.ToInt32(txtb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "May nhap gi cho b the!", "Mang chui");
                return;
            }

            //Check xem da chon phepmtinh chua?
            if (cboOperator.SelectedItem==null)
            {
                MessageBox.Show("May chua chon phep tinh ah?");
                return;
            }

            //Tinh toan va hien thi ket qua
            if (cboOperator.SelectedItem.ToString().Trim().Equals("+"))
            {
                txtResult.Text = (a + b).ToString();
            }

            if (cboOperator.SelectedItem.ToString().Trim().Equals("-"))
            {
                txtResult.Text = (a - b).ToString();
            }

            if (cboOperator.SelectedItem.ToString().Trim().Equals("*"))
            {
                txtResult.Text = (a * b).ToString();
            }

            if (cboOperator.SelectedItem.ToString().Trim().Equals("/"))
            {
                txtResult.Text = (a / b).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Khi cua so duoc mo thi thuc hien yeu cau gi do
            MessageBox.Show("Chung may co hieu khong?");
        }

        
    }
}
