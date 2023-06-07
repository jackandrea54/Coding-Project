using DemoADOModel.DataAccess;
using DemoADOModel.Model;

namespace DemoADOModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("ProductName", "Product's Name");
            dataGridView1.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridView1.Columns.Add("UnitPrice", "Price");
            dataGridView1.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
            dataGridView1.Columns.Add("CategoryName", "Category");
            dataGridView1.Columns["CategoryName"].DataPropertyName = "CategoryName";

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "EditCol";
            editCol.HeaderText = "Action";
            editCol.Text = "Edit Product";
            editCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editCol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DataSource = categoryDAO.GetCategories();
        }

        private void LoadDataForDGV()
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.GetProducts(Convert.ToInt32(cbCategory.SelectedValue));
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //kiem tra co phai bam vao cot button Edit ko?
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("EditCol"))
            {
                //lay thong tin Product cua Product vua dc bam vao.
                //string ProductName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();

                //Cach khac, lay Product 
                List<Product> products = (List<Product>) dataGridView1.DataSource;
                Product p = products[e.RowIndex];
                frmEdit newForm = new frmEdit(p);
                newForm.FormClosed += NewForm_FormClosed;
                newForm.Show();
            }
        }

        private void NewForm_FormClosed(object? sender, FormClosedEventArgs e)
        {

            LoadDataForDGV();
        }
    }
}