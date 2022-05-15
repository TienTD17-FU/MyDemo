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

namespace DB_Winform
{
    public partial class FrmLogin : Form
    {
        //Khai bao cac thanh phan xu ly DB
        SqlConnection cnn; //Ket noi DB
        SqlDataAdapter da; //Truy xuat du lieu (select)
        SqlCommand cmd; //Thuc hien cac cau lenh insert,update,delete


        public FrmLogin()
        {
            InitializeComponent();
            connect();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check xem account co ton tai trong tblUser khong?
            try
            {
                String strSelect = "Select * from tblUser where account='"+txtAccount.Text+"' and pass='"+txtPass.Text+"'";
                da = new SqlDataAdapter(strSelect, cnn);
                DataTable dt = new DataTable(); //Chua du lieu sau khi select
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    //Login thanh cong
                    MessageBox.Show("Login succewss");
                    FrmCustomer f = new FrmCustomer();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    //Login that bai
                    MessageBox.Show("Login fail!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login fail:"+ex.Message);
                throw;
            }
        }
    }
}
