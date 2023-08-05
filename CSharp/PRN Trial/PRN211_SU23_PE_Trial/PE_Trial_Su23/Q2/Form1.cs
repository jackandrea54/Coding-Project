using Q2.Models;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* DisplayData();*/
            DisplayData1();
        }

        /*private void DisplayData()
        {
            using (var dbContext = new PeFall21B5Context())
            {
                // Retrieve the employees from the database
                List<Employee> employees = dbContext.Employees.ToList();
                
                // Clear existing columns in the DataGridView
                dataGridView.Columns.Clear();

                *//*// Define and add columns manually
                dataGridView.Columns.Add("IdColumn", "ID");
                dataGridView.Columns.Add("NameColumn", "Name");
                dataGridView.Columns.Add("SexColumn", "Sex");
                dataGridView.Columns.Add("DOBColumn", "DOB");
                dataGridView.Columns.Add("PositionColumn", "Position");

                // Bind the DataGridView control to the employees collection
                dataGridView.Rows.Clear();
                foreach (var employee in employees)
                {
                    int rowIndex = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[rowIndex];
                    row.Cells["IdColumn"].Value = employee.Id;
                    row.Cells["NameColumn"].Value = employee.Name;
                    row.Cells["SexColumn"].Value = employee.Sex;

                    // Format the DOB to "dd-mm-yyyy" before assigning it to the cell
                    string formattedDOB = employee.Dob.ToString("dd-MM-yyyy");
                    row.Cells["DOBColumn"].Value = formattedDOB;

                    row.Cells["PositionColumn"].Value = employee.Position;
                }*//*

                dataGridView.DataSource = employees;

                List<string> positions = employees.Select(employee => employee.Position).Distinct().ToList();
                positionComboBox.DataSource = positions;
                positionComboBox.DisplayMember = "Position";
            }
        }*/
        private void DisplayData1()
        {
            using (var dbContext = new PeFall21B5Context())
            {
                // Retrieve the employees from the database
                var employees = dbContext.Employees.ToList();

                // Clear existing columns in the DataGridView
                dataGridView.Columns.Clear();

                // Bind the DataGridView control to the employees collection
                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = employees;

                // Format the DOB column to display in dd-MM-yyyy format
                dataGridView.Columns["DOB"].DefaultCellStyle.Format = "dd-MM-yyyy";

                // Set the DateTimePicker format to "dd-MM-yyyy"
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd    MMMMMMMMMMM    yyyy";

                // Hiden columns unnecessary
                dataGridView.Columns["Department"].Visible = false;
                dataGridView.Columns["DepartmentNavigation"].Visible = false;

                List<string> positions = employees.Select(employee => employee.Position).Distinct().ToList();
                positionComboBox.DataSource = positions;
                positionComboBox.DisplayMember = "Position";
            }
        }


        //Add new employee to database
        private void addBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PeFall21B5Context())
            {
                // Add new employee to database
                if (textBox2 != null && (femaleBtn.Checked || maleBtn.Checked)
                     && positionComboBox.SelectedItem != null)
                {
                    string name = textBox2.Text;
                    string sex = "";
                    if (femaleBtn.Checked)
                    {
                        sex = "Female";
                    }
                    else if (maleBtn.Checked)
                    {
                        sex = "Male";
                    }
                    DateTime dob = dateTimePicker1.Value;

                    String position = positionComboBox.Text;

                    Employee employeeToInsert = new Employee(name, sex, dob, position);

                    if (MessageBox.Show("Do you really want to insert employee " + textBox2.Text,
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Employees.Add(employeeToInsert);
                        context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Add failed");
                }

            }
            Form1_Load(null, null);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row index is selected
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                // Assuming your ID column is at index 0, change it accordingly if needed
                textBox1.Text = selectedRow.Cells["Id"].Value.ToString();
                textBox1.ReadOnly = true;
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                string gender = selectedRow.Cells[2].Value.ToString();
                if (gender.Equals("Female"))
                {
                    femaleBtn.Checked = true;
                    maleBtn.Checked = false;
                }
                else
                {
                    maleBtn.Checked = true;
                    femaleBtn.Checked = false;
                }
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);

                //
                String position = selectedRow.Cells[4].Value.ToString();

                positionComboBox.Text = position;


            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
            textBox2.Clear();
            maleBtn.Checked = false;
            femaleBtn.Checked = false;

            dateTimePicker1.Value = DateTime.Now;
            positionComboBox.Text = "Developer";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (var context = new PeFall21B5Context())
            {
                // Add new employee to database
                if (textBox1 != null && textBox2 != null && (femaleBtn.Checked || maleBtn.Checked)
                     && positionComboBox.SelectedItem != null)
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    string name = textBox2.Text;
                    string sex = "";
                    if (femaleBtn.Checked)
                    {
                        sex = "Female";
                    }
                    else if (maleBtn.Checked)
                    {
                        sex = "Male";
                    }
                    DateTime dob = dateTimePicker1.Value;

                    String position = positionComboBox.Text;

                    Employee employeeToUpdate = new Employee(id, name, sex, dob, position);

                    if (MessageBox.Show("Do you really want to update employee " + textBox2.Text,
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Employees.Update(employeeToUpdate);
                        context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Update failed");
                }

            }
            Form1_Load(null, null);
        }
    }
}