namespace Assignment1
{
    partial class CarGUI
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
            dataGridView1 = new DataGridView();
            login = new Button();
            totalCar = new TextBox();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(940, 486);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // login
            // 
            login.Location = new Point(39, 23);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // totalCar
            // 
            totalCar.Location = new Point(39, 69);
            totalCar.Name = "totalCar";
            totalCar.ReadOnly = true;
            totalCar.Size = new Size(244, 27);
            totalCar.TabIndex = 2;
            totalCar.TextChanged += totalCar_TextChanged;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(640, 53);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 29);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // CarGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 619);
            Controls.Add(refreshBtn);
            Controls.Add(totalCar);
            Controls.Add(login);
            Controls.Add(dataGridView1);
            Name = "CarGUI";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button login;
        private TextBox totalCar;
        private Button refreshBtn;
    }
}