using FluentNHibernate.Conventions;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
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
            AzurirajPredmetForm azurirajPredmetForma = new AzurirajPredmetForm(listViewPredmeti.SelectedItems[0]);
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

        private void PredmetiForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IQuery query = session.CreateQuery("select p.Id, p.Naziv, p.Sifra, p.Semestar, p.Katedra from Predmet as p");
                        IList<object[]> predmeti = query.List<object[]>();

                        if (predmeti.Any())
                        {
                            foreach (object[] p in predmeti)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] { p[0].ToString()!, (string)p[1], (string)p[2], (string)p[3], (string)p[4] });
                                listViewPredmeti.Items.Add(listViewItem);
                            }

                            listViewPredmeti.Refresh();
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

        private void listViewPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPredmeti.SelectedIndices.Count == 1)
            {
                buttonAzuriraj.Enabled = true;
                buttonObrisi.Enabled = true;
                buttonPrakticniProjekti.Enabled = true;
                buttonTeorijskiProjekti.Enabled = true;
            }
            else
            {
                buttonAzuriraj.Enabled = false;
                buttonObrisi.Enabled = false;
                buttonPrakticniProjekti.Enabled = false;
                buttonTeorijskiProjekti.Enabled = false;
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    int id = int.Parse(listViewPredmeti.SelectedItems[0].SubItems[0].Text);
                    Predmet predmet = session.Load<Predmet>(id);

                    session.Delete(predmet);
                    session.Flush();

                    session.Close();

                    MessageBox.Show("Predmet uspešno obrisan");
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

        private void PredmetiForm_Activated(object sender, EventArgs e)
        {
            buttonAzuriraj.Enabled = false;
            buttonObrisi.Enabled = false;
            buttonPrakticniProjekti.Enabled = false;
            buttonTeorijskiProjekti.Enabled = false;

            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IQuery query = session.CreateQuery("select p.Id, p.Naziv, p.Sifra, p.Semestar, p.Katedra from Predmet as p");
                        IList<object[]> predmeti = query.List<object[]>();

                        if (predmeti.Any())
                        {
                            listViewPredmeti.Items.Clear();
                            foreach (object[] p in predmeti)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] { p[0].ToString()!, (string)p[1], (string)p[2], (string)p[3], (string)p[4] });
                                listViewPredmeti.Items.Add(listViewItem);
                            }

                            listViewPredmeti.Refresh();
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