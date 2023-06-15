namespace Assignment1
{
    partial class CarGUI_Admin
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
            btnLogout = new Button();
            btnAddNew = new Button();
            displayTotalCar = new TextBox();
            dataGridView1 = new DataGridView();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(26, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout(Admin)";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(26, 47);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(123, 29);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New...";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // displayTotalCar
            // 
            displayTotalCar.Location = new Point(26, 82);
            displayTotalCar.Name = "displayTotalCar";
            displayTotalCar.ReadOnly = true;
            displayTotalCar.Size = new Size(236, 27);
            displayTotalCar.TabIndex = 2;
            displayTotalCar.TextChanged += displayTotalCar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1017, 448);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(619, 67);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 29);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // CarGUI_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 586);
            Controls.Add(refreshBtn);
            Controls.Add(dataGridView1);
            Controls.Add(displayTotalCar);
            Controls.Add(btnAddNew);
            Controls.Add(btnLogout);
            Name = "CarGUI_Admin";
            Text = "CarGUI_Admin";
            Load += CarGUI_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnAddNew;
        private TextBox displayTotalCar;
        private DataGridView dataGridView1;
        private Button refreshBtn;
    }
}