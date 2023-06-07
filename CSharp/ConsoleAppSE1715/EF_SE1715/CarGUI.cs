using EF_SE1715.Models;

namespace EF_SE1715
{
    public partial class CarGUI : Form
    {
        private CarsContext _context;

        public CarGUI()
        {
            InitializeComponent();
            _context = new CarsContext();
            bindGridView();
        }

        public void bindGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _context.Cars.ToList();
            dataGridView1.Columns["Orders"].Visible = false;
        }


        private void CarGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}