using NHibernate.Linq.Functions;
using SBP_faza2.Forme.ClanciForme;
using SBP_faza2.Forme.RadoviForme;
using SBP_faza2.Forme.TeorijskiProjektiForme;
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
    public partial class TeorijskiProjektiForm : Form
    {
        public TeorijskiProjektiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajTeorijskiProjekatForm teorijskiProjekatForma = new DodajTeorijskiProjekatForm();
            teorijskiProjekatForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajTeorijskiProjekatForm azurirajTeorijskiProjekatForma = new AzurirajTeorijskiProjekatForm();
            azurirajTeorijskiProjekatForma.ShowDialog(this);
        }

        private void buttonKnjige_Click(object sender, EventArgs e)
        {
            KnjigeForm knjigeForm = new KnjigeForm();
            knjigeForm.ShowDialog(this);
        }

        private void buttonCasopisi_Click(object sender, EventArgs e)
        {
            ClanciForm clanciForm = new ClanciForm();
            clanciForm.ShowDialog(this);
        }

        private void buttonRadovi_Click(object sender, EventArgs e)
        {
            RadoviForm radoviForma = new RadoviForm();
            radoviForma.ShowDialog(this);
        }
    }
}