using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFWinApp.Models;

namespace EFWinApp
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        MyOrderContext context=new MyOrderContext();

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                loadCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void loadCustomer()
        {
            var dcustomer = (from c in context.Customer select new {c.CustomerId,c.CustomerName }).ToList();
            dgCustomer.DataSource = dcustomer;

        }
    }
}
