using SBP_faza2.Forme.KnjigeForme;
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
    public partial class KnjigeForm : Form
    {
        public KnjigeForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajKnjiguForm dodajKnjiguForma = new DodajKnjiguForm();
            dodajKnjiguForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajKnjiguForm azurirajKnjiguForma = new AzurirajKnjiguForm();
            azurirajKnjiguForma.ShowDialog(this);
        }
    }
}