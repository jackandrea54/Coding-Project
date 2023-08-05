using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }


        int count = 10;
        private object text;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {

                count--;
                lblCount.Text = count.ToString();
            }
            else
            {
                timer1.Stop();
                FrmGenerateAuto f = new FrmGenerateAuto(textName.Text);
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
