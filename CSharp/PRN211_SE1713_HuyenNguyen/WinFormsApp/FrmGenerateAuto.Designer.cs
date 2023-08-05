namespace WinFormsApp
{
    partial class FrmGenerateAuto
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
            label1 = new Label();
            numText = new NumericUpDown();
            btnAddText = new Button();
            ((System.ComponentModel.ISupportInitialize)numText).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 94);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter number of text: ";
            // 
            // numText
            // 
            numText.Location = new Point(348, 86);
            numText.Name = "numText";
            numText.Size = new Size(120, 29);
            numText.TabIndex = 1;
            // 
            // btnAddText
            // 
            btnAddText.Location = new Point(512, 86);
            btnAddText.Name = "btnAddText";
            btnAddText.Size = new Size(137, 36);
            btnAddText.TabIndex = 2;
            btnAddText.Text = "Add Text";
            btnAddText.UseVisualStyleBackColor = true;
            btnAddText.Click += btnAddText_Click;
            // 
            // FrmGenerateAuto
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 555);
            Controls.Add(btnAddText);
            Controls.Add(numText);
            Controls.Add(label1);
            Name = "FrmGenerateAuto";
            Text = "FrmGenerateAuto";
            FormClosing += FrmGenerateAuto_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numText;
        private Button btnAddText;
    }
}