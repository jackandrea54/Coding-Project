using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Khai bao 1 list chua danh sach sinh vien
        List<Student> data = new List<Student>();

        Dictionary<string, string> map = new Dictionary<string, string>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Su viec gi do se xay ra khi nhan nut exit
            if (MessageBox.Show("yah sure bro?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.Pink;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Pink;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSubject.Items.Add("Japanese");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (map.ContainsKey(txtCode.Text))
            {
                MessageBox.Show(txtCode.Text + " has already existed.");
                return;
            }
            else
            {
                Student s = new Student()
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Subject = cboSubject.SelectedItem.ToString(),
                    Mark = (int)numMark.Value
                };
                data.Add(s);
                lstStudent.Items.Add(s);
                map.Add(txtCode.Text, txtName.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load from file
            data.Clear();
            try
            {
                string filename = "..\\..\\..\\data.txt";
                //string filename = "data.txt";

                //C2
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        string[] s = line.Split('\t');
                        string code = s[0].Trim();
                        string name = s[1].Trim();
                        string subject = s[2].Trim();
                        int mark = Convert.ToInt32(s[3].Trim());
                        Student stu = new Student(code, name, subject, mark);
                        data.Add(stu);
                        map.Add(stu.Code, stu.Name);
                        lstStudent.Items.Add(stu);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load fail: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // save to file
            try
            {
                string filename = "..\\..\\..\\data.txt";

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var student in lstStudent.Items)
                    {
                        writer.WriteLine(student);
                    }
                }
                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save fail: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a student to delete.");
                return;
            }
            if (lstStudent.SelectedItem != null)
            {
                Student s = (Student)lstStudent.SelectedItem;
                map.Remove(s.Code);
                data.Remove(s);
                lstStudent.Items.Remove(s);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            foreach (Student s in data)
            {
                if (s.Code.Equals(txtCode.Text))
                {
                    txtName.Text = s.Name;
                    cboSubject.Text = s.Subject;
                    numMark.Value = s.Mark;
                }
            }
        }
    }
}