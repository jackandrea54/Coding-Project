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
    public partial class FrmGenerateAuto : Form
    {
        public FrmGenerateAuto()
        {
            InitializeComponent();
        }

        public FrmGenerateAuto(string text)
        {
            InitializeComponent();
            Text = text;
        }
        List<Control> listLabel = new List<Control>();
        List<Control> listRadioButton = new List<Control>();

        private void btnAddText_Click(object sender, EventArgs e)
        {
            List<Control> listTextBox = new List<Control>();
            int n = (int)numText.Value;
            for (int i = 0; i < n; i++)
            {
                Label label = new Label();
                label.Text = "Enter text: " + i.ToString();
                label.Location = new System.Drawing.Point(24, 148 + (i * 50));
                label.Size = new System.Drawing.Size(78, 32);
                listLabel.Add(label);

                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(200, 145 + (i * 50));
                txt.Size = new System.Drawing.Size(324, 39);
                listTextBox.Add(txt);
            }
            this.Controls.AddRange(listTextBox.ToArray());
            this.Controls.AddRange(listLabel.ToArray());

            Button submitBtn = new Button();
            submitBtn.Text = "OK";
            submitBtn.Location = new System.Drawing.Point(200, 145 + (n * 50));
            submitBtn.Size = new System.Drawing.Size(78, 32);
            submitBtn.Click += (sender, e) => SubmitBtn_Click(sender, e, n, listTextBox);
            this.Controls.Add(submitBtn);

        }

        private void SubmitBtn_Click(object? sender, EventArgs e, int n, List<Control> textboxes)
        {
            for (int i = 0; i < n; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Location = new System.Drawing.Point(160, 148 + (i * 50));
                radioButton.Size = new System.Drawing.Size(78, 32);
                listRadioButton.Add(radioButton);

                Label label = new Label();
                label.Text = textboxes[i].Text;
                label.Location = new System.Drawing.Point(200, 145 + (i * 50));
                label.Size = new System.Drawing.Size(324, 39);
                this.Controls.Add(label);
                this.Controls.Add(radioButton);
                this.Controls.Remove(textboxes[i]);
                this.Controls.Remove(listLabel[i]);
            }
            this.Controls.AddRange(listRadioButton.ToArray());
        }

        private void FrmGenerateAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
