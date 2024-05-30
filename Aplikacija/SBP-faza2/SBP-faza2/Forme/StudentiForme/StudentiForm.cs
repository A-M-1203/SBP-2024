using FluentNHibernate.Conventions;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using SBP_faza2.Forme.GrupeForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

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
            AzurirajStudentaForm azurirajStudentaForma = new AzurirajStudentaForm(listViewStudenti.SelectedItems[0]);
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

        private void buttonGrupe_Click(object sender, EventArgs e)
        {
            GrupeForm grupeForma = new GrupeForm();
            grupeForma.ShowDialog();
        }

        private void StudentiForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IQuery query = session.CreateQuery("select s.Id, s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer from Student as s");
                        IList<object[]> studenti = query.List<object[]>();

                        if (studenti.Any())
                        {
                            foreach (object[] s in studenti)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] { s[0].ToString()!, (string)s[1], (string)s[2], (string)s[3], (string)s[4], (string)s[5] });
                                listViewStudenti.Items.Add(listViewItem);
                            }

                            listViewStudenti.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom otvaranja konekcije");
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void listViewStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudenti.SelectedIndices.Count == 1)
            {
                buttonAzuriraj.Enabled = true;
                buttonObrisiStudenta.Enabled = true;
                buttonPrakticniProjekti.Enabled = true;
                buttonTeorijskiProjekti.Enabled = true;
                buttonGrupe.Enabled = true;
            }
        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    int id = int.Parse(listViewStudenti.SelectedItems[0].SubItems[0].Text);
                    Student student = session.Load<Student>(id);

                    session.Delete(student);
                    session.Flush();

                    session.Close();

                    MessageBox.Show("Student uspešno obrisan");
                }
                else
                {
                    MessageBox.Show("Greška prilikom otvaranja konekcije");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void StudentiForm_Activated(object sender, EventArgs e)
        {
            buttonAzuriraj.Enabled = false;
            buttonObrisiStudenta.Enabled = false;
            buttonPrakticniProjekti.Enabled = false;
            buttonTeorijskiProjekti.Enabled = false;
            buttonGrupe.Enabled = false;

            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IQuery query = session.CreateQuery("select s.Id, s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer from Student as s");
                        IList<object[]> studenti = query.List<object[]>();

                        if (studenti.Any())
                        {
                            listViewStudenti.Items.Clear();
                            foreach (object[] s in studenti)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] { s[0].ToString()!, (string)s[1], (string)s[2], (string)s[3], (string)s[4], (string)s[5] });
                                listViewStudenti.Items.Add(listViewItem);
                            }

                            listViewStudenti.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom otvaranja konekcije");
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}