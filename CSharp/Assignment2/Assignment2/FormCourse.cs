using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using ADOApp.Models;
using ADOApp.DAL;
using Assignment2.DAL;
using Assignment2.Models;


namespace Assignment2
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();

            /*// Thêm cột "IsAbsent" kiểu DataGridViewCheckBoxColumn
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "IsAbsent";
            checkBoxColumn.HeaderText = "Is Absent";
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;*/

            /*attendanceDataGridView.Columns.Add(checkBoxColumn);*/
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            // Lấy danh sách tất cả các Course từ cơ sở dữ liệu
            List<Course> courses = CourseDAO.GetAllCourseCode();
            List<DateTime> dates = CourseDAO.GetCourseDates();
            // Đưa danh sách Course vào ComboBox
            courseComboBox.DataSource = courses;
            courseComboBox.DisplayMember = "CourseCode";

            // Đưa danh sách Date vào ComboBox
            dateComboBox.DataSource = dates;
            dateComboBox.DisplayMember = "TeachingDate";

            attendanceDataGridView.DataSource = CourseDAO.GetCourseForDataGrid();

            //Hide column
            attendanceDataGridView.Columns[7].Visible = false;
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dateChose = dateComboBox.SelectedValue.ToString();
            Course selectedCourse = (Course)courseComboBox.SelectedItem;
            String codeInput = selectedCourse.CourseCode;
            attendanceDataGridView.DataSource = CourseDAO.GetCourseByCourseDate(codeInput, dateChose);
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course selectedCourse = (Course)courseComboBox.SelectedItem;
            String codeInput = selectedCourse.CourseCode;
            String dateChose;
            if (dateComboBox.SelectedValue != null)
            {
                dateChose = dateComboBox.SelectedValue.ToString();
            }
            else
            {
                dateChose = "2011-07-23";
            }
            attendanceDataGridView.DataSource = CourseDAO.GetCourseByCourseDate(codeInput, dateChose);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in attendanceDataGridView.Rows)
            {
                bool isAbsent = Convert.ToBoolean(row.Cells["IsAbsent"].Value);
                int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                int teachingScheduleId = Convert.ToInt32(row.Cells["TeachingScheduleId"].Value);

                // Update the IsAbsent value in the data source or perform any desired operations
                // For example, you can call a method in your DAO class to update the value in the database
                CourseDAO.UpdateIsAbsentValue(studentId, teachingScheduleId, isAbsent);
            }

            MessageBox.Show("Attendance updated successfully!");
        }
    }
}
