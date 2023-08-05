namespace Question1
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
            dataGridView1 = new DataGridView();
            saveBtn = new Button();
            groupBox1 = new GroupBox();
            addBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            employeeNameBox = new TextBox();
            employeeIdBox = new TextBox();
            femaleBtn = new RadioButton();
            maleBtn = new RadioButton();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(504, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(491, 340);
            dataGridView1.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(697, 395);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "SaveToFile";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(employeeNameBox);
            groupBox1.Controls.Add(employeeIdBox);
            groupBox1.Controls.Add(femaleBtn);
            groupBox1.Controls.Add(maleBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 340);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "EmployeeInfo";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(314, 290);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "AddToList";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // employeeNameBox
            // 
            employeeNameBox.Location = new Point(158, 108);
            employeeNameBox.Name = "employeeNameBox";
            employeeNameBox.Size = new Size(257, 27);
            employeeNameBox.TabIndex = 7;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Location = new Point(159, 58);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(256, 27);
            employeeIdBox.TabIndex = 6;
            // 
            // femaleBtn
            // 
            femaleBtn.AutoSize = true;
            femaleBtn.Location = new Point(124, 259);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(78, 24);
            femaleBtn.TabIndex = 5;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            maleBtn.AutoSize = true;
            maleBtn.Location = new Point(124, 210);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(63, 24);
            maleBtn.TabIndex = 4;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 212);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 160);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "EmployeeName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 58);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 0;
            label3.Text = "EmployeeId";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 450);
            Controls.Add(groupBox1);
            Controls.Add(saveBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button saveBtn;
        private GroupBox groupBox1;
        private RadioButton femaleBtn;
        private RadioButton maleBtn;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox employeeNameBox;
        private TextBox employeeIdBox;
        private Button addBtn;
    }
}