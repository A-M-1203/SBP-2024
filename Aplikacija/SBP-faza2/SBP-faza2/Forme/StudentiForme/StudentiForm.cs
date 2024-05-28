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
    public partial class StudentiForm : Form
    {
        public StudentiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajStudentaForm dodajStudentaForma = new DodajStudentaForm();
            dodajStudentaForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajStudentaForm azurirajStudentaForma = new AzurirajStudentaForm();
            azurirajStudentaForma.ShowDialog(this);
        }

        private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
        {
            PrakticniProjektiForm prakticniProjektiForm = new PrakticniProjektiForm();
            prakticniProjektiForm.ShowDialog(this);
        }

        private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
        {
            TeorijskiProjektiForm teorijskiProjektiForm = new TeorijskiProjektiForm();
            teorijskiProjektiForm.ShowDialog(this);
        }
    }
}