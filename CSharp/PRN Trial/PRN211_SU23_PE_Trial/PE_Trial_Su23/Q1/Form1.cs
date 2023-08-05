using Azure.Core.GeoJson;
using Q1.DAL;
using Q1.Models;
using System.Xml.Linq;

namespace Q1
{
    public partial class Form1 : Form
    {
        private List<Employees> employees;

        public Form1()
        {
            InitializeComponent();
            employees = EmployeesDAO.GetDataEmployee();
            displayPosition();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeesDAO.GetDataEmployee();
        }

        private void displayPosition()
        {
            List<Employees> listPosition = EmployeesDAO.GetPosition();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All Positions");
            foreach (Employees employees in listPosition)
            {
                comboBox1.Items.Add(employees.Position);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void DisplayFilteredEmployees(List<Employees> filteredEmployees)
        {
            // Unbind the DataGridView from its data source
            dataGridView1.DataSource = null;

            // Set the data source of the DataGridView to the filtered employee list
            dataGridView1.DataSource = filteredEmployees;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.Trim().ToLower();
            string selectedGender = radioButton1.Checked ? "All" : radioButton2.Checked ? "Male" : "Female";
            string selectedPosition = comboBox1.SelectedItem.ToString();

            List<Employees> filteredEmployees = employees;

            if (!string.IsNullOrEmpty(searchName))
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Name.ToLower().Contains(searchName)).ToList();
            }

            if (selectedGender != "All")
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Sex == selectedGender).ToList();
            }

            if (selectedPosition != "All Positions")
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Position == selectedPosition).ToList();
            }

            DisplayFilteredEmployees(filteredEmployees);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // "All" radio button selected
            if (radioButton1.Checked)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string searchName = textBox1.Text.Trim();
                    string selectedPosition = comboBox1.SelectedItem.ToString();

                    List<Employees> filteredEmployees = employees;

                    if (selectedPosition != "All Positions")
                    {
                        filteredEmployees = filteredEmployees.Where(emp => emp.Position == selectedPosition).ToList();
                    }

                    filteredEmployees = filteredEmployees.Where(emp => emp.Name.Contains(searchName)).ToList();

                    DisplayFilteredEmployees(filteredEmployees);
                }
                else
                {
                    // Show all employees
                    DisplayFilteredEmployees(employees);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // "Male" radio button selected
            if (radioButton2.Checked)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string searchName = textBox1.Text.Trim();
                    string selectedPosition = comboBox1.SelectedItem.ToString();

                    List<Employees> filteredEmployees = employees;

                    if (selectedPosition != "All Positions")
                    {
                        filteredEmployees = filteredEmployees.Where(emp => emp.Position == selectedPosition).ToList();
                    }

                    filteredEmployees = filteredEmployees.Where(emp => emp.Name.Contains(searchName) && emp.Sex == "Male").ToList();

                    DisplayFilteredEmployees(filteredEmployees);
                }
                else
                {
                    // Show only male employees
                    List<Employees> filteredEmployees = employees.Where(emp => emp.Sex == "Male").ToList();
                    DisplayFilteredEmployees(filteredEmployees);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // "Female" radio button selected
            if (radioButton3.Checked)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string searchName = textBox1.Text.Trim();
                    string selectedPosition = comboBox1.SelectedItem.ToString();

                    List<Employees> filteredEmployees = employees;

                    if (selectedPosition != "All Positions")
                    {
                        filteredEmployees = filteredEmployees.Where(emp => emp.Position == selectedPosition).ToList();
                    }

                    filteredEmployees = filteredEmployees.Where(emp => emp.Name.Contains(searchName) && emp.Sex == "Female").ToList();

                    DisplayFilteredEmployees(filteredEmployees);
                }
                else
                {
                    // Show only female employees
                    List<Employees> filteredEmployees = employees.Where(emp => emp.Sex == "Female").ToList();
                    DisplayFilteredEmployees(filteredEmployees);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.Trim().ToLower();
            string selectedGender = radioButton1.Checked ? "All" : radioButton2.Checked ? "Male" : "Female";
            string selectedPosition = comboBox1.SelectedItem.ToString();

            List<Employees> filteredEmployees = employees;

            if (!string.IsNullOrEmpty(searchName))
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Name.ToLower().Contains(searchName)).ToList();
            }

            if (selectedGender != "All")
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Sex == selectedGender).ToList();
            }

            if (selectedPosition != "All Positions")
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Position == selectedPosition).ToList();
            }

            DisplayFilteredEmployees(filteredEmployees);
        }
    }
}