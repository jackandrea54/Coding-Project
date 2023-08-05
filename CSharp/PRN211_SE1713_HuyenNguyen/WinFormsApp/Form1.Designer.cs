namespace WinFormsApp
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
            groupBox1 = new GroupBox();
            numMark = new NumericUpDown();
            cboSubject = new ComboBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lstStudent = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numMark);
            groupBox1.Controls.Add(cboSubject);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // numMark
            // 
            numMark.Location = new Point(151, 230);
            numMark.Name = "numMark";
            numMark.Size = new Size(120, 29);
            numMark.TabIndex = 9;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Math", "English", "Physics" });
            cboSubject.Location = new Point(150, 183);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(321, 29);
            cboSubject.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 29);
            txtName.TabIndex = 7;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(150, 90);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(321, 29);
            txtCode.TabIndex = 4;
            txtCode.TextChanged += txtCode_TextChanged;
            txtCode.Enter += txtCode_Enter;
            txtCode.Leave += txtCode_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(23, 230);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 3;
            label6.Text = "Mark: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(23, 138);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 2;
            label5.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(23, 183);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 1;
            label4.Text = "Subject: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 0;
            label2.Text = "Code: ";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstStudent);
            groupBox2.Location = new Point(740, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 358);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // lstStudent
            // 
            lstStudent.FormattingEnabled = true;
            lstStudent.ItemHeight = 21;
            lstStudent.Location = new Point(41, 46);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(503, 298);
            lstStudent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(553, 35);
            label1.Name = "label1";
            label1.Size = new Size(303, 36);
            label1.TabIndex = 2;
            label1.Text = "STUDENT MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.IndianRed;
            btnAdd.Location = new Point(613, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.IndianRed;
            btnRemove.Location = new Point(613, 272);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 30);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.IndianRed;
            btnLoad.Location = new Point(613, 312);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 30);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.IndianRed;
            btnSave.Location = new Point(613, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.IndianRed;
            btnExit.Location = new Point(613, 396);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 614);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Student Management";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCode;
        private NumericUpDown numMark;
        private ComboBox cboSubject;
        private TextBox txtName;
        private ListBox lstStudent;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnLoad;
        private Button btnSave;
        private Button btnExit;
    }
}