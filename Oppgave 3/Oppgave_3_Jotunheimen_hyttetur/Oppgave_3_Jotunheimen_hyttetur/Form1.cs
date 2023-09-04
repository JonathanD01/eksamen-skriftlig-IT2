using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hytte
{
    public partial class Form1 : Form
    {

        private int[,] hytteTabell;
        private const int rad = 7;
        private const int kol = 7;

        public Form1()
        {
            InitializeComponent();

            // Gjem objekter
            visNesteObjekter(false);
            visSisteObjekter(false);

            hytteTabell = new int[7, 7]
            {
                {0, 22, 14, 0, 0, 0, 0},
                {22, 0, 18, 0, 0, 17, 0},
                {14, 18, 0, 10, 0, 0, 0},
                {0, 0, 10, 0, 19, 24, 16},
                {0, 0, 0, 19, 0, 15, 11},
                {0, 17, 0, 24, 15, 0, 0},
                {0, 0, 0, 16, 11, 0, 0}
            };

            // Last inn alle hytter i comboBox
            for (int i = 0; i < rad; i++)
                cbBoxHytter.Items.Add(hytteNavnFraTabellRad(i));

        }

        // Første fase
        private void cbBoxHytter_SelectedValueChanged(object sender, EventArgs e)
        {
            // Vi må huske og fjerne gammel inndata fra den nederste og siste nedtrekkslisten
            cbBoxNesteHytter.ResetText();
            cbBoxNesteHytter.Items.Clear();
            
            cbBoxSisteHytter.ResetText();
            cbBoxSisteHytter.Items.Clear();

            // Last inn neste ledige hytter. Vi legger til alle hytter hvor
            // kilometer > 0

            visNesteObjekter(true);

            string startHytteNavn = cbBoxHytter.Text;

            int tabellRad = radFraHytteNavn(startHytteNavn);

            for (int i = 0; i < kol; i++)
            {
                int km = hytteTabell[tabellRad, i];

                if (km > 0)
                    cbBoxNesteHytter.Items.Add(hytteNavnFraTabellRad(i));
            }
        }

        // Andre fase
        private void cbBoxNesteHytte_SelectedValueChanged(object sender, EventArgs e)
        {
            // Vi må huske og fjerne gammel inndata fra den nederste og nedtrekkslisten
            cbBoxSisteHytter.ResetText();
            cbBoxSisteHytter.Items.Clear();

            // Nå må vi fjerne den forrige hytten fra tabellen vår

            visSisteObjekter(true);

            string startHytteNavn = cbBoxHytter.Text;
            string nesteHytteNavn = cbBoxNesteHytter.Text;

            int tabellRad = radFraHytteNavn(startHytteNavn);
            int hoppOverRad = radFraHytteNavn(nesteHytteNavn);

            for (int i = 0; i < kol; i++)
            {
                int km = hytteTabell[tabellRad, i];

                if (km > 0 && i != hoppOverRad)
                {
                    // Her kan vi sjekke hvilke ruter som er gyldige
                    // Dette lar brukeren bare velge mellom gyldige ruter

                    string hytteNavn = hytteNavnFraTabellRad(i);
                    int tabellKolonneFraHytte = radFraHytteNavn(hytteNavn);
                    int nesteKm = hytteTabell[hoppOverRad, tabellKolonneFraHytte];
                    
                    if (nesteKm > 0 )
                        cbBoxSisteHytter.Items.Add(hytteNavn);
                }
            }

            // Sjekk om den siste nedtrekkslisten er tom
            if (cbBoxSisteHytter.Items.Count == 0)
            {
                visSisteObjekter(false);
                MessageBox.Show("Ingen gyldige ruter fra " + nesteHytteNavn + "."
                    + "\nVelg en annen rute og prøv igjen.", "Ugyldig rute");
                return;
            }
        }

        // Siste fase
        private void cbBoxSisteHytte_SelectedValueChanged(object sender, EventArgs e)
        {

            string førsteRute = cbBoxHytter.Text;
            string nesteRute = cbBoxNesteHytter.Text;
            string sisteRute = cbBoxSisteHytter.Text;

            // Kalkuler antall km
            int tabellRad = radFraHytteNavn(førsteRute);
            int kolonneRad = radFraHytteNavn(nesteRute);
            int sisteKolonneRad = radFraHytteNavn(sisteRute);

            int førsteRuteKm = hytteTabell[tabellRad, kolonneRad];
            int sisteRuteKm = hytteTabell[kolonneRad, sisteKolonneRad];
            int totalKm = førsteRuteKm + sisteRuteKm;

            lblRuteOverskrift.Text = "Din rute: " + førsteRute + " - " + nesteRute + " - " + sisteRute;

            lblRuteTekst.Text = "Første rute: Fra " + førsteRute + " til " + nesteRute + " er det " + førsteRuteKm + "km";
            lblRuteTekst.Text += "\nSiste rute: Fra " + nesteRute + " til " + sisteRute + " er det " + sisteRuteKm + "km";
            
            lblRuteOppsummering.Text = "Den totale reisen er på " + totalKm + "km";
        }

        // Finn navn på hytte ved oppgit rad
        private string hytteNavnFraTabellRad(int rad)
        {
            if (rad == 0) return "Gjendesheim";
            if (rad == 1) return "Glitterheim";
            if (rad == 2) return "Memurubu";
            if (rad == 3) return "Gjendebu";
            if (rad == 4) return "Leirvassbu";
            if (rad == 5) return "Spiterstulen";
            else return "Olavsbu";
        }

        // Finn raden ved oppgit navnet til hytten
        private int radFraHytteNavn(string hytteNavn)
        {
            if (hytteNavn == "Gjendesheim") return 0;
            if (hytteNavn == "Glitterheim") return 1;
            if (hytteNavn == "Memurubu") return 2;
            if (hytteNavn == "Gjendebu") return 3;
            if (hytteNavn == "Leirvassbu") return 4;
            if (hytteNavn == "Spiterstulen") return 5;
            else return 6;
        }

        private void visNesteObjekter(bool value)
        {
            // For å gjøre programmet mer vennlig kan fjerne de siste
            // objektene dersom brukeren vil velge en ny rute
            if (cbBoxNesteHytter.Text == "")
                visSisteObjekter(false);
            
            
            if (value)
            {
                lblRuteOverskrift.ResetText();
                lblRuteTekst.ResetText();
                lblRuteOppsummering.ResetText();

                lblNesteHytte.Show();
                cbBoxNesteHytter.Show();
                cbBoxNesteHytter.Items.Clear();
                
            }
            else
            {
                lblNesteHytte.Hide();
                cbBoxNesteHytter.Hide();
            }
        }

        private void visSisteObjekter(bool value)
        {
            if (lblRuteOverskrift.Text != "")
            {
                lblRuteOverskrift.ResetText();
                lblRuteTekst.ResetText();
                lblRuteOppsummering.ResetText();
            }

            if (value)
            {
                lblSisteHytte.Show();
                cbBoxSisteHytter.Show();
                cbBoxSisteHytter.Items.Clear();
            }
            else
            {
                lblSisteHytte.Hide();
                cbBoxSisteHytter.Hide();
            }
        }
    }
}
