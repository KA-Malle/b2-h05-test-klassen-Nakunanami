using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaratie private variabelen
        private Speler speler1;
        private Speler speler2;
        private Random will = new Random();

        // Bij laden formulier maak beide spelers instantie aan
        private void Form1_Load(object sender, EventArgs e)
        {
            // Spelers aanmaken
            // Speler(string naam, int gezondheid, int positieX, int positieY, bool isLevend)

            speler1 = new Speler("Speler 1", 100, will.Next(1, 501), will.Next(1, 501), true);
            speler2 = new Speler("Speler 2", 100, will.Next(1, 501), will.Next(1, 501), true);

            // Gezondheid tonen 
            labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid.ToString();
            labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid.ToString();
        }

        // Speler 1 valt speler 2 aan, verlaag gezondheid speler 2
        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            speler2.OntvangSchade(will.Next(1, 11));

            // Gezondheid tonen 
            labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid.ToString();

            // Als speler dood is toon melding
            if (!speler2.IsLevend)
            {
                MessageBox.Show("Speler 2 is dood", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }

        // Speler 2 valt speler 1 aan, verlaag gezondheid speler 1
        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            speler1.OntvangSchade(will.Next(1, 11));
            // Gezondheid tonen 
            labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid.ToString();

            // Als speler dood is toon melding
            if (!speler1.IsLevend)
            {
                MessageBox.Show("Speler 1 is dood", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }

        // Genees gezondheid van speler 1
        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            speler1.Genees(will.Next(1, 6));
            // Gezondheid tonen 
            labelGezondheid1.Text = "Gezondheid: " + speler1.Gezondheid.ToString();

        }

        // Genees gezondheid van speler 2
        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            speler2.Genees(will.Next(1, 6));

            // Gezondheid tonen 
            labelGezondheid2.Text = "Gezondheid: " + speler2.Gezondheid.ToString();

        }

        // Tonen van positie
        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Speler 1: (" + speler1.PositieX + ", " + speler1.PositieY + ")\n" +
                "Speler 2: (" + speler2.PositieX + ", " + speler2.PositieY + ")", "", MessageBoxButtons.OK, MessageBoxIcon.None);




        }
    }
}
