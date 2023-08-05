using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FilePractice : Form
    {
        List<Course> courses = new List<Course>();
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
                    loadDataFromFile(txtFileName.Text);
                    dataGridView1.DataSource = courses;

                }
                
            }
        }

        /*public void loadDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    courses.Clear();
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] infos = line.Split("|");
                        string courseName = infos[0];
                        int id = int.Parse(infos[1]);
                        string courseCode = infos[2];
                        string date = infos[3];
                        Course course = new Course(id, courseCode, Convert.ToDateTime(date));
                        courses.Add(course);
                        line = reader.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("Reader file fail!!!");
                }
            }
        }*/

        public void loadDataFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    courses.Clear();
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        //dua du lieu tren line vao course, thao tac tren 1 course nen sang thuc hien o class course va onlinecourse
                        string[] items = line.Split("|");
                        int Id = Convert.ToInt32(items[1]);
                        String Title = items[2];
                        DateTime StartDate = Convert.ToDateTime(items[3]);
                        Course c = new Course(Id, Title, StartDate);
                        courses.Add(c);
                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error loading file: {ex.Message}");
                }

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
