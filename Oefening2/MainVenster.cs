namespace Oefening2
{
    public partial class MainVenster : Form
    {
        public MainVenster()
        {
            InitializeComponent();
        }

        private void nieuwMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nieuw formulier = new Nieuw();
            try
            {
                formulier.MdiParent = this;
            }
            catch
            {
                Console.WriteLine(); 
            }
            
            formulier.Show(); 
        }
    }
}