
namespace ChecksumProgram
{
    partial class ChecksumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChecksumForm));
            this.fileCountLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.extensionListBox = new System.Windows.Forms.ListBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algo1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.algo2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.AutoSize = true;
            this.fileCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileCountLabel.Location = new System.Drawing.Point(0, 0);
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(130, 20);
            this.fileCountLabel.TabIndex = 2;
            this.fileCountLabel.Text = "File Count ([TBD]):";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(10, 361);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 29);
            this.progressBar.TabIndex = 4;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(0, 4);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(184, 20);
            this.progressLabel.TabIndex = 5;
            this.progressLabel.Text = "Ready to Calculate (SHA1)";
            // 
            // calculateButton
            // 
            this.calculateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.calculateButton.Location = new System.Drawing.Point(295, 0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 28);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Checksum";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // extensionListBox
            // 
            this.extensionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionListBox.FormattingEnabled = true;
            this.extensionListBox.ItemHeight = 20;
            this.extensionListBox.Location = new System.Drawing.Point(0, 30);
            this.extensionListBox.Name = "extensionListBox";
            this.extensionListBox.ScrollAlwaysVisible = true;
            this.extensionListBox.Size = new System.Drawing.Size(150, 245);
            this.extensionListBox.TabIndex = 7;
            this.extensionListBox.SelectedIndexChanged += new System.EventHandler(this.ExtensionListBox_SelectedIndexChanged);
            // 
            // fileListBox
            // 
            this.fileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.HorizontalScrollbar = true;
            this.fileListBox.ItemHeight = 20;
            this.fileListBox.Location = new System.Drawing.Point(0, 30);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.ScrollAlwaysVisible = true;
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.fileListBox.Size = new System.Drawing.Size(360, 245);
            this.fileListBox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.algorithmStripMenuItem,
            this.aboutStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openFileMenuItem,
            this.openFolderMenu,
            this.toolStripSeparator,
            this.exportMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(307, 26);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(307, 26);
            this.openFileMenuItem.Text = "&Open File";
            this.openFileMenuItem.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // openFolderMenu
            // 
            this.openFolderMenu.Name = "openFolderMenu";
            this.openFolderMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openFolderMenu.Size = new System.Drawing.Size(307, 26);
            this.openFolderMenu.Text = "&Open Folder";
            this.openFolderMenu.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(304, 6);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportMenuItem.Size = new System.Drawing.Size(307, 26);
            this.exportMenuItem.Text = "&Export as Text Document";
            this.exportMenuItem.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // algorithmStripMenuItem
            // 
            this.algorithmStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algo1MenuItem,
            this.toolStripSeparator1,
            this.algo2MenuItem});
            this.algorithmStripMenuItem.Name = "algorithmStripMenuItem";
            this.algorithmStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.algorithmStripMenuItem.Text = "&Algorithm";
            // 
            // algo1MenuItem
            // 
            this.algo1MenuItem.Checked = true;
            this.algo1MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.algo1MenuItem.Name = "algo1MenuItem";
            this.algo1MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.algo1MenuItem.Size = new System.Drawing.Size(294, 26);
            this.algo1MenuItem.Text = "&SHA1 (Recommended)";
            this.algo1MenuItem.Click += new System.EventHandler(this.Algo1MenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // algo2MenuItem
            // 
            this.algo2MenuItem.Name = "algo2MenuItem";
            this.algo2MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.algo2MenuItem.Size = new System.Drawing.Size(294, 26);
            this.algo2MenuItem.Text = "MD5";
            this.algo2MenuItem.Click += new System.EventHandler(this.Algo2MenuItem_Click);
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutStripMenuItem.Text = "A&bout";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.AboutStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(530, 28);
            this.panel1.MaximumSize = new System.Drawing.Size(10, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 372);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.MaximumSize = new System.Drawing.Size(10, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 372);
            this.panel2.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(10, 141);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(161, 176);
            this.panel11.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(10, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 59);
            this.panel5.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 28);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 10);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 390);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 10);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 10);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.calculateButton);
            this.panel6.Controls.Add(this.progressLabel);
            this.panel6.Controls.Add(this.cancelButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 323);
            this.panel6.MaximumSize = new System.Drawing.Size(0, 28);
            this.panel6.MinimumSize = new System.Drawing.Size(520, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 28);
            this.panel6.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(445, 0);
            this.cancelButton.MaximumSize = new System.Drawing.Size(75, 28);
            this.cancelButton.MinimumSize = new System.Drawing.Size(75, 28);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 351);
            this.panel8.MaximumSize = new System.Drawing.Size(0, 10);
            this.panel8.MinimumSize = new System.Drawing.Size(0, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(520, 10);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(10, 313);
            this.panel9.MaximumSize = new System.Drawing.Size(0, 10);
            this.panel9.MinimumSize = new System.Drawing.Size(0, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 10);
            this.panel9.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.fileListBox);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 38);
            this.panel7.MinimumSize = new System.Drawing.Size(360, 275);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(360, 275);
            this.panel7.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.fileCountLabel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.MaximumSize = new System.Drawing.Size(0, 30);
            this.panel10.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(360, 30);
            this.panel10.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.extensionListBox);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(380, 38);
            this.panel12.MaximumSize = new System.Drawing.Size(150, 0);
            this.panel12.MinimumSize = new System.Drawing.Size(150, 275);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(150, 275);
            this.panel12.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.extensionLabel);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.MaximumSize = new System.Drawing.Size(0, 30);
            this.panel13.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(150, 30);
            this.panel13.TabIndex = 9;
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.extensionLabel.Location = new System.Drawing.Point(0, 0);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(85, 20);
            this.extensionLabel.TabIndex = 8;
            this.extensionLabel.Text = "Extensions: ";
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(370, 38);
            this.panel14.MaximumSize = new System.Drawing.Size(10, 0);
            this.panel14.MinimumSize = new System.Drawing.Size(10, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 275);
            this.panel14.TabIndex = 18;
            // 
            // ChecksumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 400);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(558, 447);
            this.Name = "ChecksumForm";
            this.Text = "Selected Path: [TBD] - FroggyCat\'s Checksum Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fileCountLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox extensionListBox;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStripMenuItem algorithmStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algo1MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem algo2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
    }
}

