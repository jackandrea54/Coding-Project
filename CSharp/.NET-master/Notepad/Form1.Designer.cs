namespace Notepad
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.FindBox = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.FindBoxClose = new System.Windows.Forms.Button();
            this.FindBoxText = new System.Windows.Forms.RichTextBox();
            this.FindBoxLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AttributeBox = new System.Windows.Forms.TableLayoutPanel();
            this.FontAttributeValueBox = new System.Windows.Forms.ComboBox();
            this.FontAttributeBox = new System.Windows.Forms.Label();
            this.ColorAttributeBox = new System.Windows.Forms.Label();
            this.FontSizeAttributeBox = new System.Windows.Forms.ComboBox();
            this.SizeAttributeBox = new System.Windows.Forms.Label();
            this.FontColorAttributeBox = new System.Windows.Forms.ComboBox();
            this.FontStyleAttributeBox = new System.Windows.Forms.Label();
            this.FontStyleAttributeValueBox = new System.Windows.Forms.ComboBox();
            this.CloseAttributeButtonBox = new System.Windows.Forms.Button();
            this.SaveAttributeButtonBox = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.FindBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.AttributeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(103, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.NewWindows,
            this.OpenMenu,
            this.Save,
            this.SaveAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // NewWindows
            // 
            this.NewWindows.BackColor = System.Drawing.SystemColors.Window;
            this.NewWindows.Name = "NewWindows";
            this.NewWindows.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.NewWindows.Size = new System.Drawing.Size(277, 26);
            this.NewWindows.Text = "New windows";
            // 
            // OpenMenu
            // 
            this.OpenMenu.BackColor = System.Drawing.SystemColors.Window;
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenu.Size = new System.Drawing.Size(277, 26);
            this.OpenMenu.Text = "Open";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Window;
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(277, 26);
            this.Save.Text = "Save";
            // 
            // SaveAs
            // 
            this.SaveAs.BackColor = System.Drawing.SystemColors.Window;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAs.Size = new System.Drawing.Size(277, 26);
            this.SaveAs.Text = "Save as";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo,
            this.Redo,
            this.toolStripSeparator1,
            this.Cut,
            this.Copy,
            this.Paste,
            this.Delete,
            this.SelectAll,
            this.Find,
            this.toolStripSeparator2,
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Undo.Size = new System.Drawing.Size(218, 26);
            this.Undo.Text = "Undo";
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.Redo.Size = new System.Drawing.Size(218, 26);
            this.Redo.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // Cut
            // 
            this.Cut.BackColor = System.Drawing.SystemColors.Window;
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut.Size = new System.Drawing.Size(218, 26);
            this.Cut.Text = "Cut";
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.Window;
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy.Size = new System.Drawing.Size(218, 26);
            this.Copy.Text = "Copy";
            // 
            // Paste
            // 
            this.Paste.BackColor = System.Drawing.SystemColors.Window;
            this.Paste.Name = "Paste";
            this.Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste.Size = new System.Drawing.Size(218, 26);
            this.Paste.Text = "Paste";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Window;
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete.Size = new System.Drawing.Size(218, 26);
            this.Delete.Text = "Delete";
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll.Size = new System.Drawing.Size(218, 26);
            this.SelectAll.Text = "Select all";
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Find.Size = new System.Drawing.Size(218, 26);
            this.Find.Text = "Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentBox.BackColor = System.Drawing.SystemColors.Window;
            this.ContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContentBox.Location = new System.Drawing.Point(12, 31);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(788, 394);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.Text = "";
            this.ContentBox.WordWrap = false;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 16);
            // 
            // FindBox
            // 
            this.FindBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindBox.ColumnCount = 3;
            this.FindBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.10959F));
            this.FindBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.89041F));
            this.FindBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.FindBox.Controls.Add(this.ButtonFind, 1, 0);
            this.FindBox.Controls.Add(this.FindBoxClose, 2, 0);
            this.FindBox.Controls.Add(this.FindBoxText, 0, 0);
            this.FindBox.Controls.Add(this.FindBoxLabel, 0, 1);
            this.FindBox.Location = new System.Drawing.Point(431, 31);
            this.FindBox.Name = "FindBox";
            this.FindBox.RowCount = 2;
            this.FindBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FindBox.Size = new System.Drawing.Size(357, 64);
            this.FindBox.TabIndex = 3;
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(214, 3);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(49, 38);
            this.ButtonFind.TabIndex = 1;
            this.ButtonFind.Text = "Find";
            this.ButtonFind.UseVisualStyleBackColor = true;
            // 
            // FindBoxClose
            // 
            this.FindBoxClose.Location = new System.Drawing.Point(269, 3);
            this.FindBoxClose.Name = "FindBoxClose";
            this.FindBoxClose.Size = new System.Drawing.Size(55, 38);
            this.FindBoxClose.TabIndex = 3;
            this.FindBoxClose.Text = "Close";
            this.FindBoxClose.UseVisualStyleBackColor = true;
            // 
            // FindBoxText
            // 
            this.FindBoxText.Location = new System.Drawing.Point(3, 3);
            this.FindBoxText.Name = "FindBoxText";
            this.FindBoxText.Size = new System.Drawing.Size(205, 38);
            this.FindBoxText.TabIndex = 0;
            this.FindBoxText.Text = "";
            // 
            // FindBoxLabel
            // 
            this.FindBoxLabel.AutoSize = true;
            this.FindBoxLabel.Location = new System.Drawing.Point(3, 44);
            this.FindBoxLabel.Name = "FindBoxLabel";
            this.FindBoxLabel.Size = new System.Drawing.Size(0, 20);
            this.FindBoxLabel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.10959F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.89041F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AttributeBox
            // 
            this.AttributeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeBox.ColumnCount = 2;
            this.AttributeBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36975F));
            this.AttributeBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.63025F));
            this.AttributeBox.Controls.Add(this.FontAttributeValueBox, 1, 0);
            this.AttributeBox.Controls.Add(this.FontAttributeBox, 0, 0);
            this.AttributeBox.Controls.Add(this.ColorAttributeBox, 0, 3);
            this.AttributeBox.Controls.Add(this.FontSizeAttributeBox, 1, 2);
            this.AttributeBox.Controls.Add(this.SizeAttributeBox, 0, 2);
            this.AttributeBox.Controls.Add(this.FontColorAttributeBox, 1, 3);
            this.AttributeBox.Controls.Add(this.FontStyleAttributeBox, 0, 1);
            this.AttributeBox.Controls.Add(this.FontStyleAttributeValueBox, 1, 1);
            this.AttributeBox.Controls.Add(this.CloseAttributeButtonBox, 1, 4);
            this.AttributeBox.Controls.Add(this.SaveAttributeButtonBox, 0, 4);
            this.AttributeBox.Location = new System.Drawing.Point(431, 113);
            this.AttributeBox.Name = "AttributeBox";
            this.AttributeBox.RowCount = 5;
            this.AttributeBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributeBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttributeBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.AttributeBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.AttributeBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AttributeBox.Size = new System.Drawing.Size(357, 201);
            this.AttributeBox.TabIndex = 4;
            // 
            // FontAttributeValueBox
            // 
            this.FontAttributeValueBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FontAttributeValueBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontAttributeValueBox.FormattingEnabled = true;
            this.FontAttributeValueBox.Location = new System.Drawing.Point(90, 3);
            this.FontAttributeValueBox.Name = "FontAttributeValueBox";
            this.FontAttributeValueBox.Size = new System.Drawing.Size(264, 28);
            this.FontAttributeValueBox.TabIndex = 7;
            // 
            // FontAttributeBox
            // 
            this.FontAttributeBox.AutoSize = true;
            this.FontAttributeBox.Location = new System.Drawing.Point(3, 0);
            this.FontAttributeBox.Name = "FontAttributeBox";
            this.FontAttributeBox.Size = new System.Drawing.Size(45, 20);
            this.FontAttributeBox.TabIndex = 0;
            this.FontAttributeBox.Text = "Font: ";
            // 
            // ColorAttributeBox
            // 
            this.ColorAttributeBox.AutoSize = true;
            this.ColorAttributeBox.Location = new System.Drawing.Point(3, 121);
            this.ColorAttributeBox.Name = "ColorAttributeBox";
            this.ColorAttributeBox.Size = new System.Drawing.Size(52, 20);
            this.ColorAttributeBox.TabIndex = 5;
            this.ColorAttributeBox.Text = "Color: ";
            // 
            // FontSizeAttributeBox
            // 
            this.FontSizeAttributeBox.FormattingEnabled = true;
            this.FontSizeAttributeBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "48",
            "72"});
            this.FontSizeAttributeBox.Location = new System.Drawing.Point(90, 83);
            this.FontSizeAttributeBox.Name = "FontSizeAttributeBox";
            this.FontSizeAttributeBox.Size = new System.Drawing.Size(264, 28);
            this.FontSizeAttributeBox.TabIndex = 8;
            // 
            // SizeAttributeBox
            // 
            this.SizeAttributeBox.AutoSize = true;
            this.SizeAttributeBox.Location = new System.Drawing.Point(3, 80);
            this.SizeAttributeBox.Name = "SizeAttributeBox";
            this.SizeAttributeBox.Size = new System.Drawing.Size(43, 20);
            this.SizeAttributeBox.TabIndex = 1;
            this.SizeAttributeBox.Text = "Size: ";
            // 
            // FontColorAttributeBox
            // 
            this.FontColorAttributeBox.FormattingEnabled = true;
            this.FontColorAttributeBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green"});
            this.FontColorAttributeBox.Location = new System.Drawing.Point(90, 124);
            this.FontColorAttributeBox.Name = "FontColorAttributeBox";
            this.FontColorAttributeBox.Size = new System.Drawing.Size(264, 28);
            this.FontColorAttributeBox.TabIndex = 9;
            // 
            // FontStyleAttributeBox
            // 
            this.FontStyleAttributeBox.AutoSize = true;
            this.FontStyleAttributeBox.Location = new System.Drawing.Point(3, 40);
            this.FontStyleAttributeBox.Name = "FontStyleAttributeBox";
            this.FontStyleAttributeBox.Size = new System.Drawing.Size(79, 20);
            this.FontStyleAttributeBox.TabIndex = 12;
            this.FontStyleAttributeBox.Text = "Font-Style:";
            // 
            // FontStyleAttributeValueBox
            // 
            this.FontStyleAttributeValueBox.FormattingEnabled = true;
            this.FontStyleAttributeValueBox.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic",
            "Underline"});
            this.FontStyleAttributeValueBox.Location = new System.Drawing.Point(90, 43);
            this.FontStyleAttributeValueBox.Name = "FontStyleAttributeValueBox";
            this.FontStyleAttributeValueBox.Size = new System.Drawing.Size(264, 28);
            this.FontStyleAttributeValueBox.TabIndex = 13;
            // 
            // CloseAttributeButtonBox
            // 
            this.CloseAttributeButtonBox.Location = new System.Drawing.Point(90, 161);
            this.CloseAttributeButtonBox.Name = "CloseAttributeButtonBox";
            this.CloseAttributeButtonBox.Size = new System.Drawing.Size(81, 29);
            this.CloseAttributeButtonBox.TabIndex = 11;
            this.CloseAttributeButtonBox.Text = "Close";
            this.CloseAttributeButtonBox.UseVisualStyleBackColor = true;
            // 
            // SaveAttributeButtonBox
            // 
            this.SaveAttributeButtonBox.Location = new System.Drawing.Point(3, 161);
            this.SaveAttributeButtonBox.Name = "SaveAttributeButtonBox";
            this.SaveAttributeButtonBox.Size = new System.Drawing.Size(81, 29);
            this.SaveAttributeButtonBox.TabIndex = 10;
            this.SaveAttributeButtonBox.Text = "Save";
            this.SaveAttributeButtonBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AttributeBox);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad (Bản china)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FindBox.ResumeLayout(false);
            this.FindBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.AttributeBox.ResumeLayout(false);
            this.AttributeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWindows;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.ToolStripMenuItem Undo;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.TableLayoutPanel FindBox;
        private System.Windows.Forms.RichTextBox FindBoxText;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Button FindBoxClose;
        private System.Windows.Forms.Label FindBoxLabel;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel AttributeBox;
        private System.Windows.Forms.Label FontAttributeBox;
        private System.Windows.Forms.Label SizeAttributeBox;
        private System.Windows.Forms.Label ColorAttributeBox;
        private System.Windows.Forms.ComboBox FontAttributeValueBox;
        private System.Windows.Forms.ComboBox FontSizeAttributeBox;
        private System.Windows.Forms.ComboBox FontColorAttributeBox;
        private System.Windows.Forms.Button SaveAttributeButtonBox;
        private System.Windows.Forms.Button CloseAttributeButtonBox;
        private System.Windows.Forms.Label FontStyleAttributeBox;
        private System.Windows.Forms.ComboBox FontStyleAttributeValueBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
