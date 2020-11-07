namespace VisualizeWordCounter
{
    partial class WordCountDialog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countWordsFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBoxCounter = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDialogMenuItem,
            this.countWordsFileDialog});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // openFileDialogMenuItem
            // 
            this.openFileDialogMenuItem.Name = "openFileDialogMenuItem";
            this.openFileDialogMenuItem.Size = new System.Drawing.Size(175, 26);
            this.openFileDialogMenuItem.Text = "Open file";
            // 
            // countWordsFileDialog
            // 
            this.countWordsFileDialog.Name = "countWordsFileDialog";
            this.countWordsFileDialog.Size = new System.Drawing.Size(175, 26);
            this.countWordsFileDialog.Text = "Count words";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 46);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(390, 424);
            this.textBox.TabIndex = 1;
            // 
            // listBoxCounter
            // 
            this.listBoxCounter.FormattingEnabled = true;
            this.listBoxCounter.ItemHeight = 20;
            this.listBoxCounter.Location = new System.Drawing.Point(409, 46);
            this.listBoxCounter.Name = "listBoxCounter";
            this.listBoxCounter.Size = new System.Drawing.Size(379, 424);
            this.listBoxCounter.TabIndex = 2;
            // 
            // WordCountDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.listBoxCounter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WordCountDialog";
            this.Text = "Word counter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileDialogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countWordsFileDialog;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBoxCounter;
    }
}

