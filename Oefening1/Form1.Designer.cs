namespace Oefening1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BG_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BG_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BG_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_BG_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Font_Small = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Font_Normal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Font_Large = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.formatToolStripMenuItem_Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Exit});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem_File.Text = "File";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem_Exit.Text = "Exit";
            // 
            // formatToolStripMenuItem_Format
            // 
            this.formatToolStripMenuItem_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Color,
            this.toolStripMenuItem_BG_Color,
            this.toolStripMenuItem_Font});
            this.formatToolStripMenuItem_Format.Name = "formatToolStripMenuItem_Format";
            this.formatToolStripMenuItem_Format.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem_Format.Text = "Format";
            // 
            // toolStripMenuItem_Color
            // 
            this.toolStripMenuItem_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Red,
            this.toolStripMenuItem_Green,
            this.toolStripMenuItem_Blue});
            this.toolStripMenuItem_Color.Name = "toolStripMenuItem_Color";
            this.toolStripMenuItem_Color.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItem_Color.Text = "Color";
            // 
            // toolStripMenuItem_Red
            // 
            this.toolStripMenuItem_Red.Name = "toolStripMenuItem_Red";
            this.toolStripMenuItem_Red.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_Red.Text = "Red";
            // 
            // toolStripMenuItem_Green
            // 
            this.toolStripMenuItem_Green.Name = "toolStripMenuItem_Green";
            this.toolStripMenuItem_Green.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_Green.Text = "Green";
            // 
            // toolStripMenuItem_Blue
            // 
            this.toolStripMenuItem_Blue.Name = "toolStripMenuItem_Blue";
            this.toolStripMenuItem_Blue.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_Blue.Text = "Blue";
            // 
            // toolStripMenuItem_BG_Color
            // 
            this.toolStripMenuItem_BG_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_BG_Red,
            this.toolStripMenuItem_BG_Green,
            this.toolStripMenuItem_BG_Blue});
            this.toolStripMenuItem_BG_Color.Name = "toolStripMenuItem_BG_Color";
            this.toolStripMenuItem_BG_Color.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItem_BG_Color.Text = "Background Color";
            // 
            // toolStripMenuItem_BG_Red
            // 
            this.toolStripMenuItem_BG_Red.Name = "toolStripMenuItem_BG_Red";
            this.toolStripMenuItem_BG_Red.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_BG_Red.Text = "Red";
            // 
            // toolStripMenuItem_BG_Green
            // 
            this.toolStripMenuItem_BG_Green.Name = "toolStripMenuItem_BG_Green";
            this.toolStripMenuItem_BG_Green.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_BG_Green.Text = "Green";
            // 
            // toolStripMenuItem_BG_Blue
            // 
            this.toolStripMenuItem_BG_Blue.Name = "toolStripMenuItem_BG_Blue";
            this.toolStripMenuItem_BG_Blue.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem_BG_Blue.Text = "Blue";
            // 
            // toolStripMenuItem_Font
            // 
            this.toolStripMenuItem_Font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Font_Small,
            this.toolStripMenuItem_Font_Normal,
            this.toolStripMenuItem_Font_Large});
            this.toolStripMenuItem_Font.Name = "toolStripMenuItem_Font";
            this.toolStripMenuItem_Font.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItem_Font.Text = "Font";
            // 
            // toolStripMenuItem_Font_Small
            // 
            this.toolStripMenuItem_Font_Small.Name = "toolStripMenuItem_Font_Small";
            this.toolStripMenuItem_Font_Small.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuItem_Font_Small.Text = "Small";
            // 
            // toolStripMenuItem_Font_Normal
            // 
            this.toolStripMenuItem_Font_Normal.Name = "toolStripMenuItem_Font_Normal";
            this.toolStripMenuItem_Font_Normal.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuItem_Font_Normal.Text = "Normal";
            // 
            // toolStripMenuItem_Font_Large
            // 
            this.toolStripMenuItem_Font_Large.Name = "toolStripMenuItem_Font_Large";
            this.toolStripMenuItem_Font_Large.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuItem_Font_Large.Text = "Large";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.MinimumSize = new System.Drawing.Size(800, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem_File;
        private ToolStripMenuItem toolStripMenuItem_Exit;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem formatToolStripMenuItem_Format;
        private ToolStripMenuItem toolStripMenuItem_Color;
        private ToolStripMenuItem toolStripMenuItem_BG_Color;
        private ToolStripMenuItem toolStripMenuItem_Font;
        private ToolStripMenuItem toolStripMenuItem_Red;
        private ToolStripMenuItem toolStripMenuItem_Green;
        private ToolStripMenuItem toolStripMenuItem_Blue;
        private ToolStripMenuItem toolStripMenuItem_BG_Red;
        private ToolStripMenuItem toolStripMenuItem_BG_Green;
        private ToolStripMenuItem toolStripMenuItem_BG_Blue;
        private ToolStripMenuItem toolStripMenuItem_Font_Small;
        private ToolStripMenuItem toolStripMenuItem_Font_Normal;
        private ToolStripMenuItem toolStripMenuItem_Font_Large;
        private TextBox textBox1;
    }
}