namespace PT2
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
            label1 = new Label();
            txtWord = new TextBox();
            label3 = new Label();
            lblMeaning = new Label();
            txtMeaning = new TextBox();
            label4 = new Label();
            cbType = new ComboBox();
            btnSearch = new Button();
            dgDictionary = new DataGridView();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDictionary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 38);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "DICTIONARY";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(139, 101);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(223, 29);
            txtWord.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 104);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 3;
            label3.Text = "Word: ";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Location = new Point(418, 109);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(74, 21);
            lblMeaning.TabIndex = 5;
            lblMeaning.Text = "Meaning:";
            lblMeaning.Click += lblMeaning_Click;
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(498, 101);
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(223, 29);
            txtMeaning.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 160);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 6;
            label4.Text = "Type:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(139, 156);
            cbType.Name = "cbType";
            cbType.Size = new Size(223, 29);
            cbType.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(418, 156);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgDictionary
            // 
            dgDictionary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDictionary.Location = new Point(68, 211);
            dgDictionary.Name = "dgDictionary";
            dgDictionary.RowTemplate.Height = 31;
            dgDictionary.Size = new Size(653, 192);
            dgDictionary.TabIndex = 9;
            dgDictionary.CellClick += dgDictionary_CellClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(12, 409);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(162, 29);
            btnLoadData.TabIndex = 10;
            btnLoadData.Text = "LOAD DATA";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadData);
            Controls.Add(dgDictionary);
            Controls.Add(btnSearch);
            Controls.Add(cbType);
            Controls.Add(label4);
            Controls.Add(lblMeaning);
            Controls.Add(txtMeaning);
            Controls.Add(label3);
            Controls.Add(txtWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDictionary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWord;
        private Label label3;
        private Label lblMeaning;
        private TextBox txtMeaning;
        private Label label4;
        private ComboBox cbType;
        private Button btnSearch;
        private DataGridView dgDictionary;
        private Button btnLoadData;
    }
}