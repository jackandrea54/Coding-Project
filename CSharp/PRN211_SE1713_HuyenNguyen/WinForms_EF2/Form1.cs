using WinForms_EF2.Models;

namespace WinForms_EF2
{
    public partial class Form1 : Form
    {
        public Form1()
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


                //binding gender
                rdMale.DataBindings.Clear();
                rdMale.DataBindings.Add("Checked", customers, "Gender");

                txtAddress.DataBindings.Clear();
                txtAddress.DataBindings.Add("Text", customers, "Address");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}