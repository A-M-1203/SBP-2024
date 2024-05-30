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
    public partial class AzurirajPredmetForm : Form
    {
        public AzurirajPredmetForm()
        {
            InitializeComponent();
        }

        private readonly ListViewItem? _predmet;
        private readonly int? _id;

        public AzurirajPredmetForm(ListViewItem predmet)
        {
            InitializeComponent();
            _predmet = predmet;
            _id = int.Parse(_predmet.SubItems[0].Text);
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

            buttonAzurirajPredmet.Enabled = enableButton;
        }

        private void textBoxSifraPredmeta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonAzurirajPredmet.Enabled = enableButton;
        }

        private void comboBoxKatedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonAzurirajPredmet.Enabled = enableButton;
        }

        private void comboBoxSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                                comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

            buttonAzurirajPredmet.Enabled = enableButton;
        }

        private void buttonAzurirajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                if (session != null)
                {
                    Predmet predmet = session.Load<Predmet>(_id);
                    predmet.Naziv = textBoxNazivPredmeta.Text;
                    predmet.Sifra = textBoxSifraPredmeta.Text;
                    predmet.Semestar = comboBoxSemestar.SelectedItem!.ToString()!;
                    predmet.Katedra = comboBoxKatedra.SelectedItem!.ToString()!;

                    session.SaveOrUpdate(predmet);
                    session.Flush();

                    session.Close();

                    MessageBox.Show("Predmet uspešno ažuriran");
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

        private void AzurirajPredmetForm_Load(object sender, EventArgs e)
        {
            textBoxNazivPredmeta.Text = _predmet!.SubItems[1].Text;
            textBoxSifraPredmeta.Text = _predmet!.SubItems[2].Text;
            comboBoxSemestar.SelectedItem = _predmet!.SubItems[3].Text;
            comboBoxKatedra.SelectedItem = _predmet!.SubItems[4].Text;
        }
    }
}