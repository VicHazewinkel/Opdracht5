namespace Oefening3
{
    partial class SpelenMetKleuren
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
            this.ToolStripMenuItem_Toevoegen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Verwijderen = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Toevoegen,
            this.ToolStripMenuItem_Verwijderen,
            this.brushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Toevoegen
            // 
            this.ToolStripMenuItem_Toevoegen.Name = "ToolStripMenuItem_Toevoegen";
            this.ToolStripMenuItem_Toevoegen.Size = new System.Drawing.Size(100, 24);
            this.ToolStripMenuItem_Toevoegen.Text = "Toevoegen ";
            this.ToolStripMenuItem_Toevoegen.Click += new System.EventHandler(this.ToolStripMenuItem_Toevoegen_Click);
            // 
            // ToolStripMenuItem_Verwijderen
            // 
            this.ToolStripMenuItem_Verwijderen.Name = "ToolStripMenuItem_Verwijderen";
            this.ToolStripMenuItem_Verwijderen.Size = new System.Drawing.Size(105, 24);
            this.ToolStripMenuItem_Verwijderen.Text = "Verwijderen ";
            this.ToolStripMenuItem_Verwijderen.Click += new System.EventHandler(this.ToolStripMenuItem_Verwijderen_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // SpelenMetKleuren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpelenMetKleuren";
            this.Text = "Spelen met kleuren";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_Toevoegen;
        private ToolStripMenuItem ToolStripMenuItem_Verwijderen;
        private ToolStripMenuItem brushToolStripMenuItem;
    }
}