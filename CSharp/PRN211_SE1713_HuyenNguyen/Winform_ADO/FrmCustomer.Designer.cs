namespace Winform_ADO
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
            label1 = new Label();
            txtId = new TextBox();
            txtDob = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(76, 243);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowTemplate.Height = 31;
            dgCustomer.Size = new Size(646, 173);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellClick += dgCustomer_CellClick;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 28);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(236, 29);
            txtId.TabIndex = 2;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(96, 72);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(236, 29);
            txtDob.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Birthdate";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(96, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(611, 29);
            txtAddress.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(486, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 29);
            txtName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 31);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 76);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(515, 76);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(62, 25);
            rdMale.TabIndex = 10;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(629, 76);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 25);
            rdFemale.TabIndex = 11;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(76, 193);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(91, 32);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(221, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 32);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 32);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(486, 193);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(91, 32);
            btnReset.TabIndex = 15;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(616, 193);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 32);
            btnExit.TabIndex = 16;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtDob);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            FormClosing += FrmCustomer_FormClosing;
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private Label label1;
        private TextBox txtId;
        private TextBox txtDob;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnExit;
    }
}