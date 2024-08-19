using NHibernate;
using NHibernate.Linq;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class ProjektiForma : Form
{
    private long Id = 0;
    private bool dodajButtonClicked = false;
    public ProjektiForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvan novi projekat";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        nazivProjektaTextBox.Enabled = true;
        skolskaGodinaTextBox.Enabled = true;
        grupniComboBox.Enabled = true;
        rokZaZavrsetakDateTimePicker.Enabled = true;
        tipProjektaComboBox.Enabled = true;
        predmetComboBox.Enabled = true;
        datumPocetkaDateTimePicker.Enabled = true;

        nazivProjektaErrorLabel.Text = string.Empty;
        skolskaGodinaErrorLabel.Text = string.Empty;
        grupniErrorLabel.Text = string.Empty;
        rokZaZavrsetakErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        brojIzvestajaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
        maksimalanBrojStranaErrorLabel.Text = string.Empty;
        datumPocetkaErrorLabel.Text = string.Empty;
        datumZavrsetkaErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

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
        datumZavrsetkaCheckBox.Checked = false;
        kratakOpisTextBox.Enabled = false;

        nazivProjektaTextBox.Text = string.Empty;
        skolskaGodinaTextBox.Text = string.Empty;
        grupniComboBox.SelectedIndex = -1;
        rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1).AddDays(2);
        maksimalanBrojStranaNumericUpDown.Value = 0;
        preporuceniProgramskiJezikComboBox.SelectedIndex = -1;
        preporuceniProgramskiJezikComboBox.SelectedText = string.Empty;
        brojIzvestajaNumericUpDown.Value = 0;
        predmetComboBox.SelectedIndex = -1;
        tipProjektaComboBox.SelectedIndex = -1;
        datumPocetkaDateTimePicker.Value = DateTime.Now.AddDays(1);
        datumZavrsetkaDateTimePicker.Value = rokZaZavrsetakDateTimePicker.Value;
        kratakOpisTextBox.Text = string.Empty;

        nazivProjektaErrorLabel.Text = string.Empty;
        skolskaGodinaErrorLabel.Text = string.Empty;
        grupniErrorLabel.Text = string.Empty;
        rokZaZavrsetakErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        brojIzvestajaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
        maksimalanBrojStranaErrorLabel.Text = string.Empty;
        datumPocetkaErrorLabel.Text = string.Empty;
        datumZavrsetkaErrorLabel.Text = string.Empty;
    }

    private void projekatDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (projekatDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = long.Parse(projekatDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
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
        tipProjektaErrorLabel.Text = string.Empty;
        brojIzvestajaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
        maksimalanBrojStranaErrorLabel.Text = string.Empty;
        datumPocetkaErrorLabel.Text = string.Empty;
        datumZavrsetkaErrorLabel.Text = string.Empty;
    }

    private async void ProjektiForma_Activated(object sender, EventArgs e)
    {
        List<string>? predmeti = await DTOManager.VratiNazivSifruPredmeta();
        if (predmeti != null)
        {
            predmetComboBox.Items.Clear();
            foreach (var p in predmeti)
            {
                predmetComboBox.Items.Add(p);
            }
        }

        List<ProjekatPregled>? projekti = DTOManager.VratiSveProjektePregled();
        if (projekti != null)
        {
            projekatDataGridView.Rows.Clear();

            foreach (var p in projekti)
            {
                projekatDataGridView.Rows.Add(new string[]
                {
                    p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(),
                    p.MaksimalanBrojStrana?.ToString() ?? string.Empty, p?.PreporuceniProgramskiJezik ?? string.Empty,
                    p.BrojIzvestaja?.ToString() ?? string.Empty, p.Predmet, p.Tip, p.DatumPocetka.ToString(),
                    p.DatumZavrsetka.ToString() ?? string.Empty, p.KratakOpis ?? string.Empty
                });
            }

            projekatDataGridView.Refresh();
            projekatDataGridView.ClearSelection();

            brojProjekataLabel.Text = projekatDataGridView.RowCount.ToString();
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
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći projekat";

            DataGridViewRow row = projekatDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
            nazivProjektaTextBox.Text = row.Cells["nazivProjektaColumn"].Value.ToString();
            skolskaGodinaTextBox.Text = row.Cells["skolskaGodinaColumn"].Value.ToString();
            grupniComboBox.SelectedItem = row.Cells["grupniColumn"].Value.ToString();
            var zavrsetak = row.Cells["rokZaZavrsetakColumn"].Value?.ToString();
            if (DateTime.TryParse(zavrsetak, out var parsedZavrsetak))
            {
                rokZaZavrsetakDateTimePicker.Value = parsedZavrsetak;
                rokZaZavrsetakDateTimePicker.Enabled = true;
            }
            else
            {
                rokZaZavrsetakDateTimePicker.Enabled = false;
            }

            var brojStr = row.Cells["maksimalanBrojStranaColumn"].Value?.ToString();
            maksimalanBrojStranaNumericUpDown.Value = decimal.TryParse(brojStr, out var result) ? result : 0;

            var jezik = row.Cells["preporuceniProgramskiJezikColumn"].Value?.ToString();
            preporuceniProgramskiJezikComboBox.SelectedItem = jezik;

            var brojIz = row.Cells["brojIzvestajaColumn"].Value?.ToString();
            brojIzvestajaNumericUpDown.Value = decimal.TryParse(brojIz, out var result1) ? result1 : 0;

            predmetComboBox.SelectedItem = row.Cells["predmetColumn"].Value.ToString();
            tipProjektaComboBox.SelectedItem = row.Cells["tipProjektaColumn"].Value.ToString();
            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                maksimalanBrojStranaNumericUpDown.Enabled = true;
            }
            else
            {
                preporuceniProgramskiJezikComboBox.Enabled = true;
                brojIzvestajaNumericUpDown.Enabled = true;
                kratakOpisTextBox.Enabled = true;
            }

            var pocetak = row.Cells["datumPocetkaColumn"].Value?.ToString();
            if (DateTime.TryParse(pocetak, out var parsedPocetak))
            {
                datumPocetkaDateTimePicker.Value = parsedPocetak;
                datumPocetkaDateTimePicker.Enabled = true;
            }
            else
            {
                datumPocetkaDateTimePicker.Enabled = false;
            }

            var kraj = row.Cells["datumZavrsetkaColumn"].Value?.ToString();
            if (DateTime.TryParse(kraj, out var parsedKraj))
            {
                datumZavrsetkaDateTimePicker.Value = parsedKraj;
                datumZavrsetkaCheckBox.Checked = true;
            }
            else
            {
                datumZavrsetkaCheckBox.Checked = false;
            }

            kratakOpisTextBox.Text = row.Cells["kratakOpisColumn"].Value?.ToString() ?? null;

            nazivProjektaTextBox.Enabled = true;
            skolskaGodinaTextBox.Enabled = true;
            grupniComboBox.Enabled = true;
            rokZaZavrsetakDateTimePicker.Enabled = true;
            predmetComboBox.Enabled = true;
            tipProjektaComboBox.Enabled = false;
            datumPocetkaDateTimePicker.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            nazivProjektaErrorLabel.Text = string.Empty;
            skolskaGodinaErrorLabel.Text = string.Empty;
            grupniErrorLabel.Text = string.Empty;
            rokZaZavrsetakErrorLabel.Text = string.Empty;
            tipProjektaErrorLabel.Text = string.Empty;
            brojIzvestajaErrorLabel.Text = string.Empty;
            predmetErrorLabel.Text = string.Empty;
            maksimalanBrojStranaErrorLabel.Text = string.Empty;
            datumPocetkaErrorLabel.Text = string.Empty;
            datumZavrsetkaErrorLabel.Text = string.Empty;
        }
    }

    //private string ObrisiSifruPredmeta(string input)
    //{
    //    int startIndex = input.IndexOf('(');
    //    int endIndex = input.IndexOf(')');

    //    if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
    //    {
    //        input = input.Remove(startIndex, (endIndex - startIndex) + 1).Trim();
    //    }

    //    return input;
    //}

    private bool ProveriUnos()
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

        if (rokZaZavrsetakDateTimePicker.Value < DateTime.Now.AddMonths(1) 
            && dodajButtonClicked == true)
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
            maksimalanBrojStranaErrorLabel.Text = "Tip projekta mora biti izabran";
        }
        else maksimalanBrojStranaErrorLabel.Text = string.Empty;

        if (datumPocetkaDateTimePicker.Value < DateTime.Now && dodajButtonClicked == true)
        {
            result = false;
            datumPocetkaErrorLabel.Text = "Datum početka ne može da bude pre danas";
        }
        else if (datumPocetkaDateTimePicker.Value >= datumZavrsetkaDateTimePicker.Value 
                && datumZavrsetkaDateTimePicker.Enabled == true)
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
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći projekat";
        DataGridViewRow row = projekatDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
        nazivProjektaTextBox.Text = row.Cells["nazivProjektaColumn"].Value.ToString();
        skolskaGodinaTextBox.Text = row.Cells["skolskaGodinaColumn"].Value.ToString();
        grupniComboBox.SelectedItem = row.Cells["grupniColumn"].Value.ToString();
        var zavrsetak = row.Cells["rokZaZavrsetakColumn"].Value?.ToString();
        if (DateTime.TryParse(zavrsetak, out var parsedZavrsetak))
        {
            rokZaZavrsetakDateTimePicker.Value = parsedZavrsetak;
            rokZaZavrsetakDateTimePicker.Enabled = true;
        }
        else
        {
            rokZaZavrsetakDateTimePicker.Enabled = false;
        }

        var brojStr = row.Cells["maksimalanBrojStranaColumn"].Value?.ToString();
        maksimalanBrojStranaNumericUpDown.Value = decimal.TryParse(brojStr, out var result) ? result : 0;

        var jezik = row.Cells["preporuceniProgramskiJezikColumn"].Value?.ToString();
        preporuceniProgramskiJezikComboBox.SelectedItem = jezik;

        var brojIz = row.Cells["brojIzvestajaColumn"].Value?.ToString();
        brojIzvestajaNumericUpDown.Value = decimal.TryParse(brojIz, out var result1) ? result1 : 0;

        predmetComboBox.SelectedItem = row.Cells["predmetColumn"].Value.ToString();
        tipProjektaComboBox.SelectedItem = row.Cells["tipProjektaColumn"].Value.ToString();
        if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
        {
            maksimalanBrojStranaNumericUpDown.Enabled = true;
        }
        else
        {
            preporuceniProgramskiJezikComboBox.Enabled = true;
            brojIzvestajaNumericUpDown.Enabled = true;
            kratakOpisTextBox.Enabled = true;
        }

        var pocetak = row.Cells["datumPocetkaColumn"].Value?.ToString();
        if (DateTime.TryParse(pocetak, out var parsedPocetak))
        {
            datumPocetkaDateTimePicker.Value = parsedPocetak;
            datumPocetkaDateTimePicker.Enabled = true;
        }
        else
        {
            datumPocetkaDateTimePicker.Enabled = false;
        }

        var kraj = row.Cells["datumZavrsetkaColumn"].Value?.ToString();
        if (DateTime.TryParse(kraj, out var parsedKraj))
        {
            datumZavrsetkaDateTimePicker.Value = parsedKraj;
            datumZavrsetkaCheckBox.Checked = true;
        }
        else
        {
            datumZavrsetkaCheckBox.Checked = false;
        }

        kratakOpisTextBox.Text = row.Cells["kratakOpisColumn"].Value?.ToString() ?? null;

        nazivProjektaTextBox.Enabled = true;
        skolskaGodinaTextBox.Enabled = true;
        grupniComboBox.Enabled = true;
        rokZaZavrsetakDateTimePicker.Enabled = true;
        predmetComboBox.Enabled = true;
        tipProjektaComboBox.Enabled = false;
        datumPocetkaDateTimePicker.Enabled = true;

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        nazivProjektaErrorLabel.Text = string.Empty;
        skolskaGodinaErrorLabel.Text = string.Empty;
        grupniErrorLabel.Text = string.Empty;
        rokZaZavrsetakErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        brojIzvestajaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
        maksimalanBrojStranaErrorLabel.Text = string.Empty;
        datumPocetkaErrorLabel.Text = string.Empty;
        datumZavrsetkaErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiProjekat;
            ProjekatBasic projekat;

            string[] predmetSifra = predmetComboBox.SelectedItem!.ToString()!.Split('(');
            string nazivPredmeta = predmetSifra[0];
            string sifraPredmeta = predmetSifra[1];

            nazivPredmeta = nazivPredmeta.Substring(0, nazivPredmeta.Length - 1);
            sifraPredmeta = sifraPredmeta.Substring(0, sifraPredmeta.Length - 1);
            PredmetBasic? predmetBasic = await DTOManager.VratiPredmetBasicAsync(nazivPredmeta, sifraPredmeta);
            if (predmetBasic != null)
            {
                if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
                {
                    projekat = new TeorijskiProjekatBasic()
                    {
                        Id = this.Id,
                        Naziv = nazivProjektaTextBox.Text.Trim(),
                        SkolskaGodina = skolskaGodinaTextBox.Text,
                        Grupni = grupniComboBox.SelectedItem!.ToString()!,
                        RokZaZavrsetak = rokZaZavrsetakDateTimePicker.Value,
                        MaksimalanBrojStrana = (int)maksimalanBrojStranaNumericUpDown.Value,
                        PreporuceniProgramskiJezik = null,
                        KratakOpis = null,
                        BrojIzvestaja = null,
                        Predmet = predmetBasic!,
                        Tip = "Teorijski",
                        DatumPocetka = datumPocetkaDateTimePicker.Value,
                        DatumZavrsetka = datumZavrsetkaDateTimePicker.Enabled == true ? datumZavrsetkaDateTimePicker.Value : null
                    };
                }
                else
                {
                    projekat = new PrakticniProjekatBasic()
                    {
                        Id = this.Id,
                        Naziv = nazivProjektaTextBox.Text.Trim(),
                        SkolskaGodina = skolskaGodinaTextBox.Text,
                        Grupni = grupniComboBox.SelectedItem!.ToString()!,
                        RokZaZavrsetak = rokZaZavrsetakDateTimePicker.Value,
                        MaksimalanBrojStrana = null,
                        PreporuceniProgramskiJezik = preporuceniProgramskiJezikComboBox.SelectedItem!.ToString(),
                        KratakOpis = kratakOpisTextBox.Text,
                        BrojIzvestaja = (int)brojIzvestajaNumericUpDown.Value,
                        Predmet = predmetBasic!,
                        Tip = "Praktični",
                        DatumPocetka = datumPocetkaDateTimePicker.Value,
                        //DatumZavrsetka = datumZavrsetkaDateTimePicker.Enabled == true ? datumZavrsetkaDateTimePicker.Value : null
                    };
                }

                if (datumZavrsetkaDateTimePicker.Enabled == true)
                    projekat.DatumZavrsetka = datumZavrsetkaDateTimePicker.Value;
                else
                    projekat.DatumZavrsetka = null;

                bool rez;
                if (dodajButtonClicked == false)
                {
                    rez = await DTOManager.IzmeniProjekatAsync(projekat);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Lime;
                        successStatusLabel.Text = "Projekat uspešno ažuriran";
                    }
                    else
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Greška prilikom ažuriranja projekta";
                    }
                }
                else
                {
                    if (projekat.Tip == "Teorijski")
                        postojiProjekat = await DTOManager.PostojiProjekatAsync(projekat.Naziv, projekat.SkolskaGodina, typeof(TeorijskiProjekat));
                    else
                        postojiProjekat = await DTOManager.PostojiProjekatAsync(projekat.Naziv, projekat.SkolskaGodina, typeof(PrakticniProjekat));

                    if (postojiProjekat == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Projekat sa ovim nazivom i ovom školskom godinom već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }

                    rez = await DTOManager.DodajProjekatAsync(projekat);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Lime;
                        successStatusLabel.Text = "Projekat uspešno dodat";
                    }
                    else
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Greška prilikom dodavanja projekta";
                    }

                    projekatDataGridView.Rows.Clear();

                    List<ProjekatPregled>? projekti = DTOManager.VratiSveProjektePregled();
                    if (projekti != null)
                    {
                        foreach (var p in projekti)
                        {
                            projekatDataGridView.Rows.Add(new string[]
                            {
                                p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(),
                                p.MaksimalanBrojStrana?.ToString() ?? string.Empty, p?.PreporuceniProgramskiJezik ?? string.Empty,
                                p?.BrojIzvestaja?.ToString() ?? string.Empty, p.Predmet, p.Tip, p.DatumPocetka.ToString(),
                                p.DatumZavrsetka.ToString() ?? string.Empty, p.KratakOpis ?? string.Empty
                            });
                        }

                        projekatDataGridView.Refresh();
                        projekatDataGridView.ClearSelection();

                        brojProjekataLabel.Text = projekatDataGridView.RowCount.ToString();
                    }

                    timer1.Enabled = true;
                    timer1.Start();
                }
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
        datumZavrsetkaDateTimePicker.Value = rokZaZavrsetakDateTimePicker.Value;
    }

    private async void obrisiToolStripButton_Click(object sender, EventArgs e)
    {
        bool rez = await DTOManager.ObrisiProjekatAsync(Id);
        if (rez == true)
        {
            List<ProjekatPregled>? projekti = DTOManager.VratiSveProjektePregled();
            if (projekti != null)
            {
                projekatDataGridView.Rows.Clear();

                foreach (var p in projekti)
                {
                    projekatDataGridView.Rows.Add(new string[]
                    {
                        p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(),
                        p.MaksimalanBrojStrana?.ToString() ?? string.Empty, p?.PreporuceniProgramskiJezik ?? string.Empty,
                        p.BrojIzvestaja?.ToString() ?? string.Empty, p.Predmet, p.Tip, p.DatumPocetka.ToString(),
                        p.DatumZavrsetka.ToString() ?? string.Empty, p.KratakOpis ?? string.Empty
                    });
                }

                projekatDataGridView.Refresh();
                projekatDataGridView.ClearSelection();

                brojProjekataLabel.Text = projekatDataGridView.RowCount.ToString();

                successStatusLabel.ForeColor = Color.Lime;
                successStatusLabel.Text = "Projekat uspešno obrisan";

                projekatDataGridView.ClearSelection();

                odustaniToolStripButton.Enabled = false;
                sacuvajToolStripButton.Enabled = false;
                
                dodajToolStripButton.Enabled = true;

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
                datumZavrsetkaCheckBox.Checked = false;
                kratakOpisTextBox.Enabled = false;

                nazivProjektaTextBox.Text = string.Empty;
                skolskaGodinaTextBox.Text = string.Empty;
                grupniComboBox.SelectedIndex = -1;
                rokZaZavrsetakDateTimePicker.Value = DateTime.Now.AddMonths(1).AddDays(2);
                maksimalanBrojStranaNumericUpDown.Value = 0;
                preporuceniProgramskiJezikComboBox.SelectedIndex = -1;
                preporuceniProgramskiJezikComboBox.SelectedText = string.Empty;
                brojIzvestajaNumericUpDown.Value = 0;
                predmetComboBox.SelectedIndex = -1;
                tipProjektaComboBox.SelectedIndex = -1;
                datumPocetkaDateTimePicker.Value = DateTime.Now.AddDays(1);
                datumZavrsetkaDateTimePicker.Value = DateTime.Now;
                kratakOpisTextBox.Text = string.Empty;

                nazivProjektaErrorLabel.Text = string.Empty;
                skolskaGodinaErrorLabel.Text = string.Empty;
                grupniErrorLabel.Text = string.Empty;
                rokZaZavrsetakErrorLabel.Text = string.Empty;
                tipProjektaErrorLabel.Text = string.Empty;
                brojIzvestajaErrorLabel.Text = string.Empty;
                predmetErrorLabel.Text = string.Empty;
                maksimalanBrojStranaErrorLabel.Text = string.Empty;
                datumPocetkaErrorLabel.Text = string.Empty;
                datumZavrsetkaErrorLabel.Text = string.Empty;
            }
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja predmeta";
        }

        timer1.Enabled = true;
        timer1.Start();
    }

    private async void pretragaToolStripButton_Click(object sender, EventArgs e)
    {
        if (pretragaPanel.Visible == false)
        {
            pretragaPanel.Visible = true;
            skolskaGodinaPretraziComboBox.Items.Clear();

            List<string>? skolskeGodine = await DTOManager.VratiSkolskeGodine();
            if (skolskeGodine != null)
            {
                foreach (var sg in skolskeGodine)
                {
                    skolskaGodinaPretraziComboBox.Items.Add(sg);
                }
            }
        }
        else
        {
            pretragaPanel.Visible = false;
        }
    }

    private async void tipPretraziComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipPretraziComboBox.SelectedIndex != -1)
        {

            List<string>? predmeti = await DTOManager.VratiPredmetePoTipuProjektaAsync(tipPretraziComboBox.SelectedIndex.ToString());

            if (predmeti != null)
            {
                predmetPretraziComboBox.Enabled = true;
                predmetPretraziComboBox.Items.Clear();
                foreach (var p in predmeti)
                {
                    predmetPretraziComboBox.Items.Add(p);
                }
            }

            if (tipPretraziComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                maksStrCheckBox.Enabled = true;

                progJezikPretraziComboBox.Enabled = false;
                izvestajiCheckBox.Enabled = false;
            }
            else
            {
                maksStrCheckBox.Enabled = false;

                progJezikPretraziComboBox.Enabled = true;
                izvestajiCheckBox.Enabled = true;
            }
        }
        else
        {
            predmetPretraziComboBox.Enabled = false;
            maksStrCheckBox.Enabled = false;
            progJezikPretraziComboBox.Enabled = false;
            izvestajiCheckBox.Enabled = false;
        }
    }

    private void minimizePanelButton_Click(object sender, EventArgs e)
    {
        pretragaPanel.Visible = false;
    }

    private async void pretraziButton_Click(object sender, EventArgs e)
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

                IList<Projekat> projekti = await query.ToListAsync();
                if (tipPretraziComboBox.SelectedItem != null)
                {
                    if (tipPretraziComboBox.SelectedItem!.ToString() == "Teorijski")
                        projekti = projekti.Where(p => p.GetType() == typeof(TeorijskiProjekat)).ToList();
                    else
                        projekti = projekti.Where(p => p.GetType() == typeof(PrakticniProjekat)).ToList();
                }

                foreach (var p in projekti)
                {
                    if (p.GetType() == typeof(TeorijskiProjekat))
                    {
                        projekatDataGridView.Rows.Add(new string[]
                        {
                            p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(), p ?.MaksimalanBrojStrana.ToString() ?? string.Empty,
                            p?.PreporuceniProgramskiJezik ?? string.Empty, p?.BrojIzvestaja.ToString() ?? string.Empty, p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")", "Teorijski", p.DatumPocetka.ToString(),
                            p?.DatumZavrsetka.ToString() ?? string.Empty, p?.KratakOpis ?? string.Empty
                        });
                    }
                    else
                    {
                        projekatDataGridView.Rows.Add(new string[]
                        {
                            p.Id.ToString(), p.Naziv, p.SkolskaGodina, p.Grupni, p.RokZaZavrsetak.ToString(), p ?.MaksimalanBrojStrana.ToString() ?? string.Empty,
                            p?.PreporuceniProgramskiJezik ?? string.Empty, p?.BrojIzvestaja.ToString() ?? string.Empty, p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")", "Praktični", p.DatumPocetka.ToString(),
                            p?.DatumZavrsetka.ToString() ?? string.Empty, p?.KratakOpis ?? string.Empty
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
        predmetPretraziComboBox.SelectedIndex = -1;
        pocetakCheckBox.Checked = false;
        pocetakPretraziDateTimePicker.Value = DateTime.Now;
        pocetakManjeVeceButton.Text = "<";

        predmetPretraziComboBox.Enabled = false;
    }

    private void tipProjektaComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                maksimalanBrojStranaNumericUpDown.Enabled = true;

                brojIzvestajaNumericUpDown.Enabled = false;
                kratakOpisTextBox.Enabled = false;
                preporuceniProgramskiJezikComboBox.Enabled = false;
            }
            else
            {
                maksimalanBrojStranaNumericUpDown.Enabled = false;

                brojIzvestajaNumericUpDown.Enabled = true;
                kratakOpisTextBox.Enabled = true;
                preporuceniProgramskiJezikComboBox.Enabled = true;
            }
        }
    }

    private void tipProjektaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                maksimalanBrojStranaNumericUpDown.Enabled = true;

                brojIzvestajaNumericUpDown.Enabled = false;
                kratakOpisTextBox.Enabled = false;
                preporuceniProgramskiJezikComboBox.Enabled = false;
            }
            else
            {
                maksimalanBrojStranaNumericUpDown.Enabled = false;

                brojIzvestajaNumericUpDown.Enabled = true;
                kratakOpisTextBox.Enabled = true;
                preporuceniProgramskiJezikComboBox.Enabled = true;
            }
        }
    }

    private void datumZavrsetkaCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (datumZavrsetkaCheckBox.Checked == true)
            datumZavrsetkaDateTimePicker.Enabled = true;
        else
            datumZavrsetkaDateTimePicker.Enabled = false;
    }
}
