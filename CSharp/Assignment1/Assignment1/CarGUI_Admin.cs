using Assignment1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
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
    public partial class CarGUI_Admin : Form
    {


        private CarsContext _context;
        public CarGUI_Admin()
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
            dataGridView1.Columns["CarId"].Visible = false;

            int totalCarInDB = _context.Cars.Count();
            displayTotalCar.Text = "The number of cars: " + totalCarInDB.ToString();

            // Add "Details" column
            DataGridViewButtonColumn detailsColumn = new DataGridViewButtonColumn();
            detailsColumn.Name = "Detail";
            detailsColumn.HeaderText = "Detail";
            detailsColumn.Text = "Detail";
            detailsColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(detailsColumn);

            // Add "Edit" column
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editColumn);

            // Add "Delete" column
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteColumn);
        }

        private void Reload()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            _context = new CarsContext();
            dataGridView1.DataSource = _context.Cars.ToList();
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["CarId"].Visible = false;

            int totalCarInDB = _context.Cars.Count();
            displayTotalCar.Text = "The number of cars: " + totalCarInDB.ToString();

            // Add "Details" column
            DataGridViewButtonColumn detailsColumn = new DataGridViewButtonColumn();
            detailsColumn.Name = "Detail";
            detailsColumn.HeaderText = "Detail";
            detailsColumn.Text = "Detail";
            detailsColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(detailsColumn);

            // Add "Edit" column
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editColumn);

            // Add "Delete" column
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteColumn);
        }

        private void displayTotalCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarGUI_Admin_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Details" column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                // Get the selected car from the data source
                Car selectedCar = dataGridView1.Rows[e.RowIndex].DataBoundItem as Car;

                if (selectedCar != null)
                {
                    CarDetailsGUI detailsForm = new CarDetailsGUI(selectedCar);
                    detailsForm.ShowDialog();
                }
            }

            /*            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                        {
                            DataGridView dataGridView1 = (DataGridView)sender;
                            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                            if (columnName == "Edit")
                            {
                                Car selectedCar = dataGridView1.Rows[e.RowIndex].DataBoundItem as Car;
                                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                                int carId = (int)selectedRow.Cells["CarId"].Value;

                                CarAddEditGUI editForm = new CarAddEditGUI();
                                editForm.ShowDialog();
                            }
                        }*/

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex > 0)
            {

                int carId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CarId"].Value);
                Car selectedCar = dataGridView1.Rows[e.RowIndex].DataBoundItem as Car;

                // Open a new instance of the CarAddEditGUI form in edit mode
                CarAddEditGUI editForm = new CarAddEditGUI(carId);
                editForm.CarAdded += AddForm_CarAdded;
                editForm.ShowDialog();

                Thread.Sleep(1);
                CarGUI_Admin_Load(null, null);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int carId = (int)selectedRow.Cells["CarId"].Value;

                DialogResult result = MessageBox.Show("Do you want delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var context = new CarsContext())
                    {
                        Car carToDelete = context.Cars.FirstOrDefault(c => c.CarId == carId);
                        if (carToDelete != null)
                        {
                            context.Cars.Remove(carToDelete);
                            context.SaveChanges();

                            MessageBox.Show("Car deleted successfully.");
                            showData();
                        }
                    }
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            /*CarAddEditGUI addForm = new CarAddEditGUI();
            addForm.CarId = -1;
            addForm.CarAdded += AddForm_CarAdded; // Subscribe to the CarAdded event
            addForm.ShowDialog();*/
            /*CarAddEditGUI addForm = new CarAddEditGUI();
            addForm.ShowDialog();*/

            // Clear the form fields
            // Open a new instance of the CarAddEditGUI form in add new mode
            CarAddEditGUI addForm = new CarAddEditGUI(-1);
            addForm.CarAdded += AddForm_CarAdded;
            addForm.ShowDialog();
        }

        private void AddForm_CarAdded(object sender, EventArgs e)
        {
            // Refresh the grid view
            showData();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginGUI loginForm = new LoginGUI();
            loginForm.ShowDialog();

            // Close the AdminGUI form
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
