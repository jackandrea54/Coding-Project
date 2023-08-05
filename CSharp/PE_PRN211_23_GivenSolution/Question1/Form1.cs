using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        string path;

        public Form1()
        {
            InitializeComponent();

           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (employees.Count > 0)
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        path = filePath;
                        SaveToFile(filePath);
                    }
                }
                else
                {
                    MessageBox.Show("There are no Employees in the list");
                }
                
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(employeeIdBox.Text);
            String name = employeeNameBox.Text;

            // Set the DateTimePicker format to "dd-MM-yyyy"
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            /*   DateTime dob = DateTime.ParseExact(dateTimePicker1.Value.Day+"/"+ dateTimePicker1.Value.Month+ "/"+
                   dateTimePicker1.Value.Year, "dd/MM/yyyy", null);*/

            DateTime dob = dateTimePicker1.Value;

            bool isMale = true;
            if (maleBtn.Checked)
            {
                isMale = true;
            }
            if (femaleBtn.Checked)
            {
                isMale = false;
            }
            employees.Add(new Employee(id, name, dob, isMale));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void SaveToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                try
                {
                        foreach (Employee emp in employees)
                        {
                            sw.WriteLine(emp);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " exception while saving files");
                }
            }
        }
    }
}