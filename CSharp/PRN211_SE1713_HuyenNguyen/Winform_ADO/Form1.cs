using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Winform_ADO
{
    public partial class Form1 : Form
    {
        DataProvider d = new DataProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* 
            string strSelect = "SELECT * FROM Users WHERE " + "account = '"
                + txtAccount.Text + "' AND password = '" + txtPassword.Text + "'";
            DataTable dt = d.executeQuery(strSelect);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfully.");
            }
            else
            {
                MessageBox.Show("Login failed.");
            } 
            */
            string strSelect = "SELECT * FROM Users WHERE " + "account = @acc AND password = @pass";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@acc", txtAccount.Text),
                new SqlParameter("@pass", txtPassword.Text)
            };
            bool check = false;
            using (IDataReader dataReader = d.executeQuery2(strSelect, param))
            {
                if (dataReader.Read())
                {
                    check = true;
                }
                else
                {
                    MessageBox.Show("Login failed.");
                }
            }
            if (check)
            {
                MessageBox.Show("Login successfully.");
                string name = getNameByAccount(txtAccount.Text);
                FrmCustomer customerForm = new FrmCustomer(name);
                this.Hide();
                customerForm.Show();
            }
            /*
            IDataReader dr = d.executeQuery2(strSelect, param);
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Login successfully.");
                string name = getNameByAccount(txtAccount.Text);
                FrmCustomer customerForm = new FrmCustomer(name);
                this.Hide();
                customerForm.Show();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
            dr.Close();
            */
        }

        private string getNameByAccount(string text)
        {

            String name = "";
            string strSelect = "SELECT * FROM Users WHERE " + "account = @acc";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@acc", txtAccount.Text),
            };
            using (IDataReader dr = d.executeQuery2(strSelect, param))
            {
                if (dr.Read())
                {
                    name = dr.GetString(2);
                }
            }
            //IDataReader dr = d.executeQuery2(strSelect, param);
            //dr.Close();
            return name;
        }
    }
}