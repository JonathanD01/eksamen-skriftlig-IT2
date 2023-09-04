using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Veiledning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Metoden brukes for første og andre bilde
        private void bilde_Fjell1_Click(object sender, MouseEventArgs e)
        {
            lblOverskrift.Text = "Perfekt for nettside";
            lblTekst.Text = "Anbefalt filformat er JPG fordi\nbildet lager et foto med høy\nkvalitet"
                + " som får det til å se\nekstra bra ut. Men JPG filer\nhar også en relativ lav bilde\n"
                + "størrelse som gjør det enklere for\nnettsider å laste inn bilder, slik at \nnettsiden lastes hurtig.";
        }

        // Metoden brukes for siste bilde
        private void bilde_Fjell3_Click(object sender, MouseEventArgs e)
        {
            lblOverskrift.Text = "Perfekt for store reklameskilt";
            lblTekst.Text = "Anbefalt filformat er PNG fordi\nbildet lager et foto med høy\nkvalitet"
                + " som får det til å se\nekstra bra ut. Men PNG filer\nhar kanskje litt høyere bilde\n"
                + "størrelse enn andre formater, men bildet skal\nikke lastes inn på en nettside\nog dermed kan vi velge kvalitet"
                + "\nover ytelse.";
        }
     
    }
}
