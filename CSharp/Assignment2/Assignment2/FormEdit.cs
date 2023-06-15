using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOApp.Models;
using ADOApp.DAL;

namespace Assignment2
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        public void SetStudentData(int studentId, string rollNumber, string firstName, string midName, string lastName)
        {
            textBoxStudentID.Text = studentId.ToString();
            textBoxRoll.Text = rollNumber;
            textBoxFName.Text = firstName;
            textBoxMName.Text = midName;
            textBoxLName.Text = lastName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the edited values from the TextBox controls
            Student stu = GetStudent();

            // Perform the necessary database update operations using the retrieved values
            // Save the changes to the database
            int count = StudentDao.UpdateStudent(stu);
            if (count > 0)
                MessageBox.Show("Cap nhat du lieu thanh cong");
            // Close the edit form
            this.Close();
        }


        Student GetStudent()
        {
            int studentId = Convert.ToInt32(textBoxStudentID.Text);
            string rollNumber = textBoxRoll.Text;
            string firstName = textBoxFName.Text;
            string midName = textBoxMName.Text;
            string lastName = textBoxLName.Text;
            return new Student(studentId, rollNumber, firstName, midName, lastName);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the edit form
            this.Close();
        }
    }
}
