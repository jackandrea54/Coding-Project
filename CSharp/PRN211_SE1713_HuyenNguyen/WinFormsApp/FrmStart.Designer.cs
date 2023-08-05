namespace WinFormsApp
{
    partial class FrmStart
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
            components = new System.ComponentModel.Container();
            lblCount = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            textName = new TextBox();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.Location = new Point(343, 135);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(107, 86);
            lblCount.TabIndex = 0;
            lblCount.Text = "10";
            // 
            // button1
            // 
            button1.Location = new Point(343, 274);
            button1.Name = "button1";
            button1.Size = new Size(104, 45);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 232);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter name: ";
            // 
            // textName
            // 
            textName.Location = new Point(291, 229);
            textName.Name = "textName";
            textName.Size = new Size(201, 29);
            textName.TabIndex = 3;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblCount);
            Name = "FrmStart";
            Text = "FrmStart";
            FormClosing += FrmStart_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCount;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox textName;
    }
}