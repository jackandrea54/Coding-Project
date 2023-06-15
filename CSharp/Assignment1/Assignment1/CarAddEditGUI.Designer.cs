namespace Assignment1
{
    partial class CarAddEditGUI
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inputCarId = new TextBox();
            inputMake = new TextBox();
            inputColor = new TextBox();
            inputPetName = new TextBox();
            diplayColor = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 114);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "CarId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 180);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 114);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 180);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "PetName:";
            label4.Click += label4_Click;
            // 
            // inputCarId
            // 
            inputCarId.Location = new Point(179, 107);
            inputCarId.Name = "inputCarId";
            inputCarId.ReadOnly = true;
            inputCarId.Size = new Size(125, 27);
            inputCarId.TabIndex = 4;
            // 
            // inputMake
            // 
            inputMake.Location = new Point(179, 173);
            inputMake.Name = "inputMake";
            inputMake.Size = new Size(125, 27);
            inputMake.TabIndex = 5;
            // 
            // inputColor
            // 
            inputColor.Location = new Point(440, 111);
            inputColor.Name = "inputColor";
            inputColor.Size = new Size(125, 27);
            inputColor.TabIndex = 6;
            // 
            // inputPetName
            // 
            inputPetName.Location = new Point(440, 177);
            inputPetName.Name = "inputPetName";
            inputPetName.Size = new Size(125, 27);
            inputPetName.TabIndex = 7;
            // 
            // diplayColor
            // 
            diplayColor.Location = new Point(571, 111);
            diplayColor.Name = "diplayColor";
            diplayColor.Size = new Size(36, 27);
            diplayColor.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(233, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(386, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CarAddEditGUI
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(718, 402);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(diplayColor);
            Controls.Add(inputPetName);
            Controls.Add(inputColor);
            Controls.Add(inputMake);
            Controls.Add(inputCarId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarAddEditGUI";
            Text = "CarAddEditGUI";
            Load += CarAddEditGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputCarId;
        private TextBox inputMake;
        private TextBox inputColor;
        private TextBox inputPetName;
        private TextBox diplayColor;
        private Button btnSave;
        private Button btnCancel;
    }
}