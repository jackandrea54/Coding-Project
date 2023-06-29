using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fmtLoad();
        }
        public String FileName = "Untitled - Notepad";
        public String FilePath = "";
        public float FontSize = 12;
        public String FontName = "Consolas";
        public String FontStyle = "Regular";
        public String FontColor = "Black";
        public int LineCount = 1;
        public int ColumnCount = 1;

        private void fmtLoad()
        {
            // Load settings
            ContentBox.Font = new Font(FontName, FontSize, (FontStyle)Enum.Parse(typeof(FontStyle), FontStyle));
            ContentBox.ForeColor = Color.FromName(FontColor);
            this.Text = FileName;
            StatusBar.Text = $"Line {LineCount} | Column {ColumnCount}";
            OpenMenu.Click += OpenMenu_Click;
            NewWindows.Click += (sender, e) =>
            {
                Form1 newForm = new Form1();
                newForm.Show();
            };
            SaveAs.Click += SaveAs_Click;
            Save.Click += Save_Click;
            Paste.Click += (sender, e) => { ContentBox.Paste(); FindBoxText.Paste(); };
            Copy.Click += (sender, e) => { ContentBox.Copy(); FindBoxText.Copy(); };
            Cut.Click += (sender, e) => { ContentBox.Cut(); FindBoxText.Cut(); };
            Undo.Click += (sender, e) => { ContentBox.Undo(); };
            Redo.Click += (sender, e) => { ContentBox.Redo(); };
            SelectAll.Click += (sender, e) => { ContentBox.SelectAll(); FindBoxText.SelectAll(); };
            FindBox.Visible = false;
            AttributeBox.Visible = false;


        }
        private void ContentBox_TextChanged(object sender, EventArgs e)
        {
            // Update the status bar
            LineCount = ContentBox.GetLineFromCharIndex(ContentBox.Text.Length) + 1;
            ColumnCount = ContentBox.SelectionStart - ContentBox.GetFirstCharIndexOfCurrentLine() + 1;
            StatusBar.Text = $"Line {LineCount} | Column {ColumnCount}";
            // Update the title
            if (FilePath == "")
            {
                if (ContentBox.Text != "")
                {
                    this.Text = "*" + FileName;
                }
                else
                {
                    this.Text = FileName;
                }
            }
            else
            {
                if (ContentBox.Modified)
                {
                    this.Text = FileName + "*";
                }
                else
                {
                    this.Text = FileName;
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (FilePath == "")
            {
                SaveAs_Click(sender, e);
            }
            else
            {
                File.WriteAllText(FilePath, ContentBox.Text);
                if (this.Text.Contains("*"))
                {
                    this.Text = FileName;
                }
                // save settings to file
                File.WriteAllText($"{FilePath}.setting", $"{FontName}\n{FontSize}\n{FontStyle}\n{FontColor}");
            }
        }
        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, ContentBox.Text);
                // update the title if title contains *
                if (this.Text.Contains("*"))
                {
                    this.Text = FileName;
                }
                // save settings to file
                File.WriteAllText($"{FilePath}.setting", $"{FontName}\n{FontSize}\n{FontStyle}\n{FontColor}");
                FilePath = saveFileDialog.FileName;
            }
        }
        private void OpenMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                InitialDirectory = @"D:\",
                Filter = "Text files (*.txt)|*.txt",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = openFileDialog.FileName;
                    // Find setting file
                    String settingFile = $"{FilePath}.setting";
                    if (File.Exists(settingFile))
                    {
                        // Read setting file
                        String[] setting = File.ReadAllLines(settingFile);
                        FontName = setting[0];
                        FontSize = float.Parse(setting[1]);
                        FontStyle = setting[2];
                        FontColor = setting[3];
                    }
                    FileName = Path.GetFileName(FilePath);
                    ContentBox.Text = File.ReadAllText(FilePath);
                    ContentBox.Font = new Font(FontName, FontSize, (FontStyle)Enum.Parse(typeof(FontStyle), FontStyle));
                    ContentBox.ForeColor = Color.FromName(FontColor);
                    this.Text = FileName;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // check if * is in the title and ask to save
            if (this.Text.Contains("*"))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            //FindBox.Visible = !FindBox.Visible;
            FindBox.Visible = true;
            if (FindBox.Visible)
            {
                ButtonFind.Click += (sender, e) =>
                {
                    int start = 0;
                    int end = ContentBox.Text.LastIndexOf(FindBoxText.Text) + 1;
                    ContentBox.SelectAll();
                    ContentBox.SelectionBackColor = Color.White;
                    int count = 0;
                    while (start < end)
                    {
                        ContentBox.Find(FindBoxText.Text.Trim(), start, ContentBox.Text.Length, RichTextBoxFinds.MatchCase);
                        ContentBox.SelectionBackColor = Color.Red;
                        count++;
                        start = ContentBox.Text.IndexOf(FindBoxText.Text, start) + 1;
                    }
                    FindBoxLabel.Text = $"{count} result";
                };
                FindBoxClose.Click += (sender, e) =>
                {
                    FindBox.Visible = false;
                    ContentBox.SelectAll();
                    ContentBox.SelectionBackColor = Color.White;
                };

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttributeBox.Visible = true;
            List<String> lstBoxFonts = new List<String>();
            lstBoxFonts.AddRange(FontFamily.Families.Select(f => f.Name).ToList());
            FontAttributeValueBox.DataSource = lstBoxFonts;
            FontAttributeValueBox.Text = FontName;
            FontStyleAttributeValueBox.Text = FontStyle;
            FontColorAttributeBox.Text = FontColor;
            FontSizeAttributeBox.Text = FontSize.ToString();
            CloseAttributeButtonBox.Click += (sender, e) =>
            {
                AttributeBox.Visible = false;
            };
            SaveAttributeButtonBox.Click += (sender, e) =>
            {
                FontName = FontAttributeValueBox.Text;
                FontStyle = FontStyleAttributeValueBox.Text;
                FontColor = FontColorAttributeBox.Text;
                FontSize = float.Parse(FontSizeAttributeBox.Text);
                ContentBox.Font = new Font(FontName, FontSize, (FontStyle)Enum.Parse(typeof(FontStyle), FontStyle));
                ContentBox.ForeColor = Color.FromName(FontColor);
                AttributeBox.Visible = false;
            };
            //fontDialog1 = new FontDialog();
            //fontDialog1.ShowDialog();
            //FontName = fontDialog1.Font.Name;
            //FontSize = fontDialog1.Font.Size;
            //FontStyle = fontDialog1.Font.Style.ToString();

        }

    }
}
