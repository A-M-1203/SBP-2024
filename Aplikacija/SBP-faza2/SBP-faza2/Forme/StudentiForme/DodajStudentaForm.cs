using Antlr.Runtime;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SBP_faza2.Forme
{
    public partial class DodajStudentaForm : Form
    {
        public DodajStudentaForm()
        {
            InitializeComponent();
        }

        private void textBoxImeStudenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxImeRoditelja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrezimeStudenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxBrojIndeksa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonDodajStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                if (session != null)
                {
                    IQuery query = session.CreateQuery("from Student as s where s.BrojIndeksa = :indeks");
                    query.SetParameter("indeks", textBoxBrojIndeksa.Text);

                    Student? student = query.UniqueResult<Student>();
                    if (student != null)
                    {
                        MessageBox.Show($"Student sa indeksom {textBoxBrojIndeksa.Text} već postoji u bazi podataka");
                    }
                    else
                    {
                        Student noviStudent = new Student
                        {
                            LicnoIme = textBoxImeStudenta.Text.Trim(),
                            ImeRoditelja = textBoxImeRoditelja.Text,
                            Prezime = textBoxPrezimeStudenta.Text,
                            BrojIndeksa = textBoxBrojIndeksa.Text,
                            Smer = comboBoxSmer.SelectedItem!.ToString()!
                        };

                        session.Save(noviStudent);
                        session.Flush();

                        MessageBox.Show("Student uspešno upisan u bazu podataka");
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

        private void textBoxImeStudenta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonDodajStudenta.Enabled = enableButton;
        }

        private void textBoxImeRoditelja_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonDodajStudenta.Enabled = enableButton;
        }

        private void textBoxPrezimeStudenta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonDodajStudenta.Enabled = enableButton;
        }

        private void textBoxBrojIndeksa_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonDodajStudenta.Enabled = enableButton;
        }

        private void comboBoxSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonDodajStudenta.Enabled = enableButton;
        }
    }
}