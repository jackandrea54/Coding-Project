using ADOApp.DAL;
using Assignment2;

namespace ADOApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentDao.GetAllStudent();
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            if (searchText != null && searchText.Length != 0)
            {
                dataGridView1.DataSource = StudentDao.GetStudentByName(searchText);
            }
            else
            {
                dataGridView1.DataSource = StudentDao.GetAllStudent();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Perform actions based on the clicked button
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    // Handle edit button click
                    // Retrieve data from the selected row using e.RowIndex
                    // Perform the edit operation
                    // Retrieve data from the selected row
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int studentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);
                    string rollNumber = selectedRow.Cells["RollNumber"].Value.ToString();
                    string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                    string midName = selectedRow.Cells["MidName"].Value.ToString();
                    string lastName = selectedRow.Cells["LastName"].Value.ToString();

                    // Create an instance of the editing form
                    FormEdit editForm = new FormEdit();
                    editForm.SetStudentData(studentId,rollNumber,firstName,midName,lastName);

                    // Show the editing form
                    editForm.ShowDialog();

                    // Refresh the DataGridView after editing
                    dataGridView1.DataSource = StudentDao.GetAllStudent();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Confirm the deletion with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Retrieve the student ID from the selected row
                        int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentId"].Value);

                        // Perform the delete operation using the student ID
                        // Delete the student from the database
                        int count = StudentDao.DeleteStudent(studentId);
                        if (count > 0)
                            MessageBox.Show("Xoa du lieu thanh cong");
                        else
                            MessageBox.Show("Xoa du lieu khong thanh cong");
                        // Refresh the DataGridView after deleting
                        dataGridView1.DataSource = StudentDao.GetAllStudent();
                    }
                }
            }
        }
    }
}