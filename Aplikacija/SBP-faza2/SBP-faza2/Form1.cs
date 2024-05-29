using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using SBP_faza2.Forme;
using SBP_faza2.Forme.PredmetiForme;

namespace SBP_faza2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVratiStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                Student s = session!.Load<Student>(4);

                MessageBox.Show(s.LicnoIme + " " + s.ImeRoditelja + " " + s.Prezime);

                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonStudenti_Click(object sender, EventArgs e)
        {
            StudentiForm studentiForma = new StudentiForm();
            studentiForma.ShowDialog(this);
        }

        private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
        {
            TeorijskiProjektiForm teorijskiProjektiForma = new TeorijskiProjektiForm();
            teorijskiProjektiForma.ShowDialog(this);
        }

        private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
        {
            PrakticniProjektiForm prakticniProjektiForma = new PrakticniProjektiForm();
            prakticniProjektiForma.ShowDialog(this);
        }

        private void buttonPredmeti_Click(object sender, EventArgs e)
        {
            PredmetiForm predmetiForma = new PredmetiForm();
            predmetiForma.ShowDialog(this);
        }
    }
}