namespace PictureBoxApp
{
    partial class MainForm
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.pbPictureDisplay = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            this.msMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.flushToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // flushToolStripMenuItem
            // 
            this.flushToolStripMenuItem.Name = "flushToolStripMenuItem";
            this.flushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flushToolStripMenuItem.Text = "Wyczyść";
            this.flushToolStripMenuItem.Click += new System.EventHandler(this.flushToolStripMenuItem_Click);
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.Filter = "Obrazy|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif|Wszystkie pliki|*.*";
            // 
            // pbPictureDisplay
            // 
            this.pbPictureDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.pbPictureDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureDisplay.Location = new System.Drawing.Point(0, 24);
            this.pbPictureDisplay.Name = "pbPictureDisplay";
            this.pbPictureDisplay.Size = new System.Drawing.Size(800, 426);
            this.pbPictureDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPictureDisplay.TabIndex = 1;
            this.pbPictureDisplay.TabStop = false;
            this.pbPictureDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPictureDisplay_Paint);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPictureDisplay);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "MainForm";
            this.Text = "Wyświetlacz zdjęć";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flushToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.PictureBox pbPictureDisplay;
    }
}

