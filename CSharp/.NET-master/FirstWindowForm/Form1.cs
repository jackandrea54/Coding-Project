using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowForm
{
    public partial class Form1 : Form
    {
        List<ComboItem> list = new List<ComboItem>()
            {
                new ComboItem(1, "Microseconds"),
                new ComboItem(2, "Miliseconds"),
                new ComboItem(3, "Seconds"),
                new ComboItem(4, "Minutes"),
                new ComboItem(5, "Hours"),
                new ComboItem(6, "Days"),
                new ComboItem(7, "Weeks"),
                new ComboItem(8, "Years"),
            };

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = list;
            comboBox2.DataSource = list.Select(p => p).ToList();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public void ButtonClick(object sender, EventArgs e)
        {
            String buttonName = ((Button)sender).Name;
            String buttonValue = ((Button)sender).Text;
            String textBox1 = TextBox1.Text;
            if (textBox1.Equals("0") && !buttonValue.Equals(".") && !buttonValue.Equals("CE") && !buttonName.Equals("ButtonDelete"))
            {
                TextBox1.Text = buttonValue;
            }
            else
            {

                if (buttonValue.Equals("."))
                {
                    if (!textBox1.Contains("."))
                    {
                        TextBox1.Text += buttonValue;
                    }
                }
                else if (buttonValue.Equals("CE"))
                {
                    TextBox1.Text = "0";
                }
                else if (buttonName.Equals("ButtonDelete"))
                {
                    if (textBox1.Length > 1)
                    {
                        TextBox1.Text = textBox1.Substring(0, textBox1.Length - 1);
                    }
                    else
                    {
                        TextBox1.Text = "0";
                    }
                }
                else
                {
                    TextBox1.Text += buttonValue;
                }
            }
        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem co = ((ComboItem)comboBox1.SelectedItem);
            String textBox1 = TextBox1.Text;
            MessageBox.Show(textBox1);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
