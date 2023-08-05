namespace Winform_ADO
{
    partial class FilePractice
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
            openFileDialog1 = new OpenFileDialog();
            btnChooseFile = new Button();
            txtFileName = new TextBox();
            dgvEmployee = new DataGridView();
            btnRemove = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(23, 34);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(105, 32);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "ChooseFile";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(146, 34);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(531, 29);
            txtFileName.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(23, 143);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowTemplate.Height = 31;
            dgvEmployee.Size = new Size(654, 150);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(53, 353);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 32);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(196, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FilePractice
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(dgvEmployee);
            Controls.Add(txtFileName);
            Controls.Add(btnChooseFile);
            Name = "FilePractice";
            Text = "FilePractice";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnChooseFile;
        private TextBox txtFileName;
        private DataGridView dgvEmployee;
        private Button btnRemove;
        private Button btnSave;
    }
}