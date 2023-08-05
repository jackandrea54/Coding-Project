using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_ADO
{
    public partial class FrmCustomer : Form
    {
        DataProvider dp = new DataProvider();
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public FrmCustomer(object name)
        {
            InitializeComponent();
            Text = "Welcome " + name;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            List<Customer> data = new List<Customer>();

            // lay du lieu tu bang customer va add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string name = dr.GetString(1);
                    string dob = dr.GetDateTime(2).ToString();
                    string gender = dr.GetBoolean(3).ToString();
                    string address = dr.GetString(4);
                    Customer c = new Customer(id, name, dob, gender, address);
                    data.Add(c);
                }
            }

            // add data vao data grid
            dgCustomer.DataSource = data;
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtId.Text = dgCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtAddress.Text = dgCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtDob.Text = dgCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            if (dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True"))
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }

        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(txtId.Text);
            }
            catch
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            String strSQL = "DELETE FROM Customers WHERE CustomerId = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            if (dp.executeNonQuery(strSQL, parameters))
            {
                MessageBox.Show("Delete successfully.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string dob = txtDob.Text;
            bool gender = true;
            if (!isValidSubmission(name, address, dob))
            {
                return;
            }
            if (rdFemale.Checked)
            {
                gender = false;
            }
            if (rdMale.Checked)
            {
                gender = true;
            }

            string insertSQL = "INSERT [dbo].[Customers] ([CustomerName], [Birthdate], [Gender], [Address]) VALUES (@name, @dob, @gender, @address)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", name),
                new SqlParameter("@dob", dob),
                new SqlParameter("@gender", gender),
                new SqlParameter("@address", address)
            };
            if (dp.executeNonQuery(insertSQL, parameters))
            {
                MessageBox.Show("Insert successfully.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Insert failed.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtDob.Text = "";
            txtId.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
        }

        /*
         * 1 - find user by id: if id valid => find user
         * 2 - if user exist => validate inputs
         * 3 - if inputs valid => update user with query
         * 4 - if update successfully => reload data for dgCustomer
         */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(txtId.Text);
            }
            catch
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            bool check = true;
            // if any field is invalid => show error message
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers WHERE CustomerId  = @id", parameters))
            {
                if (dr.Read())
                {
                    //exist customer with such id, update them
                    if (!isValidSubmission(txtName.Text, txtAddress.Text, txtDob.Text))
                    {
                        // validate input
                        check = false;
                        return;
                    }
                }
                else
                {
                    // no customer with such id, display error message
                    MessageBox.Show("No customer with such ID found.");
                    return;
                }
            }
            if (check)
            {
                // all inputs valid, update customer
                updateCustomer(id);
            }

        }

        /// <summary>
        /// Validate input of fields: name, address, dob, gender
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="dob"></param>
        /// <returns></returns>
        private bool isValidSubmission(string name, string address, string dob)
        {
            if (name.Length == 0 || address.Length == 0 || dob.Length == 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            try
            {
                DateTime dt = DateTime.Parse(dob);
            }
            catch
            {
                MessageBox.Show("Invalid date format");
                return false;
            }

            if (!rdFemale.Checked && !rdMale.Checked)
            {
                MessageBox.Show("Please choose gender.");
                return false;
            }

            return true;
        }

        private void updateCustomer(int id)
        {
            DateTime dob = DateTime.Parse(txtDob.Text);
            bool gender = rdFemale.Checked ? false : true;
            string updateQuery = "UPDATE Customers " +
                "SET CustomerName = @name, " +
                "Birthdate = @dob, " +
                "Gender = @gender, " +
                "Address = @address " +
                "WHERE CustomerId = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", txtName.Text),
                new SqlParameter("@dob", dob),
                new SqlParameter("@gender", gender),
                new SqlParameter("@address", txtAddress.Text),
                new SqlParameter("@id", id)
            };
            if (dp.executeNonQuery(updateQuery, parameters))
            {
                MessageBox.Show("Update successfully.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Update failed,");
            }
        }
    }
}
