using DemoADOModel.DataAccess;
using DemoADOModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADOModel
{
    public partial class frmEdit : Form
    {
        Product curProduct;
        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit(Product product)
        {
            InitializeComponent();
            curProduct = product;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (curProduct !=null)
            {
                textBox1.Text = curProduct.ProductID.ToString();
                textBox1.Enabled = false;
                textBox2.Text = curProduct.ProductName;
                numericUpDown1.Value = (decimal)curProduct.UnitPrice;
                CategoryDAO categoryDAO = new CategoryDAO();
                listBox1.DisplayMember = "CategoryName";
                listBox1.ValueMember = "CategoryID";
                listBox1.DataSource = categoryDAO.GetCategories();
                listBox1.SelectedValue = curProduct.CategoryID;
            }
        }

        Product GetProduct()
        {
            Product p = new Product();
            p.ProductID = curProduct.ProductID;
            p.ProductName = textBox2.Text;
            p.CategoryID = Convert.ToInt32(listBox1.SelectedValue);
            p.UnitPrice = (float)numericUpDown1.Value;
            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product newProduct = GetProduct();
            ProductDAO productDAO = new ProductDAO();
            int count = productDAO.UpdateProduct(newProduct);
            if (count > 0)
                MessageBox.Show("Cap nhat du lieu thanh cong");
        }
    }
}
