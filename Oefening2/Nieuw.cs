using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Nieuw : Form
    {
        public Nieuw()
        {
            InitializeComponent();
        }

        private void Button_NieuwGetal_Click(object sender, EventArgs e)
        {
            string GetalText = Interaction.InputBox("Geef een Getal" , "Getal"); 
            try
            {
                int GetalInt = Convert.ToInt32(GetalText);
                            listBox_Getallen.Items.Add(GetalInt);

                            double Totaal = 0; 

                            foreach(int Getal in listBox_Getallen.Items) 
                            {
                                Totaal += Getal; 
                            }

                            try
                            {
                                label_Gemiddelde.Text = Convert.ToString(Totaal / listBox_Getallen.Items.Count); 
                            }
                            catch
                            {
                                label_Gemiddelde.Text = ". . ."; 
                            }
            }
            catch
            {
                // indien geen Int 
            }
            
            
        }

        private void listBox_Getallen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
