using System.Collections.Generic;
using System.Drawing;

namespace FirstWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TextBox2 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(983, 37);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(135, 95);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button9
            // 
            this.Button9.AutoSize = true;
            this.Button9.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(985, 138);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(135, 95);
            this.Button9.TabIndex = 2;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button6
            // 
            this.Button6.AutoSize = true;
            this.Button6.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(985, 239);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(135, 95);
            this.Button6.TabIndex = 3;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(985, 340);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(135, 95);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonDot
            // 
            this.ButtonDot.AutoSize = true;
            this.ButtonDot.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDot.Location = new System.Drawing.Point(985, 441);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(135, 95);
            this.ButtonDot.TabIndex = 5;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button0
            // 
            this.Button0.AutoSize = true;
            this.Button0.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button0.Location = new System.Drawing.Point(844, 441);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(135, 95);
            this.Button0.TabIndex = 10;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(844, 340);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(135, 95);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button5
            // 
            this.Button5.AutoSize = true;
            this.Button5.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(844, 239);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(135, 95);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button8
            // 
            this.Button8.AutoSize = true;
            this.Button8.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(844, 138);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(135, 95);
            this.Button8.TabIndex = 7;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonCE
            // 
            this.ButtonCE.AutoSize = true;
            this.ButtonCE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCE.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCE.Location = new System.Drawing.Point(844, 37);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(135, 95);
            this.ButtonCE.TabIndex = 6;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = false;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(703, 340);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(135, 95);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button4
            // 
            this.Button4.AutoSize = true;
            this.Button4.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(703, 239);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(135, 95);
            this.Button4.TabIndex = 13;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button7
            // 
            this.Button7.AutoSize = true;
            this.Button7.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(703, 138);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(135, 95);
            this.Button7.TabIndex = 12;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 385);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 18;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox2.Location = new System.Drawing.Point(12, 274);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(685, 105);
            this.TextBox2.TabIndex = 19;
            this.TextBox2.Text = "0";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox1.Location = new System.Drawing.Point(12, 27);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(685, 105);
            this.TextBox1.TabIndex = 15;
            this.TextBox1.Text = "0";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 551);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Caculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox TextBox2;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
