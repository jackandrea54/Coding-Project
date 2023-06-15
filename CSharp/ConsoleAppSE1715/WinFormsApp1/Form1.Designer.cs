namespace WinFormsApp1
{
    partial class Form1
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
            btClickme = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btClickme
            // 
            btClickme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btClickme.Location = new Point(21, 12);
            btClickme.Name = "btClickme";
            btClickme.Size = new Size(166, 52);
            btClickme.TabIndex = 0;
            btClickme.Text = "Click Me";
            btClickme.UseVisualStyleBackColor = true;
            btClickme.Click += AddNewBtn;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 533);
            Controls.Add(textBox1);
            Controls.Add(btClickme);
            Name = "Form1";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClickme;
        private TextBox textBox1;
    }
}