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
    public partial class DodajPredmetForm : Form
    {
        public DodajPredmetForm()
        {
            InitializeComponent();
        }

        private void textBoxNazivPredmeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxSifraPredmeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonDodajPredmet.Enabled = enableButton;
        }

        private void textBoxSifraPredmeta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonDodajPredmet.Enabled = enableButton;
        }

        private void comboBoxKatedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonDodajPredmet.Enabled = enableButton;
        }

        private void comboBoxSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonDodajPredmet.Enabled = enableButton;
        }

        private void buttonDodajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                if (session != null)
                {
                    IQuery query = session.CreateQuery("from Predmet as p where p.Sifra = :sifra");
                    query.SetParameter("sifra", textBoxSifraPredmeta.Text);

                    Predmet? predmet = query.UniqueResult<Predmet>();
                    if (predmet != null)
                    {
                        MessageBox.Show($"Predmet sa šifrom {textBoxSifraPredmeta.Text} već postoji u bazi podataka");
                    }
                    else
                    {
                        Predmet noviPredmet = new Predmet
                        {
                            Naziv = textBoxNazivPredmeta.Text.Trim(),
                            Sifra = textBoxSifraPredmeta.Text,
                            Katedra = comboBoxKatedra.SelectedItem!.ToString()!,
                            Semestar = comboBoxSemestar.SelectedItem!.ToString()!
                        };

                        if (listBoxProjekti.SelectedItem != null)
                            noviPredmet.Projekti.Add(listBoxProjekti.SelectedItem as Projekat);

                        session.Save(noviPredmet);
                        session.Flush();

                        MessageBox.Show("Predmet uspešno upisan u bazu podataka");
                    }

                    session.Close();
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
    }
}