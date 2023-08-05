using WinForms_EF.Models;

namespace WinForms_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {

                //List<Product> products = new List<Product>();

                // get du lieu tu DB, su dung EF
                var products = context.Products.Select(p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    Image = p.Image,
                    CategoryName = p.Category.CategoryName
                })
                    .OrderBy(p => p.UnitPrice)
                    .ThenByDescending(p => p.UnitsInStock)
                    .ToList();

                dgProduct.DataSource = products;

                // load data cho vao combo box
                List<Category> categories = context.Categories.ToList();
                cboCategory.DataSource = categories;
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";

                // load du lieu len cac textbox khac
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", products, "ProductId");

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", products, "ProductName");

                txtPrice.DataBindings.Clear();
                txtPrice.DataBindings.Add("Text", products, "UnitPrice");

                txtStock.DataBindings.Clear();
                txtStock.DataBindings.Add("Text", products, "UnitsInStock");

                txtImage.DataBindings.Clear();
                txtImage.DataBindings.Add("Text", products, "Image");

                cboCategory.DataBindings.Clear();
                cboCategory.DataBindings.Add("Text", products, "CategoryName");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tao 1 doi tuong product de add du lieu
                Product p = new Product()
                {
                    ProductName = txtName.Text,
                    UnitPrice = Decimal.Parse(txtPrice.Text),
                    UnitsInStock = Int32.Parse(txtStock.Text),
                    Image = txtImage.Text,
                    CategoryId = (int)cboCategory.SelectedValue
                };


                // add vao database su dung entity framework
                context.Products.Add(p);
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

        private void validateInput()
        {
            if (txtName.Text.Length == 0)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tim 1 doi tuong de update du lieu
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Product khong ton tai");
                    return;
                }

                // update nhung thuoc tinh can thiet
                p.ProductName = txtName.Text;
                p.UnitPrice = Decimal.Parse(txtPrice.Text);
                p.UnitsInStock = Int32.Parse(txtStock.Text);
                p.Image = txtImage.Text;
                p.CategoryId = (int)cboCategory.SelectedValue;

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
                LoadData();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tim 1 doi tuong de update du lieu
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Product khong ton tai");
                    return;
                }

                context.Products.Remove(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success.");
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
                LoadData();
            }
        }

        private void btnExtit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //var data = context.Products.Where(p => p.ProductName.Contains(txtName.Text)).ToList(); // cach 1: LINQ

                var data = (from p in context.Products
                            where p.ProductName.Contains(txtName.Text)
                            orderby p.UnitPrice, p.UnitsInStock descending
                            select new
                            {
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                UnitPrice = p.UnitPrice,
                                UnitsInStock = p.UnitsInStock,
                                Image = p.Image,
                                CategoryName = p.Category.CategoryName
                            }).ToList();
                dgProduct.DataSource = data;
            }
        }
    }
}