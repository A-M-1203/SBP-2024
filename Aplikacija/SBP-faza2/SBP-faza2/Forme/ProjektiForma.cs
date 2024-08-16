using NHibernate;
using NHibernate.Criterion;
using NHibernate.Util;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Collections;

namespace SBP_faza2.Forme;

public partial class ProjektiForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public ProjektiForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;
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
        dodajButtonClicked = false;
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
        rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1).AddDays(2);
        maksimalanBrojStranaNumericUpDown.Value = 0;
        preporuceniProgramskiJezikComboBox.SelectedIndex = -1;
        preporuceniProgramskiJezikComboBox.SelectedText = string.Empty;
        brojIzvestajaNumericUpDown.Value = 0;
        semestarComboBox.SelectedIndex = -1;
        predmetComboBox.SelectedIndex = -1;
        tipProjektaComboBox.SelectedIndex = -1;
        datumPocetkaDateTimePicker.Value = DateTime.Now.AddDays(1);
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
            dodajButtonClicked = false;
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
        dodajButtonClicked = false;
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
        bool result = proveriUnos();

        if (result == true)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    if (dodajButtonClicked == false)
                    {
                        Projekat projekatZaAzuriranje = session.Load<Projekat>(Id);

                        projekatZaAzuriranje.Naziv = nazivProjektaTextBox.Text;
                        projekatZaAzuriranje.SkolskaGodina = skolskaGodinaTextBox.Text;
                        projekatZaAzuriranje.Grupni = grupniComboBox.SelectedItem!.ToString()!;
                        projekatZaAzuriranje.RokZaZavrsetak = rokZaZavrsetakDateTimePicker.Value;
                        projekatZaAzuriranje.MaksimalanBrojStrana = (int)maksimalanBrojStranaNumericUpDown.Value;
                        projekatZaAzuriranje.PreporuceniProgramskiJezik = preporuceniProgramskiJezikComboBox.SelectedItem?.ToString() ?? string.Empty;
                        projekatZaAzuriranje.BrojIzvestaja = (int)brojIzvestajaNumericUpDown.Value;
                        projekatZaAzuriranje.DatumPocetka = datumPocetkaDateTimePicker.Value;
                        projekatZaAzuriranje.DatumZavrsetka = datumZavrsetkaDateTimePicker.Value;
                        projekatZaAzuriranje.KratakOpis = kratakOpisTextBox.Text;

                        string[] noviPredmetNazivSifra = predmetComboBox.SelectedItem!.ToString()!.Split('(');
                        string noviPredmetNaziv = noviPredmetNazivSifra[0].Substring(0, noviPredmetNazivSifra[0].Length - 1);
                        string noviPredmetSifra = noviPredmetNazivSifra[1].Substring(0, noviPredmetNazivSifra[1].Length - 1);

                        if (projekatZaAzuriranje.Predmet.Naziv != noviPredmetNaziv || projekatZaAzuriranje.Predmet.Sifra != noviPredmetSifra)
                        {
                            Predmet stariPredmet = session.Query<Predmet>().First(p => p.Naziv == projekatZaAzuriranje.Predmet.Naziv
                            && p.Sifra == projekatZaAzuriranje.Predmet.Sifra);

                            stariPredmet.Projekti.Remove(projekatZaAzuriranje);

                            session.Update(stariPredmet);

                            Predmet noviPredmet = session.Query<Predmet>().First(p => p.Naziv == noviPredmetNaziv
                            && p.Sifra == noviPredmetSifra);

                            projekatZaAzuriranje.Predmet = noviPredmet;
                            noviPredmet.Projekti.Add(projekatZaAzuriranje);

                            session.Update(noviPredmet);
                        }
                        else
                        {
                            session.Update(projekatZaAzuriranje);
                        }

                        session.Flush();

                        successStatusLabel.ForeColor = Color.Lime;
                        successStatusLabel.Text = "Projekat je uspešno ažuriran";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Projekat? projekat = session.Query<Projekat>().FirstOrDefault(p => p.Naziv == nazivProjektaTextBox.Text
                        && p.SkolskaGodina == skolskaGodinaTextBox.Text);

                        if (projekat == null)
                        {
                            string[] predmetSifra = predmetComboBox.SelectedItem!.ToString()!.Split('(');
                            string nazivPredmeta = predmetSifra[0].Substring(0, predmetSifra[0].Length - 1);
                            string sifraPredmeta = predmetSifra[1].Substring(0, predmetSifra[1].Length - 1);

                            Predmet predmet = session.Query<Predmet>().First(p => p.Naziv == nazivPredmeta && p.Sifra == sifraPredmeta);

                            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
                            {
                                projekat = new TeorijskiProjekat()
                                {
                                    Naziv = nazivProjektaTextBox.Text,
                                    SkolskaGodina = skolskaGodinaTextBox.Text,
                                    Grupni = grupniComboBox.SelectedItem!.ToString()!,
                                    RokZaZavrsetak = rokZaZavrsetakDateTimePicker.Value,
                                    MaksimalanBrojStrana = (int)maksimalanBrojStranaNumericUpDown.Value,
                                    PreporuceniProgramskiJezik = preporuceniProgramskiJezikComboBox.SelectedItem?.ToString() ?? string.Empty,
                                    BrojIzvestaja = (int)brojIzvestajaNumericUpDown.Value,
                                    Predmet = predmet,
                                    DatumPocetka = datumPocetkaDateTimePicker.Value,
                                    DatumZavrsetka = datumZavrsetkaDateTimePicker.Value,
                                    KratakOpis = kratakOpisTextBox.Text
                                };
                            }
                            else
                            {
                                projekat = new PrakticniProjekat()
                                {
                                    Naziv = nazivProjektaTextBox.Text,
                                    SkolskaGodina = skolskaGodinaTextBox.Text,
                                    Grupni = grupniComboBox.SelectedItem!.ToString()!,
                                    RokZaZavrsetak = rokZaZavrsetakDateTimePicker.Value,
                                    MaksimalanBrojStrana = (int)maksimalanBrojStranaNumericUpDown.Value,
                                    PreporuceniProgramskiJezik = preporuceniProgramskiJezikComboBox.SelectedItem?.ToString() ?? string.Empty,
                                    BrojIzvestaja = (int)brojIzvestajaNumericUpDown.Value,
                                    Predmet = predmet,
                                    DatumPocetka = datumPocetkaDateTimePicker.Value,
                                    DatumZavrsetka = datumZavrsetkaDateTimePicker.Value,
                                    KratakOpis = kratakOpisTextBox.Text
                                };
                            }

                            predmet.Projekti.Add(projekat);
                            session.Update(predmet);
                            session.Flush();

                            successStatusLabel.ForeColor = Color.Lime;
                            successStatusLabel.Text = "Novi projekat je uspešno sačuvan";
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                        else
                        {
                            successStatusLabel.ForeColor = Color.Red;
                            successStatusLabel.Text = "Projekat sa datim nazivom i školskom godinom već postoji";
                            timer1.Enabled = true;
                            timer1.Start();
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

    private void timer1_Tick(object sender, EventArgs e)
    {
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        timer1.Stop();
        timer1.Enabled = false;
    }

    private void ProjektiForma_Load(object sender, EventArgs e)
    {
        rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1).AddDays(2);
        datumPocetkaDateTimePicker.Value = DateTime.Now.AddDays(1);
        datumZavrsetkaDateTimePicker.Value = DateTime.Now;
    }

    private void obrisiToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat projekat = session.Load<Projekat>(Id);

                projekat.Predmet.Projekti.Remove(projekat);

                session.Update(projekat.Predmet);
                session.Delete(projekat);
                session.Flush();

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

                session.Close();

                successStatusLabel.ForeColor = Color.Lime;
                successStatusLabel.Text = "Projekat uspešno obrisan";
                timer1.Enabled = true;
                timer1.Start();
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

    private void pretragaToolStripButton_Click(object sender, EventArgs e)
    {
        if (pretragaPanel.Visible == false)
        {
            pretragaPanel.Visible = true;
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        skolskaGodinaPretraziComboBox.Items.Clear();

                        IList<string> skolskeGodine = session.Query<Projekat>()
                            .Select(x => x.SkolskaGodina.Trim()).Distinct().ToList();

                        foreach (var item in skolskeGodine)
                        {
                            skolskaGodinaPretraziComboBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        else
        {
            pretragaPanel.Visible = false;
        }
    }

    private void tipPretraziComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (tipPretraziComboBox.SelectedIndex != -1)
        //{
        //    try
        //    {
        //        using (ISession? session = DataLayer.GetSession())
        //        {
        //            if (session != null)
        //            {
        //                semestarPretraziComboBox.Enabled = true;
        //                semestarPretraziComboBox.Items.Clear();

        //                IList<string> semestri = session.Query<Projekat>()
        //                    .Where(x => x.Tip == tipPretraziComboBox.SelectedItem!.ToString())
        //                    .Select(x => x.Predmet.Semestar.Trim()).Distinct().ToList();

        //                foreach (var item in semestri)
        //                {
        //                    semestarPretraziComboBox.Items.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ec)
        //    {
        //        MessageBox.Show(ec.Message);
        //    }
        //}
    }

    private void semestarPretraziComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (semestarPretraziComboBox.SelectedIndex != 1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IList<PredmetNazivSifra> predmeti = session.Query<Predmet>()
                            .Where(p => p.Semestar.Trim() == semestarPretraziComboBox.SelectedItem!.ToString())
                            .Select(x => new PredmetNazivSifra
                            {
                                Id = x.Id,
                                Naziv = x.Naziv,
                                Sifra = x.Sifra
                            }).ToList();

                        predmetPretraziComboBox.Items.Clear();

                        foreach (var item in predmeti)
                        {
                            predmetPretraziComboBox.Items.Add(item.Naziv + " " + "(" + item.Sifra + ")");
                        }

                        predmetPretraziComboBox.Enabled = true;
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }

    private void minimizePanelButton_Click(object sender, EventArgs e)
    {
        pretragaPanel.Visible = false;
    }

    private void pretraziButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                var query = session.Query<Projekat>().AsQueryable();

                if (!string.IsNullOrEmpty(nazivPretraziTextBox.Text))
                {
                    query = query.Where(p => p.Naziv.ToLower().Contains(nazivPretraziTextBox.Text.Trim().ToLower()));
                }

                if (skolskaGodinaPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.SkolskaGodina == skolskaGodinaPretraziComboBox.SelectedItem.ToString());
                }

                if (grupniPretaziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.Grupni == grupniPretaziComboBox.SelectedItem.ToString());
                }

                if (zavrsetakCheckBox.Checked == true)
                {
                    if (zavrsetakManjeVeceButton.Text == "<")
                        query = query.Where(p => p.DatumZavrsetka < zavrsetakPreraziDateTimePicker.Value);
                    else
                        query = query.Where(p => p.DatumZavrsetka > zavrsetakPreraziDateTimePicker.Value);
                }

                if (maksStrCheckBox.Checked == true)
                {
                    if (maksBrStrManjeVeceJednakoButton.Text == "<")
                        query = query.Where(p => p.MaksimalanBrojStrana < (int)maksStrPretraziNumericUpDown.Value);
                    else if (maksBrStrManjeVeceJednakoButton.Text == ">")
                        query = query.Where(p => p.MaksimalanBrojStrana > (int)maksStrPretraziNumericUpDown.Value);
                    else
                        query = query.Where(p => p.MaksimalanBrojStrana == (int)maksStrPretraziNumericUpDown.Value);
                }

                if (progJezikPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.PreporuceniProgramskiJezik == progJezikPretraziComboBox.SelectedItem.ToString());
                }

                if (izvestajiCheckBox.Checked == true)
                {
                    if (brojIzvestajaManjeVeceJednakoButton.Text == "<")
                        query = query.Where(p => p.BrojIzvestaja < (int)izvestajiPretraziNumericUpDown.Value);
                    else if (brojIzvestajaManjeVeceJednakoButton.Text == ">")
                        query = query.Where(p => p.BrojIzvestaja > (int)izvestajiPretraziNumericUpDown.Value);
                    else
                        query = query.Where(p => p.BrojIzvestaja == (int)izvestajiPretraziNumericUpDown.Value);
                }

                if (tipPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.Tip == tipPretraziComboBox.SelectedItem.ToString());
                }

                if (predmetPretraziComboBox.SelectedItem != null)
                {
                    string[] predmetNazivSifra = predmetPretraziComboBox.SelectedItem.ToString()!.Split('(');
                    string predmetNaziv = predmetNazivSifra[0].Substring(0, predmetNazivSifra[0].Length - 1);
                    string predmetSifra = predmetNazivSifra[1].Substring(0, predmetNazivSifra[1].Length - 1);

                    query = query.Where(p => p.Predmet.Naziv == predmetNaziv && p.Predmet.Sifra == predmetSifra);
                }

                if (pocetakCheckBox.Checked == true)
                {
                    if (pocetakManjeVeceButton.Text == "<")
                        query = query.Where(p => p.DatumPocetka < pocetakPretraziDateTimePicker.Value);
                    else
                        query = query.Where(p => p.DatumPocetka > pocetakPretraziDateTimePicker.Value);
                }

                projekatDataGridView.Rows.Clear();

                IList<Projekat> projekti = query.ToList();

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

                session.Close();
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }

    private void zavrsetakCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (zavrsetakCheckBox.Checked == true)
            zavrsetakPreraziDateTimePicker.Enabled = true;
        else
            zavrsetakPreraziDateTimePicker.Enabled = false;
    }

    private void pocetakCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (pocetakCheckBox.Checked == true)
            pocetakPretraziDateTimePicker.Enabled = true;
        else
            pocetakPretraziDateTimePicker.Enabled = false;
    }

    private void maksStrCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (maksStrCheckBox.Checked == true)
            maksStrPretraziNumericUpDown.Enabled = true;
        else
            maksStrPretraziNumericUpDown.Enabled = false;
    }

    private void izvestajiCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (izvestajiCheckBox.Checked == true)
            izvestajiPretraziNumericUpDown.Enabled = true;
        else
            izvestajiPretraziNumericUpDown.Enabled = false;
    }

    private void zavrsetakManjeVeceButton_Click(object sender, EventArgs e)
    {
        if (zavrsetakManjeVeceButton.Text == "<")
            zavrsetakManjeVeceButton.Text = ">";
        else
            zavrsetakManjeVeceButton.Text = "<";
    }

    private void maksBrStrManjeVeceJednakoButton_Click(object sender, EventArgs e)
    {
        if (maksBrStrManjeVeceJednakoButton.Text == "=")
            maksBrStrManjeVeceJednakoButton.Text = "<";
        else if (maksBrStrManjeVeceJednakoButton.Text == "<")
            maksBrStrManjeVeceJednakoButton.Text = ">";
        else
            maksBrStrManjeVeceJednakoButton.Text = "=";
    }

    private void brojIzvestajaManjeVeceJednakoButton_Click(object sender, EventArgs e)
    {
        if (brojIzvestajaManjeVeceJednakoButton.Text == "=")
            brojIzvestajaManjeVeceJednakoButton.Text = "<";
        else if (brojIzvestajaManjeVeceJednakoButton.Text == "<")
            brojIzvestajaManjeVeceJednakoButton.Text = ">";
        else
            brojIzvestajaManjeVeceJednakoButton.Text = "=";
    }

    private void pocetakManjeVeceButton_Click(object sender, EventArgs e)
    {
        if (pocetakManjeVeceButton.Text == "<")
            pocetakManjeVeceButton.Text = ">";
        else
            pocetakManjeVeceButton.Text = "<";
    }

    private void ocistiPretraguButton_Click(object sender, EventArgs e)
    {
        nazivPretraziTextBox.Text = string.Empty;
        skolskaGodinaPretraziComboBox.SelectedIndex = -1;
        grupniPretaziComboBox.SelectedIndex = -1;
        zavrsetakCheckBox.Checked = false;
        zavrsetakPreraziDateTimePicker.Value = DateTime.Now;
        zavrsetakManjeVeceButton.Text = "<";
        maksStrCheckBox.Checked = false;
        maksStrPretraziNumericUpDown.Value = 0;
        maksBrStrManjeVeceJednakoButton.Text = "=";
        progJezikPretraziComboBox.SelectedIndex = -1;
        izvestajiCheckBox.Checked = false;
        izvestajiPretraziNumericUpDown.Value = 0;
        brojIzvestajaManjeVeceJednakoButton.Text = "=";
        tipPretraziComboBox.SelectedIndex = -1;
        semestarPretraziComboBox.SelectedIndex = -1;
        predmetPretraziComboBox.SelectedIndex = -1;
        pocetakCheckBox.Checked = false;
        pocetakPretraziDateTimePicker.Value = DateTime.Now;
        pocetakManjeVeceButton.Text = "<";

        semestarPretraziComboBox.Enabled = false;
        predmetPretraziComboBox.Enabled = false;
    }
}
