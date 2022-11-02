using System.Drawing;

namespace Oefening3
{
    public partial class SpelenMetKleuren : Form
    {
        private List<Rectangle> rechthoeken = new List<Rectangle>();
        public SpelenMetKleuren()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Toevoegen_Click(object sender, EventArgs e)
        {
            

            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Rectangle rechthoek = new Rectangle(0, 0, this.Size.Width, this.Size.Height); 
            rechthoeken.Add(rechthoek); 
            graphics.FillRectangle(myBrush, rechthoek);
            
        }

        private void ToolStripMenuItem_Verwijderen_Click(object sender, EventArgs e)
        {
            
            rechthoeken.RemoveAt(rechthoeken.Count - 1);
            System.Drawing.Graphics updateGraphics = this.CreateGraphics();
            updateGraphics.Clear(System.Drawing.Color.Black);
        }
    }
}