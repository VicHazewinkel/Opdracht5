namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // exit

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // font color

        private void toolStripMenuItem_Red_Click(object sender, EventArgs e)
        {
            TextInput.ForeColor = Color.Red;
        }

        private void toolStripMenuItem_Green_Click(object sender, EventArgs e)
        {
            TextInput.ForeColor = Color.Green;  
        }

        private void toolStripMenuItem_Blue_Click(object sender, EventArgs e)
        {
            TextInput.ForeColor = Color.Blue; 
        }

        // BG color

        private void toolStripMenuItem_BG_Red_Click(object sender, EventArgs e)
        {
            TextInput.BackColor = Color.Red; 
        }

        private void toolStripMenuItem_BG_Green_Click(object sender, EventArgs e)
        {
            TextInput.BackColor = Color.Green;
        }

        private void toolStripMenuItem_BG_Blue_Click(object sender, EventArgs e)
        {
            TextInput.BackColor = Color.Blue; 
        }

        // Font Size

        private void toolStripMenuItem_Font_Small_Click(object sender, EventArgs e)
        {
            TextInput.Font = Font = new Font(TextInput.Font.Name, 4, TextInput.Font.Style, TextInput.Font.Unit); 
        }

        private void toolStripMenuItem_Font_Normal_Click(object sender, EventArgs e)
        {
            TextInput.Font = Font = new Font(TextInput.Font.Name, 11, TextInput.Font.Style, TextInput.Font.Unit);
        }

        private void toolStripMenuItem_Font_Large_Click(object sender, EventArgs e)
        {
            TextInput.Font = Font = new Font(TextInput.Font.Name, 18, TextInput.Font.Style, TextInput.Font.Unit);
        }
    }
}