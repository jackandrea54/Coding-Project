namespace WinForms_EF
{
    partial class FrmCustomer
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
            dgCustomer = new DataGridView();
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
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(67, 278);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowTemplate.Height = 31;
            dgCustomer.Size = new Size(654, 150);
            dgCustomer.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 33);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(376, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 33);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(501, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 33);
            btnReset.TabIndex = 32;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExtit
            // 
            btnExtit.Location = new Point(625, 226);
            btnExtit.Name = "btnExtit";
            btnExtit.Size = new Size(104, 33);
            btnExtit.TabIndex = 31;
            btnExtit.Text = "Exit";
            btnExtit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(124, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 33);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(108, 164);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(222, 29);
            txtAddress.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 172);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 27;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 105);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 25;
            label4.Text = "Gender:";
            // 
            // txtDob
            // 
            txtDob.Location = new Point(108, 97);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(222, 29);
            txtDob.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 105);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 23;
            label3.Text = "Birthdate:";
            // 
            // txtName
            // 
            txtName.Location = new Point(544, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 29);
            txtName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 47);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 21;
            label2.Text = "Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(222, 29);
            txtId.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 19;
            label1.Text = "ID: ";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(539, 105);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(62, 25);
            rdMale.TabIndex = 35;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(625, 105);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 25);
            rdFemale.TabIndex = 36;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
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
        private RadioButton rdMale;
        private RadioButton rdFemale;
    }
}