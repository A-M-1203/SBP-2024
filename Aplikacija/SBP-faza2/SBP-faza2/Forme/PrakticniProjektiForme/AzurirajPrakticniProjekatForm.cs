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
    public partial class AzurirajPrakticniProjekatForm : Form
    {
        public AzurirajPrakticniProjekatForm()
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
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }

        private void textBoxSkolskaGodina_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }

        private void comboBoxGrupni_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }

        private void dateTimePickerDatumPocetka_ValueChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }

        private void dateTimePickerRokZaZavrsetak_ValueChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }

        private void listBoxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSkolskaGodina.Text) &&
                                comboBoxGrupni.SelectedIndex >= 0 &&
                                textBoxSkolskaGodina.TextLength == textBoxSkolskaGodina.MaxLength &&
                                textBoxSkolskaGodina.Text.Contains('/') &&
                                dateTimePickerDatumPocetka.Value < dateTimePickerRokZaZavrsetak.Value &&
                                listBoxPredmet.SelectedItems.Count == 1;

            buttonAzurirajPrakticniProjekat.Enabled = enableButton;
        }
    }
}