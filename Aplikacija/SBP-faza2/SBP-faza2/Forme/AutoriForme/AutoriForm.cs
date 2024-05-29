using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme.AutoriForme
{
    public partial class AutoriForm : Form
    {
        public AutoriForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajAutoraForm dodajAutoraForma = new DodajAutoraForm();
            dodajAutoraForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajAutoraForm azurirajAutoraForma = new AzurirajAutoraForm();
            azurirajAutoraForma.ShowDialog(this);
        }
    }
}