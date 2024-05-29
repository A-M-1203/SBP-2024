using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme.PredmetiForme
{
    public partial class PredmetiForm : Form
    {
        public PredmetiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajPredmetForm dodajPredmetForma = new DodajPredmetForm();
            dodajPredmetForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajPredmetForm azurirajPredmetForma = new AzurirajPredmetForm();
            azurirajPredmetForma.ShowDialog(this);
        }

        private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
        {
            PrakticniProjektiForm prakticniProjektiForma = new PrakticniProjektiForm();
            prakticniProjektiForma.ShowDialog(this);
        }

        private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
        {
            TeorijskiProjektiForm teorijskiProjektiForma = new TeorijskiProjektiForm();
            teorijskiProjektiForma.ShowDialog(this);
        }
    }
}