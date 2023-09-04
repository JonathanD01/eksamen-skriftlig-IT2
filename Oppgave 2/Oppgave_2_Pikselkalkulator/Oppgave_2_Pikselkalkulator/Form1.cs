using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pikselkalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegnPiksler_Click(object sender, EventArgs e)
        {
            int bredde, høyde;

            bool successParseBredde = int.TryParse(txtBoxBredde.Text, out bredde);
            bool successParseHøyde = int.TryParse(txtBoxHøyde.Text, out høyde);

            if (!successParseBredde || !successParseHøyde)
            {
                MessageBox.Show("Skriv inn gyldige tall og prøv på nytt", "Ugyldige tall");
                return;
            }
            else if (bredde <= 0 || høyde <= 0)
            {
                MessageBox.Show("Både bredden og høyden må være større enn 0", "Ugyldige tall");
                return;
            }
            else if (bredde > 1920)
            {
                MessageBox.Show("Bredden kan ikke være større enn 1920 piksler", "Ulovlig bredde");
                return;
            }

            int piksler = bredde * høyde;
            double megaPiksler = (double)piksler / 1000000;


            lblUtskrift.Text = "Antall piksler: " + piksler;
            lblUtskrift.Text += "\nAntall megapiksler: " + megaPiksler.ToString("0.#");

            // Visning av korrekt bilde

            // Stående bilde
            if (bredde < høyde)
                bilde.Image = Properties.Resources.staende;

            // Liggende bilde
            else if (bredde > høyde)
                bilde.Image = Properties.Resources.liggende;

            // Kvadratisk bilde
            else
                bilde.Image = Properties.Resources.kvadratisk;



        }
    }
}
