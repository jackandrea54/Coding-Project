namespace EF_SE1715
{
    partial class FormAddEdit
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
            CarID = new Label();
            Make = new Label();
            Color = new Label();
            Petname = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Add = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // CarID
            // 
            CarID.AutoSize = true;
            CarID.Location = new Point(67, 46);
            CarID.Name = "CarID";
            CarID.Size = new Size(46, 20);
            CarID.TabIndex = 0;
            CarID.Text = "CarID";
            // 
            // Make
            // 
            Make.AutoSize = true;
            Make.Location = new Point(67, 129);
            Make.Name = "Make";
            Make.Size = new Size(45, 20);
            Make.TabIndex = 1;
            Make.Text = "Make";
            Make.Click += label1_Click;
            // 
            // Color
            // 
            Color.AutoSize = true;
            Color.Location = new Point(67, 219);
            Color.Name = "Color";
            Color.Size = new Size(45, 20);
            Color.TabIndex = 2;
            Color.Text = "Color";
            // 
            // Petname
            // 
            Petname.AutoSize = true;
            Petname.Location = new Point(67, 289);
            Petname.Name = "Petname";
            Petname.Size = new Size(66, 20);
            Petname.TabIndex = 3;
            Petname.Text = "Petname";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 293);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 27);
            textBox4.TabIndex = 7;
            // 
            // Add
            // 
            Add.Location = new Point(176, 402);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(363, 402);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // FormAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 491);
            Controls.Add(Cancel);
            Controls.Add(Add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Petname);
            Controls.Add(Color);
            Controls.Add(Make);
            Controls.Add(CarID);
            Name = "FormAddEdit";
            Text = "FormAddEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CarID;
        private Label Make;
        private Label Color;
        private Label Petname;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Add;
        private Button Cancel;
    }
}