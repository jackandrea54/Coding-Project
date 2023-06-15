namespace Assignment2
{
    partial class FormCourse
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
            courseComboBox = new ComboBox();
            dateComboBox = new ComboBox();
            saveBtn = new Button();
            attendanceDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(108, 55);
            courseComboBox.Margin = new Padding(3, 2, 3, 2);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(190, 23);
            courseComboBox.TabIndex = 0;
            courseComboBox.SelectedIndexChanged += courseComboBox_SelectedIndexChanged;
            // 
            // dateComboBox
            // 
            dateComboBox.FormattingEnabled = true;
            dateComboBox.Location = new Point(482, 55);
            dateComboBox.Margin = new Padding(3, 2, 3, 2);
            dateComboBox.Name = "dateComboBox";
            dateComboBox.Size = new Size(133, 23);
            dateComboBox.TabIndex = 1;
            dateComboBox.SelectedIndexChanged += dateComboBox_SelectedIndexChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(716, 38);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(157, 46);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // attendanceDataGridView
            // 
            attendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceDataGridView.Location = new Point(26, 95);
            attendanceDataGridView.Margin = new Padding(3, 2, 3, 2);
            attendanceDataGridView.Name = "attendanceDataGridView";
            attendanceDataGridView.RowHeadersWidth = 51;
            attendanceDataGridView.RowTemplate.Height = 29;
            attendanceDataGridView.Size = new Size(1024, 382);
            attendanceDataGridView.TabIndex = 3;
            // 
            // FormCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 486);
            Controls.Add(attendanceDataGridView);
            Controls.Add(saveBtn);
            Controls.Add(dateComboBox);
            Controls.Add(courseComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCourse";
            Text = "FormCourse";
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox courseComboBox;
        private ComboBox dateComboBox;
        private Button saveBtn;
        private DataGridView attendanceDataGridView;
    }
}