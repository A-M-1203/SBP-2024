using NHibernate;
using NHibernate.Criterion;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Text;

namespace SBP_faza2.Forme;

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
        semestarComboBox.Enabled = true;
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
        semestarComboBox.Enabled = false;
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
        semestarComboBox.SelectedIndex = -1;
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
        rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1).AddDays(1);
        datumPocetkaDateTimePicker.Value = DateTime.Now;

        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    if (semestarComboBox.SelectedIndex != -1)
                    {
                        string semestar = semestarComboBox.SelectedItem!.ToString()!;
                        predmetComboBox.Items.Clear();
                        IList<PredmetNazivSifra> naziviPredmeta = session.Query<Predmet>()
                            .Where(s => s.Semestar.Trim() == semestar)
                            .Select(p => new PredmetNazivSifra
                            {
                                Id = p.Id,
                                Naziv = p.Naziv,
                                Sifra = p.Sifra
                            }).ToList();

                        foreach (var p in naziviPredmeta)
                        {
                            predmetComboBox.Items.Add(p.Naziv + " " + "(" + p.Sifra + ")");
                        }
                    }

                    projekatDataGridView.Rows.Clear();

                    IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                    foreach (var p in projekti)
                    {
                        if (p.GetType() == typeof(TeorijskiProjekat))
                        {
                            projekatDataGridView.Rows.Add(new string[]
                            {
                                p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(), p.MaksimalanBrojStrana.ToString(),
                                p.PreporuceniProgramskiJezik, p.BrojIzvestaja.ToString(), p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")", "Teorijski", p.DatumPocetka.ToString(),
                                p.DatumZavrsetka.ToString(), p.KratakOpis
                            });
                        }
                        else
                        {
                            projekatDataGridView.Rows.Add(new string[]
                            {
                                p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(), p.MaksimalanBrojStrana.ToString(),
                                p.PreporuceniProgramskiJezik, p.BrojIzvestaja.ToString(), p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")", "Praktični", p.DatumPocetka.ToString(),
                                p.DatumZavrsetka.ToString(), p.KratakOpis
                            });
                        }
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

    private void skolskaGodinaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
        {
            return;
        }

        e.Handled = true;
    }

    private void projekatDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći projekat";

            DataGridViewRow row = projekatDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
            nazivProjektaTextBox.Text = row.Cells["nazivProjektaColumn"].Value.ToString();
            skolskaGodinaTextBox.Text = row.Cells["skolskaGodinaColumn"].Value.ToString();

            string grupni = row.Cells["grupniColumn"].Value.ToString()!;
            grupni = grupni.Trim();
            foreach (var item in grupniComboBox.Items)
            {
                if (item.ToString() == grupni)
                {
                    grupniComboBox.SelectedItem = item;
                    break;
                }
            }

            rokZaZavrsetakDateTimePicker.Value = row.Cells["rokZaZavrsetakColumn"].Value.FromStringToDate();
            maksimalanBrojStranaNumericUpDown.Value = decimal.Parse(row.Cells["maksimalanBrojStranaColumn"].Value.ToString());

            string jezik = row.Cells["preporuceniProgramskiJezikColumn"].Value?.ToString() ?? string.Empty;
            if (jezik != string.Empty)
            {
                jezik = jezik.Trim();
                foreach (var item in preporuceniProgramskiJezikComboBox.Items)
                {
                    if (item.ToString() == jezik)
                    {
                        preporuceniProgramskiJezikComboBox.SelectedItem = item;
                        break;
                    }
                }
            }
            else preporuceniProgramskiJezikComboBox.SelectedIndex = -1;

            brojIzvestajaNumericUpDown.Value = decimal.Parse(row.Cells["brojIzvestajaColumn"].Value.ToString());



            string predmet = row.Cells["predmetColumn"].Value.ToString()!;
            predmet = predmet.Trim();
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IList<PredmetNazivSifraSemestar> predmeti = session.Query<Predmet>()
                            .Where(x => x.Naziv == ObrisiSifruPredmeta(predmet))
                            .Select(p => new PredmetNazivSifraSemestar
                            {
                                Id = p.Id,
                                Naziv = p.Naziv,
                                Sifra = p.Sifra,
                                Semestar = p.Semestar
                            }).ToList();

                        foreach (var p in predmeti)
                        {
                            if (predmet == p.Naziv + " " + "(" + p.Sifra + ")")
                            {
                                semestarComboBox.SelectedItem = p.Semestar.Trim();
                                predmetComboBox.SelectedItem = predmet;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            foreach (var item in predmetComboBox.Items)
            {
                if (item.ToString() == predmet)
                {
                    predmetComboBox.SelectedItem = item;
                    break;
                }
            }

            string tip = row.Cells["tipProjektaColumn"].Value.ToString()!;
            tip = tip.Trim();
            foreach (var item in tipProjektaComboBox.Items)
            {
                if (item.ToString() == tip)
                {
                    tipProjektaComboBox.SelectedItem = item;
                    break;
                }
            }

            datumPocetkaDateTimePicker.Value = row.Cells["datumPocetkaColumn"].Value.FromStringToDate();
            datumZavrsetkaDateTimePicker.Value = row.Cells["datumZavrsetkaColumn"].Value.FromStringToDate();
            kratakOpisTextBox.Text = row.Cells["kratakOpisColumn"].Value?.ToString() ?? string.Empty;

            nazivProjektaTextBox.Enabled = true;
            skolskaGodinaTextBox.Enabled = true;
            grupniComboBox.Enabled = true;
            rokZaZavrsetakDateTimePicker.Enabled = true;
            maksimalanBrojStranaNumericUpDown.Enabled = true;
            preporuceniProgramskiJezikComboBox.Enabled = true;
            brojIzvestajaNumericUpDown.Enabled = true;
            semestarComboBox.Enabled = true;
            predmetComboBox.Enabled = true;
            tipProjektaComboBox.Enabled = true;
            datumPocetkaDateTimePicker.Enabled = true;
            datumZavrsetkaDateTimePicker.Enabled = true;
            kratakOpisTextBox.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;
        }
    }

    private string ObrisiSifruPredmeta(string input)
    {
        int startIndex = input.IndexOf('(');
        int endIndex = input.IndexOf(')');

        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
        {
            input = input.Remove(startIndex, (endIndex - startIndex) + 1).Trim();
        }

        return input;
    }

    private void semestarComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (semestarComboBox.SelectedIndex != -1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        string semestar = semestarComboBox.SelectedItem!.ToString()!;
                        predmetComboBox.Items.Clear();
                        IList<PredmetNazivSifra> naziviPredmeta = session.Query<Predmet>()
                            .Where(s => s.Semestar.Trim() == semestar)
                            .Select(p => new PredmetNazivSifra
                            {
                                Id = p.Id,
                                Naziv = p.Naziv,
                                Sifra = p.Sifra
                            }).ToList();

                        foreach (var p in naziviPredmeta)
                        {
                            predmetComboBox.Items.Add(p.Naziv + " " + "(" + p.Sifra + ")");
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }

    private bool proveriUnos()
    {
        bool result = true;

        if (nazivProjektaTextBox.Text.Length < 2)
        {
            result = false;
            nazivProjektaErrorLabel.Text = "Naziv projekta mora da ima barem 2 karaktera";
        }
        else nazivProjektaErrorLabel.Text = string.Empty;

        if (skolskaGodinaTextBox.Text.Length < 9)
        {
            result = false;
            skolskaGodinaErrorLabel.Text = "Format unosa za školsku godinu je npr. 2018/2019";
        }
        else if (skolskaGodinaTextBox.Text[4] != '/')
        {
            result = false;
            skolskaGodinaErrorLabel.Text = "Format unosa za školsku godinu je npr. 2018/2019";
        }
        else
        {
            string input = skolskaGodinaTextBox.Text;

            string[] godine = input.Split('/');
            int prvaGodina = int.Parse(godine[0]);
            int drugaGodina = int.Parse(godine[1]);
            if (prvaGodina >= drugaGodina || ++prvaGodina != drugaGodina)
            {
                result = false;
                skolskaGodinaErrorLabel.Text = "Nevalidna školska godina. Format je npr. 2018/2019";
            }
            else skolskaGodinaErrorLabel.Text = string.Empty;
        }

        if (grupniComboBox.SelectedItem == null)
        {
            result = false;
            grupniErrorLabel.Text = "Mora da se odabere da li je projekat grupni ili nije";
        }
        else grupniErrorLabel.Text = string.Empty;

        if (rokZaZavrsetakDateTimePicker.Value < DateTime.Now.AddMonths(1))
        {
            result = false;
            rokZaZavrsetakErrorLabel.Text = "Rok za završetak mora da bude barem mesec dana od danas";
        }
        else rokZaZavrsetakErrorLabel.Text = string.Empty;

        if (predmetComboBox.SelectedItem == null)
        {
            result = false;
            predmetErrorLabel.Text = "Predmet mora biti izabran";
        }
        else predmetErrorLabel.Text = string.Empty;

        if (tipProjektaComboBox.SelectedItem == null)
        {
            result = false;
            tipProjektaErrorLabel.Text = "Tip projekta mora biti izabran";
        }
        else tipProjektaErrorLabel.Text = string.Empty;

        if (datumPocetkaDateTimePicker.Value < DateTime.Now)
        {
            result = false;
            datumPocetkaErrorLabel.Text = "Datum početka ne može da bude pre danas";
        }
        else if (datumPocetkaDateTimePicker.Value >= datumZavrsetkaDateTimePicker.Value)
        {
            result = false;
            datumPocetkaErrorLabel.Text = "Datum početka ne može da bude nakon datuma zavešetka";
        }
        else datumPocetkaErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći projekat";
        DataGridViewRow row = projekatDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
        nazivProjektaTextBox.Text = row.Cells["nazivProjektaColumn"].Value.ToString();
        skolskaGodinaTextBox.Text = row.Cells["skolskaGodinaColumn"].Value.ToString();

        string grupni = row.Cells["grupniColumn"].Value.ToString()!;
        grupni = grupni.Trim();
        foreach (var item in grupniComboBox.Items)
        {
            if (item.ToString() == grupni)
            {
                grupniComboBox.SelectedItem = item;
                break;
            }
        }

        rokZaZavrsetakDateTimePicker.Value = row.Cells["rokZaZavrsetakColumn"].Value.FromStringToDate();
        maksimalanBrojStranaNumericUpDown.Value = decimal.Parse(row.Cells["maksimalanBrojStranaColumn"].Value.ToString());

        string jezik = row.Cells["preporuceniProgramskiJezikColumn"].Value?.ToString() ?? string.Empty;
        if (jezik != string.Empty)
        {
            jezik = jezik.Trim();
            foreach (var item in preporuceniProgramskiJezikComboBox.Items)
            {
                if (item.ToString() == jezik)
                {
                    preporuceniProgramskiJezikComboBox.SelectedItem = item;
                    break;
                }
            }
        }
        else preporuceniProgramskiJezikComboBox.SelectedIndex = -1;

        brojIzvestajaNumericUpDown.Value = decimal.Parse(row.Cells["brojIzvestajaColumn"].Value.ToString());



        string predmet = row.Cells["predmetColumn"].Value.ToString()!;
        predmet = predmet.Trim();
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    IList<PredmetNazivSifraSemestar> predmeti = session.Query<Predmet>()
                        .Where(x => x.Naziv == ObrisiSifruPredmeta(predmet))
                        .Select(p => new PredmetNazivSifraSemestar
                        {
                            Id = p.Id,
                            Naziv = p.Naziv,
                            Sifra = p.Sifra,
                            Semestar = p.Semestar
                        }).ToList();

                    foreach (var p in predmeti)
                    {
                        if (predmet == p.Naziv + " " + "(" + p.Sifra + ")")
                        {
                            semestarComboBox.SelectedItem = p.Semestar.Trim();
                            predmetComboBox.SelectedItem = predmet;
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }

        foreach (var item in predmetComboBox.Items)
        {
            if (item.ToString() == predmet)
            {
                predmetComboBox.SelectedItem = item;
                break;
            }
        }

        string tip = row.Cells["tipProjektaColumn"].Value.ToString()!;
        tip = tip.Trim();
        foreach (var item in tipProjektaComboBox.Items)
        {
            if (item.ToString() == tip)
            {
                tipProjektaComboBox.SelectedItem = item;
                break;
            }
        }

        datumPocetkaDateTimePicker.Value = row.Cells["datumPocetkaColumn"].Value.FromStringToDate();
        datumZavrsetkaDateTimePicker.Value = row.Cells["datumZavrsetkaColumn"].Value.FromStringToDate();
        kratakOpisTextBox.Text = row.Cells["kratakOpisColumn"].Value?.ToString() ?? string.Empty;

        nazivProjektaTextBox.Enabled = true;
        skolskaGodinaTextBox.Enabled = true;
        grupniComboBox.Enabled = true;
        rokZaZavrsetakDateTimePicker.Enabled = true;
        maksimalanBrojStranaNumericUpDown.Enabled = true;
        preporuceniProgramskiJezikComboBox.Enabled = true;
        brojIzvestajaNumericUpDown.Enabled = true;
        semestarComboBox.Enabled = true;
        predmetComboBox.Enabled = true;
        tipProjektaComboBox.Enabled = true;
        datumPocetkaDateTimePicker.Enabled = true;
        datumZavrsetkaDateTimePicker.Enabled = true;
        kratakOpisTextBox.Enabled = true;

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;
    }

    private void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        proveriUnos();
    }
}
