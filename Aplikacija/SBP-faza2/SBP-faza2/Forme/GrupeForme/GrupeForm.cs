using SBP_faza2.Forme.IzvestajiForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme.GrupeForme
{
    public partial class GrupeForm : Form
    {
        public GrupeForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajGrupuForm dodajGrupuForma = new DodajGrupuForm();
            dodajGrupuForma.ShowDialog();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajGrupuForm azurirajGrupuForma = new AzurirajGrupuForm();
            azurirajGrupuForma.ShowDialog(this);
        }

        private void buttonClanoviGrupe_Click(object sender, EventArgs e)
        {
            StudentiForm studentiForma = new StudentiForm();
            studentiForma.ShowDialog();
        }

        private void buttonIzvestaji_Click(object sender, EventArgs e)
        {
            IzvestajiForm izvestajiForma = new IzvestajiForm();
            izvestajiForma.ShowDialog();
        }
    }
}