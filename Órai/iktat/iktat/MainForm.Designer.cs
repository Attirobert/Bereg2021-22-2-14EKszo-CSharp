
namespace iktat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyFelhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókTáblaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iktatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelekListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználókToolStripMenuItem,
            this.levelekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egyFelhasználóToolStripMenuItem,
            this.felhasználókTáblaToolStripMenuItem});
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            // 
            // levelekToolStripMenuItem
            // 
            this.levelekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iktatásToolStripMenuItem,
            this.levelekListaToolStripMenuItem});
            this.levelekToolStripMenuItem.Name = "levelekToolStripMenuItem";
            this.levelekToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.levelekToolStripMenuItem.Text = "Levelek";
            // 
            // egyFelhasználóToolStripMenuItem
            // 
            this.egyFelhasználóToolStripMenuItem.Name = "egyFelhasználóToolStripMenuItem";
            this.egyFelhasználóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.egyFelhasználóToolStripMenuItem.Text = "Egy felhasználó";
            this.egyFelhasználóToolStripMenuItem.Click += new System.EventHandler(this.egyFelhasználóToolStripMenuItem_Click);
            // 
            // felhasználókTáblaToolStripMenuItem
            // 
            this.felhasználókTáblaToolStripMenuItem.Name = "felhasználókTáblaToolStripMenuItem";
            this.felhasználókTáblaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.felhasználókTáblaToolStripMenuItem.Text = "Felhasználók tábla";
            this.felhasználókTáblaToolStripMenuItem.Click += new System.EventHandler(this.felhasználókTáblaToolStripMenuItem_Click);
            // 
            // iktatásToolStripMenuItem
            // 
            this.iktatásToolStripMenuItem.Name = "iktatásToolStripMenuItem";
            this.iktatásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iktatásToolStripMenuItem.Text = "Iktatás";
            // 
            // levelekListaToolStripMenuItem
            // 
            this.levelekListaToolStripMenuItem.Name = "levelekListaToolStripMenuItem";
            this.levelekListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.levelekListaToolStripMenuItem.Text = "Levelek lista";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Iktatás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyFelhasználóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókTáblaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iktatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelekListaToolStripMenuItem;
    }
}

