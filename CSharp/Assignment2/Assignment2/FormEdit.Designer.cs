namespace Assignment2
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentID = new Label();
            rollNumber = new Label();
            firstName = new Label();
            midName = new Label();
            lastName = new Label();
            textBoxStudentID = new TextBox();
            textBoxRoll = new TextBox();
            textBoxFName = new TextBox();
            textBoxMName = new TextBox();
            textBoxLName = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.BackColor = SystemColors.Control;
            studentID.Location = new Point(79, 59);
            studentID.Name = "studentID";
            studentID.Size = new Size(79, 20);
            studentID.TabIndex = 0;
            studentID.Text = "Student ID";
            // 
            // rollNumber
            // 
            rollNumber.AutoSize = true;
            rollNumber.BackColor = SystemColors.Control;
            rollNumber.Location = new Point(79, 119);
            rollNumber.Name = "rollNumber";
            rollNumber.Size = new Size(93, 20);
            rollNumber.TabIndex = 1;
            rollNumber.Text = "Roll Number";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(79, 183);
            firstName.Name = "firstName";
            firstName.Size = new Size(80, 20);
            firstName.TabIndex = 2;
            firstName.Text = "First Name";
            // 
            // midName
            // 
            midName.AutoSize = true;
            midName.Location = new Point(79, 241);
            midName.Name = "midName";
            midName.Size = new Size(100, 20);
            midName.TabIndex = 3;
            midName.Text = "Middle Name";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.BackColor = SystemColors.Control;
            lastName.Location = new Point(79, 291);
            lastName.Name = "lastName";
            lastName.Size = new Size(79, 20);
            lastName.TabIndex = 4;
            lastName.Text = "Last Name";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(225, 59);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.ReadOnly = true;
            textBoxStudentID.Size = new Size(125, 27);
            textBoxStudentID.TabIndex = 5;
            // 
            // textBoxRoll
            // 
            textBoxRoll.Location = new Point(225, 116);
            textBoxRoll.Name = "textBoxRoll";
            textBoxRoll.ReadOnly = true;
            textBoxRoll.Size = new Size(125, 27);
            textBoxRoll.TabIndex = 6;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(225, 183);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(125, 27);
            textBoxFName.TabIndex = 7;
            // 
            // textBoxMName
            // 
            textBoxMName.Location = new Point(225, 241);
            textBoxMName.Name = "textBoxMName";
            textBoxMName.Size = new Size(125, 27);
            textBoxMName.TabIndex = 8;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(225, 291);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(125, 27);
            textBoxLName.TabIndex = 9;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(177, 380);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(401, 380);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxMName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxRoll);
            Controls.Add(textBoxStudentID);
            Controls.Add(lastName);
            Controls.Add(midName);
            Controls.Add(firstName);
            Controls.Add(rollNumber);
            Controls.Add(studentID);
            Name = "FormEdit";
            Text = "FormEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentID;
        private Label rollNumber;
        private Label firstName;
        private Label midName;
        private Label lastName;
        private TextBox textBoxStudentID;
        private TextBox textBoxRoll;
        private TextBox textBoxFName;
        private TextBox textBoxMName;
        private TextBox textBoxLName;
        private Button saveBtn;
        private Button cancelBtn;
    }
}