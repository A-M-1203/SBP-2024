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

namespace SBP_faza2.Forme.PrakticniProjektiForme
{
    public partial class DodajPrakticniProjekatForm : Form
    {
        public DodajPrakticniProjekatForm()
        {
            InitializeComponent();
        }

        private void textBoxSkolskaGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNazivProjekta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void textBoxSkolskaGodina_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void comboBoxGrupni_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void dateTimePickerDatumPocetka_ValueChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void dateTimePickerRokZaZavrsetak_ValueChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void DodajPrakticniProjekatForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IQuery query = session.CreateQuery("select p.Id, p.Naziv from Predmet as p");
                        IList<object[]> predmeti = query.List<object[]>();

                        if (predmeti.Any())
                        {
                            foreach (object[] p in predmeti)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] { p[0].ToString()!, (string)p[1] });
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
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listViewPredmeti.SelectedItems.Count == 1;

            buttonDodajPrakticniProjekat.Enabled = enableButton;
        }

        private void buttonDodajPrakticniProjekat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                if (session != null)
                {
                    int predmetId = int.Parse(listViewPredmeti.SelectedItems[0].SubItems[0].Text);
                    Predmet predmet = session.Load<Predmet>(predmetId);

                    Projekat noviPrakticniProjekat = new PrakticniProjekat
                    {
                        Naziv = textBoxNazivProjekta.Text.Trim(),
                        SkolskaGodina = textBoxSkolskaGodina.Text,
                        Grupni = comboBoxGrupni.SelectedItem!.ToString()!,
                        Tip = "Praktični",
                        DatumPocetka = dateTimePickerDatumPocetka.Value,
                        RokZaZavrsetak = dateTimePickerRokZaZavrsetak.Value,
                        KratakOpis = textBoxKratakOpis.Text.Trim(),
                        PreporuceniProgramskiJezik = textBoxPreporuceniProgJezik.Text.Trim(),
                        BrojIzvestaja = (int)numericUpDownBrojIzvestaja.Value,
                        Predmet = predmet
                    };

                    session.Save(noviPrakticniProjekat);
                    session.Flush();

                    MessageBox.Show("Praktični projekat uspešno upisan u bazu podataka");

                    session.Close();
                }
                else
                {
                    MessageBox.Show("Greška prilikom otvaranja konekcije");
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}