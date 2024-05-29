using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme.IzvestajiForme
{
    public partial class IzvestajiForm : Form
    {
        public IzvestajiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajIzvestajForm dodajIzvestajForma = new DodajIzvestajForm();
            dodajIzvestajForma.ShowDialog();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajIzvestajForm azurirajIzvestajForma = new AzurirajIzvestajForm();
            azurirajIzvestajForma.ShowDialog();
        }
    }
}