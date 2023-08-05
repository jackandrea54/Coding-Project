using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_EF.Models;

namespace WinForms_EF
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {

                List<Customer> customers = new List<Customer>();

                // get du lieu tu DB, su dung EF
                customers = context.Customers.ToList();

                dgCustomer.DataSource = customers;


                // load du lieu len cac textbox khac
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", customers, "CustomerId");

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", customers, "CustomerName");

                txtDob.DataBindings.Clear();
                txtDob.DataBindings.Add("Text", customers, "Birthdate");

                txtAddress.DataBindings.Clear();
                txtAddress.DataBindings.Add("Text", customers, "Address");

                dgCustomer.CellClick += dgCustomer_CellClick;

            }
        }

        private void dgCustomer_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                bool genderValue = (bool)dgCustomer.Rows[e.RowIndex].Cells["Gender"].Value;
                rdMale.Checked = genderValue;
                rdFemale.Checked = !genderValue;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tao 1 doi tuong product de add du lieu
                Customer c = new Customer()
                {
                    CustomerName = txtName.Text,
                    Birthdate = DateTime.Parse(txtDob.Text),
                    Address = txtAddress.Text,
                    Gender = rdMale.Checked ? true : false,
                };


                // add vao database su dung entity framework
                context.Customers.Add(c);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success.");
                }
                else
                {
                    MessageBox.Show("Add failed.");
                }
                LoadData();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Invalid Id");
            }

            using (MySaleDBContext context = new MySaleDBContext())
            {
                Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);
                if (c == null)
                {
                    MessageBox.Show("Customer with such id does not exist");
                    return;
                }
                context.Customers.Remove(c);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete successfully.");
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
                LoadData();
            }
        }
    }
}
