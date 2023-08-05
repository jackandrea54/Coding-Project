using System.Globalization;

namespace Winform_ADO
{
    public partial class FilePractice : Form
    {
        List<Employee> employees = new List<Employee>();
        int eid;
        int rowIndex;
        string path;
        public FilePractice()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    path = filePath;
                    txtFileName.Text = filePath;
                    loadDataFromFile(filePath);
                    dgvEmployee.DataSource = employees;
                }
            }
        }

        public void loadDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    employees.Clear();
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] infos = line.Split("\t");
                        int id = int.Parse(infos[0]);
                        string name = infos[1];
                        MessageBox.Show(infos[2]);
                        DateTime dob = DateTime.ParseExact(infos[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        int yob = int.Parse(infos[3]);
                        int salary = int.Parse(infos[4]);
                        Employee employee = new Employee(id, name, dob, yob, salary);
                        employees.Add(employee);
                        line = reader.ReadLine();
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show($"error loading file: {ex.Message}");
                }

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count == 0)
            {
                MessageBox.Show("== 0 ");
                return;
            }
            else
            {
                MessageBox.Show(" selected cells: " + dgvEmployee.SelectedCells.Count);
                // find id corresponding to the selected cell
                int row = dgvEmployee.SelectedCells[0].RowIndex;
                MessageBox.Show("Row: " + row);

            }
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                if (employee.Id == eid)
                {
                    employees.Remove(employee);
                    break;
                }
            }

            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = employees;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            string id = dgvEmployee.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            eid = Convert.ToInt32(id);
            MessageBox.Show("eid: " + eid);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {

                    foreach (Employee emp in employees)
                    {
                        sw.WriteLine(emp);
                    }
                    MessageBox.Show("Save succeed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " exception while saving files");
                }
            }
        }
    }
}
