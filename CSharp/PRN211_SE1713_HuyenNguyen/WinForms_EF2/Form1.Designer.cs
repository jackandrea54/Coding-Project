namespace WinForms_EF2
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
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnExtit = new Button();
            btnAdd = new Button();
            txtAddress = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDob = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            dgCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(643, 116);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 25);
            rdFemale.TabIndex = 53;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(557, 116);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(62, 25);
            rdMale.TabIndex = 52;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(266, 236);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 33);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(394, 236);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 33);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(519, 237);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 33);
            btnReset.TabIndex = 49;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExtit
            // 
            btnExtit.Location = new Point(643, 237);
            btnExtit.Name = "btnExtit";
            btnExtit.Size = new Size(104, 33);
            btnExtit.TabIndex = 48;
            btnExtit.Text = "Exit";
            btnExtit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 33);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(126, 175);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(222, 29);
            txtAddress.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 183);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 45;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 116);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 44;
            label4.Text = "Gender:";
            // 
            // txtDob
            // 
            txtDob.Location = new Point(126, 108);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(222, 29);
            txtDob.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 116);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 42;
            label3.Text = "Birthdate:";
            // 
            // txtName
            // 
            txtName.Location = new Point(562, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 29);
            txtName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 40;
            label2.Text = "Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(222, 29);
            txtId.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 38;
            label1.Text = "ID: ";
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(87, 289);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowTemplate.Height = 31;
            dgCustomer.Size = new Size(654, 150);
            dgCustomer.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 485);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnExtit);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDob);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnExtit;
        private Button btnAdd;
        private TextBox txtAddress;
        private Label label5;
        private Label label4;
        private TextBox txtDob;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private DataGridView dgCustomer;
    }
}