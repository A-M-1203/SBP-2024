using SBP_faza2.Forme.IzvestajiForme;
using SBP_faza2.Forme.PrakticniProjektiForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme
{
    public partial class PrakticniProjektiForm : Form
    {
        public PrakticniProjektiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajPrakticniProjekatForm dodajPrakticniProjekatForma = new DodajPrakticniProjekatForm();
            dodajPrakticniProjekatForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajPrakticniProjekatForm azurirajPrakticniProjekatForma = new AzurirajPrakticniProjekatForm();
            azurirajPrakticniProjekatForma.ShowDialog(this);
        }

        private void buttonIzvestaji_Click(object sender, EventArgs e)
        {
            IzvestajiForm izvestajiForma = new IzvestajiForm();
            izvestajiForma.ShowDialog();
        }
    }
}