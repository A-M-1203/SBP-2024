namespace SBP_faza2.Forme;

public partial class ClanciForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public ClanciForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvana nova knjiga";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        naslovTextBox.Enabled = true;
        godinaIzdanjaTextBox.Enabled = true;
        nazivCasopisaTextBox.Enabled = true;
        brojCasopisaTextBox.Enabled = true;
        issnMaskedTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivCasopisaErrorLabel.Text = string.Empty;
        brojCasopisaErrorLabel.Text = string.Empty;
        issnErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        naslovTextBox.Enabled = false;
        godinaIzdanjaTextBox.Enabled = false;
        nazivCasopisaTextBox.Enabled = false;
        brojCasopisaTextBox.Enabled = false;
        issnMaskedTextBox.Enabled = false;

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        nazivCasopisaTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        issnMaskedTextBox.Text = string.Empty;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivCasopisaErrorLabel.Text = string.Empty;
        brojCasopisaErrorLabel.Text = string.Empty;
        issnErrorLabel.Text = string.Empty;
    }

    private void clanakDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (clanakDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(clanakDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivCasopisaErrorLabel.Text = string.Empty;
        brojCasopisaErrorLabel.Text = string.Empty;
        issnErrorLabel.Text = string.Empty;
    }

    private void ClanciForma_Activated(object sender, EventArgs e)
    {
        DodajClankeDataGridView();
    }

    private void DodajClankeDataGridView()
    {
        List<ClanakBasic>? clanci = DTOManager.VratiClankeBasic();
        if (clanci != null)
        {
            clanakDataGridView.Rows.Clear();

            foreach (var c in clanci)
            {
                clanakDataGridView.Rows.Add(new string[]
                { c.Id.ToString(), c.Naslov, c.GodinaIzdanja.ToString(),
                    c.NazivCasopisa, c.BrojCasopisa.ToString(), c.ISSN });
            }

            clanakDataGridView.Refresh();
            clanakDataGridView.ClearSelection();

            brojClanakaLabel.Text = clanakDataGridView.RowCount.ToString();
        }
    }

    private void clanakDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći članak";

            DataGridViewRow row = clanakDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

            naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
            godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
            nazivCasopisaTextBox.Text = row.Cells["nazivCasopisaColumn"].Value.ToString();
            brojCasopisaTextBox.Text = row.Cells["brojCasopisaColumn"].Value.ToString();
            issnMaskedTextBox.Text = row.Cells["issnColumn"].Value.ToString();

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            naslovTextBox.Enabled = true;
            godinaIzdanjaTextBox.Enabled = true;
            nazivCasopisaTextBox.Enabled = true;
            brojCasopisaTextBox.Enabled = true;
            issnMaskedTextBox.Enabled = true;

            naslovErrorLabel.Text = string.Empty;
            godinaIzdanjaErrorLabel.Text = string.Empty;
            nazivCasopisaErrorLabel.Text = string.Empty;
            brojCasopisaErrorLabel.Text = string.Empty;
            issnErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (naslovTextBox.Text.Trim().Length < 1)
        {
            result = false;
            naslovErrorLabel.Text = "Naslov članka mora biti naveden";
        }
        else naslovErrorLabel.Text = string.Empty;

        if (godinaIzdanjaTextBox.Text.Length < 4 || int.Parse(godinaIzdanjaTextBox.Text) > DateTime.Now.Year)
        {
            result = false;
            godinaIzdanjaErrorLabel.Text = "Nevalidna godina izdanja";
        }
        else godinaIzdanjaErrorLabel.Text = string.Empty;

        if (nazivCasopisaTextBox.Text.Trim().Length < 1)
        {
            result = false;
            nazivCasopisaErrorLabel.Text = "Naziv časopisa mora biti naveden";
        }
        else nazivCasopisaErrorLabel.Text = string.Empty;

        if (brojCasopisaTextBox.Text.Length < 1 || brojCasopisaTextBox.Text == "0" || !int.TryParse(brojCasopisaTextBox.Text, out int rez))
        {
            result = false;
            brojCasopisaErrorLabel.Text = "Nevalidan broj časopisa";
        }
        else brojCasopisaErrorLabel.Text = string.Empty;

        issnMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        if (issnMaskedTextBox.Text.Length < 8)
        {
            result = false;
            issnErrorLabel.Text = "ISSN mora da ima 8 cifara";
        }
        else issnErrorLabel.Text = string.Empty;
        issnMaskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći članak";

        DataGridViewRow row = clanakDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

        naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
        godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
        nazivCasopisaTextBox.Text = row.Cells["nazivCasopisaColumn"].Value.ToString();
        brojCasopisaTextBox.Text = row.Cells["brojCasopisaColumn"].Value.ToString();
        issnMaskedTextBox.Text = row.Cells["issnColumn"].Value.ToString();

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        naslovTextBox.Enabled = true;
        godinaIzdanjaTextBox.Enabled = true;
        nazivCasopisaTextBox.Enabled = true;
        brojCasopisaTextBox.Enabled = true;
        issnMaskedTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivCasopisaErrorLabel.Text = string.Empty;
        brojCasopisaErrorLabel.Text = string.Empty;
        issnErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiClanak;
            ClanakBasic clanak = new ClanakBasic
            {
                Id = Id,
                Naslov = naslovTextBox.Text.Trim(),
                GodinaIzdanja = int.Parse(godinaIzdanjaTextBox.Text),
                NazivCasopisa = nazivCasopisaTextBox.Text.Trim(),
                BrojCasopisa = int.Parse(brojCasopisaTextBox.Text),
                ISSN = issnMaskedTextBox.Text
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                ClanakBasic? clanakZaProveru = await DTOManager.VratiClanakBasicAsync(Id);
                if (clanakZaProveru!.Naslov != clanak.Naslov && clanakZaProveru.GodinaIzdanja != clanak.GodinaIzdanja)
                {
                    rez = await DTOManager.PostojiClanakAsync(clanak.ISSN);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Članak sa ovim ISSN već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniClanakAsync(clanak);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Članak uspešno ažurirana";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja članka";
                }
            }
            else
            {
                postojiClanak = await DTOManager.PostojiClanakAsync(clanak.ISSN);
                if (postojiClanak == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Članak sa ovim ISSN već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajClanakAsync(clanak);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Članak uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja članka";
                }
            }

            DodajClankeDataGridView();

            timer1.Enabled = true;
            timer1.Start();
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        timer1.Stop();
        timer1.Enabled = false;
    }

    private async void obrisiToolStripButton_Click(object sender, EventArgs e)
    {
        bool rez = await DTOManager.ObrisiClanakAsync(Id);
        if (rez == true)
        {
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Text = "Članak uspešno obrisana";
            DodajClankeDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja članka";
        }

        timer1.Enabled = true;
        timer1.Start();

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        nazivCasopisaTextBox.Text = string.Empty;
        brojCasopisaTextBox.Text = string.Empty;
        issnMaskedTextBox.Text = string.Empty;

        naslovTextBox.Enabled = false;
        godinaIzdanjaTextBox.Enabled = false;
        nazivCasopisaTextBox.Enabled = false;
        brojCasopisaTextBox.Enabled = false;
        issnMaskedTextBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivCasopisaErrorLabel.Text = string.Empty;
        brojCasopisaErrorLabel.Text = string.Empty;
        issnErrorLabel.Text = string.Empty;
    }
}
