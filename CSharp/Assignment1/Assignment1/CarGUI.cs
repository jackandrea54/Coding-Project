using Assignment1;
using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class CarGUI : Form
    {
        private CarsContext _context;
        public CarGUI()
        {
            InitializeComponent();
            _context = new CarsContext();
            showData();
        }

        private void showData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _context.Cars.ToList();
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["CarId"].Visible = true;

            int totalCarInDB = _context.Cars.Count();
            totalCar.Text = "The number of cars: " + totalCarInDB.ToString();

            // Add "Details" column
            DataGridViewButtonColumn detailsColumn = new DataGridViewButtonColumn();
            detailsColumn.Name = "Details";
            detailsColumn.HeaderText = "Details";
            detailsColumn.Text = "Details";
            detailsColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(detailsColumn);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Details" column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details" && e.RowIndex >= 0)
            {
                // Get the selected car from the data source
                Car selectedCar = dataGridView1.Rows[e.RowIndex].DataBoundItem as Car;

                if (selectedCar != null)
                {
                    CarDetailsGUI detailsForm = new CarDetailsGUI(selectedCar);
                    detailsForm.ShowDialog();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void totalCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginGUI loginForm = new LoginGUI();
            loginForm.ShowDialog();
            showData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            _context = new CarsContext();
            showData();
        }
    }
}
