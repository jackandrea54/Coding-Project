namespace Lab2
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
            comboBox_Major = new ComboBox();
            label_Major = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox_ID = new TextBox();
            textBox_Name = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton_Male = new RadioButton();
            radioButton_Female = new RadioButton();
            dateTimePicker_DOB = new DateTimePicker();
            comboBox_MajorInTable = new ComboBox();
            listBox_Scholarship = new ListBox();
            checkBox_Active = new CheckBox();
            panel1 = new Panel();
            button_Add = new Button();
            button_Update = new Button();
            button_Delete = new Button();
            button_Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_Major
            // 
            comboBox_Major.FormattingEnabled = true;
            comboBox_Major.Location = new Point(205, 10);
            comboBox_Major.Margin = new Padding(2);
            comboBox_Major.Name = "comboBox_Major";
            comboBox_Major.Size = new Size(197, 28);
            comboBox_Major.TabIndex = 0;
            comboBox_Major.Text = "Tất cả";
            comboBox_Major.SelectedIndexChanged += comboBox_Major_SelectedIndexChanged;
            // 
            // label_Major
            // 
            label_Major.AutoSize = true;
            label_Major.Location = new Point(66, 12);
            label_Major.Margin = new Padding(2, 0, 2, 0);
            label_Major.Name = "label_Major";
            label_Major.Size = new Size(54, 20);
            label_Major.TabIndex = 1;
            label_Major.Text = "Majors";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 62);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1022, 383);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8928566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.10714F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 6);
            tableLayoutPanel1.Controls.Add(label10, 0, 7);
            tableLayoutPanel1.Controls.Add(textBox_ID, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker_DOB, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox_MajorInTable, 1, 4);
            tableLayoutPanel1.Controls.Add(listBox_Scholarship, 1, 5);
            tableLayoutPanel1.Controls.Add(checkBox_Active, 1, 6);
            tableLayoutPanel1.Controls.Add(panel1, 1, 7);
            tableLayoutPanel1.Location = new Point(1056, 62);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.60334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4821806F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0628929F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5786161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9496851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.2243185F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9496851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.1090145F));
            tableLayoutPanel1.Size = new Size(358, 383);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(23, 48);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(19, 87);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(17, 129);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Date Of";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(23, 175);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Major";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(5, 215);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 7;
            label8.Text = "Scholarship";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(17, 255);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 8;
            label9.Text = "IsActive";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(21, 325);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 9;
            label10.Text = "Action";
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.None;
            textBox_ID.Location = new Point(97, 6);
            textBox_ID.Margin = new Padding(2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.ReadOnly = true;
            textBox_ID.Size = new Size(257, 27);
            textBox_ID.TabIndex = 10;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.None;
            textBox_Name.Location = new Point(97, 44);
            textBox_Name.Margin = new Padding(2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(257, 27);
            textBox_Name.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(radioButton_Male);
            flowLayoutPanel1.Controls.Add(radioButton_Female);
            flowLayoutPanel1.Location = new Point(97, 81);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(257, 32);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // radioButton_Male
            // 
            radioButton_Male.Anchor = AnchorStyles.None;
            radioButton_Male.Location = new Point(2, 2);
            radioButton_Male.Margin = new Padding(2);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(114, 28);
            radioButton_Male.TabIndex = 12;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.None;
            radioButton_Female.Location = new Point(120, 2);
            radioButton_Female.Margin = new Padding(2);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(121, 27);
            radioButton_Female.TabIndex = 4;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Anchor = AnchorStyles.None;
            dateTimePicker_DOB.Format = DateTimePickerFormat.Short;
            dateTimePicker_DOB.Location = new Point(105, 126);
            dateTimePicker_DOB.Margin = new Padding(2);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(241, 27);
            dateTimePicker_DOB.TabIndex = 15;
            // 
            // comboBox_MajorInTable
            // 
            comboBox_MajorInTable.Anchor = AnchorStyles.None;
            comboBox_MajorInTable.FormattingEnabled = true;
            comboBox_MajorInTable.Location = new Point(104, 171);
            comboBox_MajorInTable.Margin = new Padding(2);
            comboBox_MajorInTable.Name = "comboBox_MajorInTable";
            comboBox_MajorInTable.Size = new Size(242, 28);
            comboBox_MajorInTable.TabIndex = 16;
            // 
            // listBox_Scholarship
            // 
            listBox_Scholarship.Anchor = AnchorStyles.None;
            listBox_Scholarship.FormattingEnabled = true;
            listBox_Scholarship.ItemHeight = 20;
            listBox_Scholarship.Location = new Point(110, 213);
            listBox_Scholarship.Margin = new Padding(2);
            listBox_Scholarship.Name = "listBox_Scholarship";
            listBox_Scholarship.ScrollAlwaysVisible = true;
            listBox_Scholarship.Size = new Size(231, 24);
            listBox_Scholarship.TabIndex = 17;
            // 
            // checkBox_Active
            // 
            checkBox_Active.Anchor = AnchorStyles.Left;
            checkBox_Active.AutoSize = true;
            checkBox_Active.Location = new Point(97, 253);
            checkBox_Active.Margin = new Padding(2);
            checkBox_Active.Name = "checkBox_Active";
            checkBox_Active.Size = new Size(72, 24);
            checkBox_Active.TabIndex = 18;
            checkBox_Active.Text = "Active";
            checkBox_Active.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(button_Update);
            panel1.Controls.Add(button_Delete);
            panel1.Controls.Add(button_Reset);
            panel1.Location = new Point(97, 291);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 86);
            panel1.TabIndex = 23;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(26, 13);
            button_Add.Margin = new Padding(2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(90, 27);
            button_Add.TabIndex = 19;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(142, 13);
            button_Update.Margin = new Padding(2);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(90, 27);
            button_Update.TabIndex = 20;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(26, 45);
            button_Delete.Margin = new Padding(2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(90, 27);
            button_Delete.TabIndex = 22;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Reset
            // 
            button_Reset.Location = new Point(142, 45);
            button_Reset.Margin = new Padding(2);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(90, 27);
            button_Reset.TabIndex = 21;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 477);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label_Major);
            Controls.Add(comboBox_Major);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Major;
        private Label label_Major;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox_ID;
        private TextBox textBox_Name;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private DateTimePicker dateTimePicker_DOB;
        private ComboBox comboBox_MajorInTable;
        private ListBox listBox_Scholarship;
        private CheckBox checkBox_Active;
        private Panel panel1;
        private Button button_Add;
        private Button button_Update;
        private Button button_Delete;
        private Button button_Reset;
    }
}