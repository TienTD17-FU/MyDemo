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
    public partial class FrmStudent : Form
    {
        Dictionary<string, string> dStudent = new Dictionary<string, string>();
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student SV = new Student(txtCode.Text, txtName.Text, cboSubject.SelectedItem.ToString(), Convert.ToInt32(numMark.Value));

            if (dStudent.ContainsKey(SV.code))
            {
                MessageBox.Show("Ma nay da ton tai");
                return;
            }
            lstStudent.Items.Add(SV.code + " " + SV.name + " " + SV.subject + " " + SV.mark);
            dStudent.Add(SV.code, SV.name);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Bạn muốn exit?","Alert",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
