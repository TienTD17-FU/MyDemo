using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Winform
{
    public partial class FrmCustomer : Form
    {
        //Khai bao cac thanh phan xu ly DB
        SqlConnection cnn; //Ket noi DB
        SqlDataAdapter da; //Truy xuat du lieu (select)
        SqlCommand cmd; //Thuc hien cac cau lenh insert,update,delete

        private void connect()
        {
            try
            {
                String strCnn = "Data Source=localhost;Initial Catalog=ProductOrder;Integrated Security=True";
                cnn = new SqlConnection(strCnn);

                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                //MessageBox.Show("Connect success!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail connect:" + e.Message);
                throw;
            }
        }


       
        public FrmCustomer()
        {
            InitializeComponent();
            connect();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void loadCustomer()
        {
            try
            {
                String strSelect = "Select * from tblCustomer";
                da = new SqlDataAdapter(strSelect, cnn);
                DataTable dt = new DataTable(); //Chua du lieu sau khi select
                da.Fill(dt);

                dgCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load Customer:" +ex.Message);
                throw;
            }
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                txtCode.Text = dgCustomer.Rows[e.RowIndex].Cells["CustomerID"].FormattedValue.ToString();
                txtName.Text = dgCustomer.Rows[e.RowIndex].Cells["CustomerName"].FormattedValue.ToString();

                if (dgCustomer.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString().Equals("True"))
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }

                txtAddress.Text = dgCustomer.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtBirthdate.Text = dgCustomer.Rows[e.RowIndex].Cells["Birthdate"].FormattedValue.ToString();
                txtCode.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "False";
            if (rdMale.Checked)
            {
                gender = "True";
            }

            try
            {   
                string strUpdate = "Update tblCustomer set CustomerName='"+txtName.Text+"',Birthdate='"+txtBirthdate.Text+"', Gender='"+gender+"', Address='"+txtAddress.Text+"' where CustomerID='"+txtCode.Text+"'";
                cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strUpdate;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update success");
                loadCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi Update:"+ex.Message);
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
