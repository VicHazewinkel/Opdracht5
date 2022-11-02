namespace Oefening2
{
    partial class Nieuw
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
            this.label2 = new System.Windows.Forms.Label();
            this.Button_NieuwGetal = new System.Windows.Forms.Button();
            this.listBox_Getallen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Gemiddelde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "dialoogvenster ";
            // 
            // Button_NieuwGetal
            // 
            this.Button_NieuwGetal.Location = new System.Drawing.Point(29, 52);
            this.Button_NieuwGetal.Name = "Button_NieuwGetal";
            this.Button_NieuwGetal.Size = new System.Drawing.Size(164, 29);
            this.Button_NieuwGetal.TabIndex = 3;
            this.Button_NieuwGetal.Text = "NieuwGetal";
            this.Button_NieuwGetal.UseVisualStyleBackColor = true;
            this.Button_NieuwGetal.Click += new System.EventHandler(this.Button_NieuwGetal_Click);
            // 
            // listBox_Getallen
            // 
            this.listBox_Getallen.FormattingEnabled = true;
            this.listBox_Getallen.ItemHeight = 20;
            this.listBox_Getallen.Location = new System.Drawing.Point(29, 111);
            this.listBox_Getallen.Name = "listBox_Getallen";
            this.listBox_Getallen.Size = new System.Drawing.Size(150, 104);
            this.listBox_Getallen.TabIndex = 4;
            this.listBox_Getallen.SelectedIndexChanged += new System.EventHandler(this.listBox_Getallen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gemiddelde:";
            // 
            // label_Gemiddelde
            // 
            this.label_Gemiddelde.AutoSize = true;
            this.label_Gemiddelde.Location = new System.Drawing.Point(351, 111);
            this.label_Gemiddelde.Name = "label_Gemiddelde";
            this.label_Gemiddelde.Size = new System.Drawing.Size(37, 20);
            this.label_Gemiddelde.TabIndex = 6;
            this.label_Gemiddelde.Text = ". . . . ";
            // 
            // Nieuw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Gemiddelde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Getallen);
            this.Controls.Add(this.Button_NieuwGetal);
            this.Controls.Add(this.label2);
            this.Name = "Nieuw";
            this.Text = "Nieuw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button Button_NieuwGetal;
        private ListBox listBox_Getallen;
        private Label label1;
        private Label label_Gemiddelde;
    }
}