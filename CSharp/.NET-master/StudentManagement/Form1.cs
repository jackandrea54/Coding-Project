using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB1;

namespace StudentManagementWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel2.Visible = false;

        }
        public StudentController StudentController = new StudentController();

        public String FilePath = "";
        public String FileName = "";
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                InitialDirectory = @"D:\Semester 5\PRN211\Day1-10-5-2022\LAB1\students.txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = openFileDialog.FileName;

                    // Find setting file
                    FileName = Path.GetFileName(FilePath);
                    StudentController.ReadStudentFromFile(FilePath);
                    DataGridView.DataSource = StudentController.getAllStudent();
                    OpenFilePath.Text = FilePath;
                    List<String> YearOfBirth = new List<string>();
                    YearOfBirth.Add("All");
                    YearOfBirth.AddRange(StudentController.getAllStudent().Select(x => x.DateOfBirth.Year.ToString()).Distinct().ToList());
                    YearOfBirthBox.DataSource = YearOfBirth;

                    List<String> EntryYear = new List<string>();
                    EntryYear.Add("All");
                    EntryYear.AddRange(StudentController.getAllStudent().Select(x => x.YearAdmitted.ToString()).Distinct().ToList());
                    EntryYearBox.DataSource = EntryYear;

                    List<String> Major = new List<string>();
                    Major.Add("All");
                    Major.AddRange(StudentController.getAllStudent().Select(x => x.Major).Distinct().ToList());
                    MajorBox.DataSource = Major;

                    this.Text = FileName;
                    tableLayoutPanel2.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Student> studentSearch = StudentController.getAllStudent();

            String id = IdBox.Text;
            String name = NameBox.Text;
            String YearOfBirth = YearOfBirthBox.Text;
            String EntryYear = EntryYearBox.Text;
            String Major = MajorBox.Text;
            if (id != "")
            {
                studentSearch = studentSearch.Where(x => x.Id == int.Parse(id)).ToList();
            }
            if (name != "")
            {
                studentSearch = StudentController.FindStudentsByName(name);
            }
            if (YearOfBirth != "All")
            {
                studentSearch = studentSearch.Where(s => s.DateOfBirth.Year == Convert.ToInt32(YearOfBirth)).ToList();
            }
            if (EntryYear != "All")
            {
                studentSearch = studentSearch.Where(s => s.YearAdmitted == Convert.ToInt32(EntryYear)).ToList();
            }
            if (Major != "All")
            {
                studentSearch = studentSearch.Where(s => s.Major.ToLower().Contains(Major.ToLower())).ToList();
            }
            ShowFounded.Text = "Found " + studentSearch.Count + " students";
            DataGridView.DataSource = studentSearch;
        }


        private void ResetForm_Click(object sender, EventArgs e)
        {
            // Reset form
            IdBox.Text = "";
            NameBox.Text = "";
            YearOfBirthBox.Text = "All";
            EntryYearBox.Text = "All";
            MajorBox.Text = "All";
            ShowFounded.Text = "";
            DataGridView.DataSource = StudentController.getAllStudent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
