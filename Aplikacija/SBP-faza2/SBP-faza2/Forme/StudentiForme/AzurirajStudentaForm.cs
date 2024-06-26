﻿using NHibernate;
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

namespace SBP_faza2.Forme
{
    public partial class AzurirajStudentaForm : Form
    {
        private readonly int _studentId;

        public AzurirajStudentaForm()
        {
            InitializeComponent();
        }

        public AzurirajStudentaForm(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
        }

        private void textBoxImeStudenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void buttonAzurirajStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();

                if (session != null)
                {
                    Student student = session.Load<Student>(_studentId);
                    student.LicnoIme = textBoxImeStudenta.Text;
                    student.ImeRoditelja = textBoxImeRoditelja.Text;
                    student.Prezime = textBoxPrezimeStudenta.Text;
                    student.BrojIndeksa = textBoxBrojIndeksa.Text;
                    student.Smer = comboBoxSmer.SelectedItem!.ToString()!;

                    session.SaveOrUpdate(student);
                    session.Flush();

                    session.Close();

                    MessageBox.Show("Student uspešno ažuriran");
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

        private void AzurirajStudentaForm_Load(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    Student s = session.Load<Student>(_studentId);
                    textBoxImeStudenta.Text = s.LicnoIme;
                    textBoxImeRoditelja.Text = s.ImeRoditelja;
                    textBoxPrezimeStudenta.Text = s.Prezime;
                    textBoxBrojIndeksa.Text = s.BrojIndeksa;
                    comboBoxSmer.SelectedItem = s.Smer;
                }

                
            }
            catch(Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        private void textBoxImeStudenta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonAzurirajStudenta.Enabled = enableButton;
        }

        private void textBoxImeRoditelja_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonAzurirajStudenta.Enabled = enableButton;
        }

        private void textBoxPrezimeStudenta_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonAzurirajStudenta.Enabled = enableButton;
        }

        private void textBoxBrojIndeksa_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonAzurirajStudenta.Enabled = enableButton;
        }

        private void comboBoxSmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableButton = !string.IsNullOrWhiteSpace(textBoxImeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxImeRoditelja.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPrezimeStudenta.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxBrojIndeksa.Text) &&
                                comboBoxSmer.SelectedIndex >= 0;

            buttonAzurirajStudenta.Enabled = enableButton;
        }
    }
}