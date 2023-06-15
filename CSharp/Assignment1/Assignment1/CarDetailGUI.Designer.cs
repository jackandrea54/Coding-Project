namespace Assignment1
{
    partial class CarDetailsGUI
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
            btnBack = new Button();
            CarId = new Label();
            displayId = new TextBox();
            make = new Label();
            displayMake = new TextBox();
            label1 = new Label();
            label2 = new Label();
            displayTextColor = new TextBox();
            displayPetName = new TextBox();
            displayColor = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(244, 294);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CarId
            // 
            CarId.AutoSize = true;
            CarId.Location = new Point(97, 91);
            CarId.Name = "CarId";
            CarId.Size = new Size(47, 20);
            CarId.TabIndex = 1;
            CarId.Text = "CarId:";
            // 
            // displayId
            // 
            displayId.Location = new Point(150, 84);
            displayId.Name = "displayId";
            displayId.ReadOnly = true;
            displayId.Size = new Size(125, 27);
            displayId.TabIndex = 2;
            displayId.TextChanged += displayId_TextChanged;
            // 
            // make
            // 
            make.AutoSize = true;
            make.Location = new Point(96, 159);
            make.Name = "make";
            make.Size = new Size(48, 20);
            make.TabIndex = 3;
            make.Text = "Make:";
            // 
            // displayMake
            // 
            displayMake.Location = new Point(150, 156);
            displayMake.Name = "displayMake";
            displayMake.ReadOnly = true;
            displayMake.Size = new Size(125, 27);
            displayMake.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 91);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 159);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "PetName:";
            // 
            // displayTextColor
            // 
            displayTextColor.Location = new Point(394, 88);
            displayTextColor.Name = "displayTextColor";
            displayTextColor.ReadOnly = true;
            displayTextColor.Size = new Size(130, 27);
            displayTextColor.TabIndex = 7;
            // 
            // displayPetName
            // 
            displayPetName.Location = new Point(394, 156);
            displayPetName.Name = "displayPetName";
            displayPetName.ReadOnly = true;
            displayPetName.Size = new Size(130, 27);
            displayPetName.TabIndex = 8;
            // 
            // displayColor
            // 
            displayColor.Location = new Point(546, 88);
            displayColor.Name = "displayColor";
            displayColor.ReadOnly = true;
            displayColor.Size = new Size(36, 27);
            displayColor.TabIndex = 9;
            // 
            // CarDetailsGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 381);
            Controls.Add(displayColor);
            Controls.Add(displayPetName);
            Controls.Add(displayTextColor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(displayMake);
            Controls.Add(make);
            Controls.Add(displayId);
            Controls.Add(CarId);
            Controls.Add(btnBack);
            Name = "CarDetailsGUI";
            Text = "CarDetailsGUI";
            Load += CarDetailsGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label CarId;
        private TextBox displayId;
        private Label make;
        private TextBox displayMake;
        private Label label1;
        private Label label2;
        private TextBox displayTextColor;
        private TextBox displayPetName;
        private TextBox displayColor;
    }
}