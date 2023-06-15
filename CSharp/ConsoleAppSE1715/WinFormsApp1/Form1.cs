using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int num;
        Button btPreviousButton;
        Button btNewButton; //1 - khai bao bien control
        public Form1()
        {
            InitializeComponent();
            /*CreateNewButton();*/
            textBox1.Text = "The total added button is: " + num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void CreateNewButton()
        {
            btNewButton = new Button();//2 - goi ham de khoi tao doi tuong
            btNewButton.Text = "New button"; //3 - thay doi thuoc tinh cua doi tuong control
            btNewButton.Size = new Size(btClickme.Width, btClickme.Height);
            btNewButton.Location = new Point(btClickme.Location.X, btClickme.Location.Y + btClickme.Height + 30);
            btNewButton.Click += btNewButton_Click;

            this.Controls.Add(btNewButton);//4 - add control vao container
        }

        //Event Handler
        private void btClickme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your mom fat");
        }

        private void btNewButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("Hey new here! I'm " + button.Text);
        }

        private void AddNewBtn(object sender, EventArgs e)
        {
            int formHeight = this.Size.Height;
            int formWidth = this.Size.Width;
            btNewButton = new Button();//2 - goi ham de khoi tao doi tuong
            btNewButton.Text = "New button"; //3 - thay doi thuoc tinh cua doi tuong control
            btNewButton.Size = new Size(btClickme.Width, btClickme.Height);
            if (btPreviousButton == null)
            {
                btNewButton.Location = new Point(btClickme.Location.X,
                                                btClickme.Location.Y + btClickme.Height + 30);
            }
            else if (btPreviousButton.Location.Y + btPreviousButton.Height + 30 > formHeight - 30)
            {
                btNewButton.Location = new Point(btPreviousButton.Location.X + btPreviousButton.Width + 10,
                                                btClickme.Location.Y);
            }
            else
            {
                btNewButton.Location = new Point(btPreviousButton.Location.X,
                                                    btPreviousButton.Location.Y + btPreviousButton.Height + 30);
            }

            btNewButton.Click += AddNewBtn;
            btPreviousButton = btNewButton;
            num++;
            textBox1.Text = "The total added button is: " + num;
            this.Controls.Add(btNewButton);//4 - add control vao container
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
