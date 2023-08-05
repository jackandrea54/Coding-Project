namespace WinForms_EF
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
            dgProduct = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtImage = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnExtit = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            cboCategory = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(12, 306);
            dgProduct.Name = "dgProduct";
            dgProduct.RowTemplate.Height = 31;
            dgProduct.Size = new Size(964, 231);
            dgProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 50);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(222, 29);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(586, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 29);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(222, 29);
            txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 113);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(586, 105);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(222, 29);
            txtStock.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 113);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 7;
            label4.Text = "Stock:";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(150, 172);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(222, 29);
            txtImage.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 180);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 9;
            label5.Text = "Image:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 180);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 11;
            label6.Text = "Category:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(149, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 33);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExtit
            // 
            btnExtit.Location = new Point(662, 247);
            btnExtit.Name = "btnExtit";
            btnExtit.Size = new Size(104, 33);
            btnExtit.TabIndex = 14;
            btnExtit.Text = "Exit";
            btnExtit.UseVisualStyleBackColor = true;
            btnExtit.Click += btnExtit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(526, 247);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 33);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(401, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 33);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(273, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 33);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(586, 177);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(222, 29);
            cboCategory.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(838, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 33);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 584);
            Controls.Add(btnSearch);
            Controls.Add(cboCategory);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnExtit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtImage);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgProduct);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduct;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtImage;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnExtit;
        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cboCategory;
        private Button btnSearch;
    }
}