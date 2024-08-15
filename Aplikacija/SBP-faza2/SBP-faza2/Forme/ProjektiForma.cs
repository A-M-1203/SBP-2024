using NHibernate.Criterion;
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

namespace SBP_faza2.Forme
{
    public partial class ProjektiForma : Form
    {
        private int Id = 0;
        public ProjektiForma()
        {
            InitializeComponent();
        }

        private void dodajToolStripButton_Click(object sender, EventArgs e)
        {
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće zapamćen novi projekat";

            dodajToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            nazivProjektaTextBox.Enabled = true;
            skolskaGodinaTextBox.Enabled = true;
            grupniComboBox.Enabled = true;
            rokZaZavrsetakDateTimePicker.Enabled = true;
            maksimalanBrojStranaNumericUpDown.Enabled = true;
            preporuceniProgramskiJezikComboBox.Enabled = true;
            brojIzvestajaNumericUpDown.Enabled = true;
            predmetComboBox.Enabled = true;
            tipProjektaComboBox.Enabled = true;
            datumPocetkaDateTimePicker.Enabled = true;
            datumZavrsetkaDateTimePicker.Enabled = true;
            kratakOpisTextBox.Enabled = true;

            nazivProjektaErrorLabel.Text = string.Empty;
            skolskaGodinaErrorLabel.Text = string.Empty;
            grupniErrorLabel.Text = string.Empty;
            rokZaZavrsetakErrorLabel.Text = string.Empty;
            maksimalanBrojStranaErrorLabel.Text = string.Empty;
            brojIzvestajaErrorLabel.Text = string.Empty;
            predmetErrorLabel.Text = string.Empty;
            tipProjektaErrorLabel.Text = string.Empty;
            datumPocetkaErrorLabel.Text = string.Empty;
            datumZavrsetkaErrorLabel.Text = string.Empty;
        }

        private void odustaniToolStripButton_Click(object sender, EventArgs e)
        {
            successStatusLabel.Text = string.Empty;

            odustaniToolStripButton.Enabled = false;
            sacuvajToolStripButton.Enabled = false;
            dodajToolStripButton.Enabled = true;

            if (projekatDataGridView.SelectedRows.Count > 0)
            {
                izmeniToolStripButton.Enabled = true;
            }

            nazivProjektaTextBox.Enabled = false;
            skolskaGodinaTextBox.Enabled = false;
            grupniComboBox.Enabled = false;
            rokZaZavrsetakDateTimePicker.Enabled = false;
            maksimalanBrojStranaNumericUpDown.Enabled = false;
            preporuceniProgramskiJezikComboBox.Enabled = false;
            brojIzvestajaNumericUpDown.Enabled = false;
            predmetComboBox.Enabled = false;
            tipProjektaComboBox.Enabled = false;
            datumPocetkaDateTimePicker.Enabled = false;
            datumZavrsetkaDateTimePicker.Enabled = false;
            kratakOpisTextBox.Enabled = false;

            nazivProjektaTextBox.Text = string.Empty;
            skolskaGodinaTextBox.Text = string.Empty;
            grupniComboBox.SelectedIndex = -1;
            rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1);
            maksimalanBrojStranaNumericUpDown.Value = 0;
            preporuceniProgramskiJezikComboBox.SelectedIndex = -1;
            preporuceniProgramskiJezikComboBox.SelectedText = string.Empty;
            brojIzvestajaNumericUpDown.Value = 0;
            predmetComboBox.SelectedIndex = -1;
            tipProjektaComboBox.SelectedIndex = -1;
            datumPocetkaDateTimePicker.Value = DateTime.Now;
            datumZavrsetkaDateTimePicker.Value = DateTime.Now;
            kratakOpisTextBox.Text = string.Empty;

            nazivProjektaErrorLabel.Text = string.Empty;
            skolskaGodinaErrorLabel.Text = string.Empty;
            grupniErrorLabel.Text = string.Empty;
            rokZaZavrsetakErrorLabel.Text = string.Empty;
            maksimalanBrojStranaErrorLabel.Text = string.Empty;
            brojIzvestajaErrorLabel.Text = string.Empty;
            predmetErrorLabel.Text = string.Empty;
            tipProjektaErrorLabel.Text = string.Empty;
            datumPocetkaErrorLabel.Text = string.Empty;
            datumZavrsetkaErrorLabel.Text = string.Empty;
        }

        private void projekatDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (projekatDataGridView.SelectedRows.Count > 0)
            {
                izmeniToolStripButton.Enabled = true;
                obrisiToolStripButton.Enabled = true;
                Id = int.Parse(projekatDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
            }
            else
            {
                izmeniToolStripButton.Enabled = false;
                obrisiToolStripButton.Enabled = false;
            }

            nazivProjektaErrorLabel.Text = string.Empty;
            skolskaGodinaErrorLabel.Text = string.Empty;
            grupniErrorLabel.Text = string.Empty;
            rokZaZavrsetakErrorLabel.Text = string.Empty;
            maksimalanBrojStranaErrorLabel.Text = string.Empty;
            brojIzvestajaErrorLabel.Text = string.Empty;
            predmetErrorLabel.Text = string.Empty;
            tipProjektaErrorLabel.Text = string.Empty;
            datumPocetkaErrorLabel.Text = string.Empty;
            datumZavrsetkaErrorLabel.Text = string.Empty;
        }

        private void ProjektiForma_Activated(object sender, EventArgs e)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IList<ProjekatBasic> projekti = session.QueryOver<Projekat>()
                            .Select(
                                Projections.Property("Id"),
                                Projections.Property("Naziv"),
                                Projections.Property("SkolskaGodina"),
                                Projections.Property("Grupni"),
                                Projections.Property("RokZaZavrsetak"),
                                Projections.Property("MaksimalanBrojStrana"),
                                Projections.Property("PreporuceniProgramskiJezik"),
                                Projections.Property("BrojIzvestaja"),
                                Projections.Property("Predmet"),
                                Projections.Property("DatumPocetka"),
                                //Projections.Property("Tip"),
                                Projections.Property("DatumZavrsetka"),
                                Projections.Property("KratakOpis")
                            ).List<object[]>()
                            .Select(row => new ProjekatBasic
                            {
                                Id = (int)row[0],
                                Naziv = (string)row[1],
                                SkolskaGodina = (string)row[2],
                                Grupni = (string)row[3],
                                RokZaZavrsetak = (row[4] as DateTime?).ToString(),
                                MaksimalanBrojStrana = row[5].ToString(),
                                PreporuceniProgramskiJezik = (string)row[6],
                                BrojIzvestaja = row[7].ToString(),
                                NazivPredmeta = (row[8] as Predmet)!.Naziv,
                                DatumPocetka = (row[9] as DateTime?).ToString(),
                                DatumZavrsetka = (row[10] as DateTime?).ToString(),
                                KratakOpis = (string)row[11],
                                TipProjekta = "tip"
                            }).ToList();

                        projekatDataGridView.Rows.Clear();

                        foreach (var p in projekti)
                        {
                            projekatDataGridView.Rows.Add(new string[]
                            { p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak, p.MaksimalanBrojStrana,
                             p.PreporuceniProgramskiJezik, p.KratakOpis, p.BrojIzvestaja, p.NazivPredmeta, p.TipProjekta,
                            p.DatumPocetka, p.DatumZavrsetka });
                        }

                        projekatDataGridView.Refresh();
                        projekatDataGridView.ClearSelection();

                        brojProjekataLabel.Text = session.Query<Projekat>().Count().ToString();
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
