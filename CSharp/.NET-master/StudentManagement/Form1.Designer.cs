namespace StudentManagementWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.OpenFilePath = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ID = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameTitle = new System.Windows.Forms.Label();
            this.YearOfBirth = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EntryYear = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.Label();
            this.YearOfBirthBox = new System.Windows.Forms.ComboBox();
            this.EntryYearBox = new System.Windows.Forms.ComboBox();
            this.MajorBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetForm = new System.Windows.Forms.Button();
            this.ShowFounded = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.23196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76804F));
            this.tableLayoutPanel1.Controls.Add(this.OpenFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenFilePath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.450705F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.54929F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(548, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(225, 29);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // OpenFilePath
            // 
            this.OpenFilePath.Location = new System.Drawing.Point(3, 3);
            this.OpenFilePath.Name = "OpenFilePath";
            this.OpenFilePath.Size = new System.Drawing.Size(539, 27);
            this.OpenFilePath.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(3, 39);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.Size = new System.Drawing.Size(539, 384);
            this.DataGridView.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IdBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NameTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.YearOfBirth, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.NameBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.EntryYear, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Major, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.YearOfBirthBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.EntryYearBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MajorBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.SearchButton, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.ResetForm, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.ShowFounded, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(548, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 384);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(3, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(104, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(113, 3);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(108, 27);
            this.IdBox.TabIndex = 2;
            // 
            // NameTitle
            // 
            this.NameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTitle.AutoSize = true;
            this.NameTitle.Location = new System.Drawing.Point(3, 38);
            this.NameTitle.Name = "NameTitle";
            this.NameTitle.Size = new System.Drawing.Size(104, 20);
            this.NameTitle.TabIndex = 1;
            this.NameTitle.Text = "Name";
            this.NameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearOfBirth.AutoSize = true;
            this.YearOfBirth.Location = new System.Drawing.Point(3, 71);
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Size = new System.Drawing.Size(104, 20);
            this.YearOfBirth.TabIndex = 4;
            this.YearOfBirth.Text = "YearOfBirth";
            this.YearOfBirth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(113, 41);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(108, 27);
            this.NameBox.TabIndex = 3;
            // 
            // EntryYear
            // 
            this.EntryYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryYear.AutoSize = true;
            this.EntryYear.Location = new System.Drawing.Point(3, 107);
            this.EntryYear.Name = "EntryYear";
            this.EntryYear.Size = new System.Drawing.Size(104, 20);
            this.EntryYear.TabIndex = 5;
            this.EntryYear.Text = "EntryYear";
            this.EntryYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Major
            // 
            this.Major.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(3, 152);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(104, 20);
            this.Major.TabIndex = 6;
            this.Major.Text = "Major";
            this.Major.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YearOfBirthBox
            // 
            this.YearOfBirthBox.FormattingEnabled = true;
            this.YearOfBirthBox.Items.AddRange(new object[] {
            "All"});
            this.YearOfBirthBox.Location = new System.Drawing.Point(113, 74);
            this.YearOfBirthBox.Name = "YearOfBirthBox";
            this.YearOfBirthBox.Size = new System.Drawing.Size(108, 28);
            this.YearOfBirthBox.TabIndex = 7;
            // 
            // EntryYearBox
            // 
            this.EntryYearBox.FormattingEnabled = true;
            this.EntryYearBox.Items.AddRange(new object[] {
            "All"});
            this.EntryYearBox.Location = new System.Drawing.Point(113, 110);
            this.EntryYearBox.Name = "EntryYearBox";
            this.EntryYearBox.Size = new System.Drawing.Size(108, 28);
            this.EntryYearBox.TabIndex = 8;
            // 
            // MajorBox
            // 
            this.MajorBox.FormattingEnabled = true;
            this.MajorBox.ItemHeight = 20;
            this.MajorBox.Location = new System.Drawing.Point(113, 155);
            this.MajorBox.Name = "MajorBox";
            this.MajorBox.Size = new System.Drawing.Size(108, 104);
            this.MajorBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(113, 269);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reset Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetForm
            // 
            this.ResetForm.Location = new System.Drawing.Point(113, 319);
            this.ResetForm.Name = "ResetForm";
            this.ResetForm.Size = new System.Drawing.Size(94, 29);
            this.ResetForm.TabIndex = 13;
            this.ResetForm.Text = "Reset";
            this.ResetForm.UseVisualStyleBackColor = true;
            this.ResetForm.Click += new System.EventHandler(this.ResetForm_Click);
            // 
            // ShowFounded
            // 
            this.ShowFounded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowFounded.AutoSize = true;
            this.ShowFounded.Location = new System.Drawing.Point(3, 358);
            this.ShowFounded.Name = "ShowFounded";
            this.ShowFounded.Size = new System.Drawing.Size(104, 20);
            this.ShowFounded.TabIndex = 14;
            this.ShowFounded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1"; 
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox OpenFilePath;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NameTitle;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label YearOfBirth;
        private System.Windows.Forms.Label EntryYear;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.ComboBox YearOfBirthBox;
        private System.Windows.Forms.ComboBox EntryYearBox;
        private System.Windows.Forms.ListBox MajorBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetForm;
        private System.Windows.Forms.Label ShowFounded;
    }
}
