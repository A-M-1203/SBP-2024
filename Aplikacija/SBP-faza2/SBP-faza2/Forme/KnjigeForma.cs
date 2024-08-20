using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class KnjigeForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public KnjigeForma()
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
        isbnMaskedTextBox.Enabled = true;
        izdavacTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        isbnErrorLabel.Text = string.Empty;
        izdavacErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        knjigaDataGridView.ClearSelection();

        naslovTextBox.Enabled = false;
        godinaIzdanjaTextBox.Enabled = false;
        isbnMaskedTextBox.Enabled = false;
        izdavacTextBox.Enabled = false;

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        isbnMaskedTextBox.Text = string.Empty;
        izdavacTextBox.Text = string.Empty;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        isbnErrorLabel.Text = string.Empty;
        izdavacErrorLabel.Text = string.Empty;

    }

    private void knjigaDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (knjigaDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(knjigaDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
            sacuvajToolStripButton.Enabled = false;
        }

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        isbnErrorLabel.Text = string.Empty;
        izdavacErrorLabel.Text = string.Empty;
    }

    private void KnjigeForma_Activated(object sender, EventArgs e)
    {
        DodajKnjigeDataGridView();
    }

    private void DodajKnjigeDataGridView()
    {
        List<KnjigaBasic>? knjige = DTOManager.VratiKnjigeBasic();
        if (knjige != null)
        {
            knjigaDataGridView.Rows.Clear();

            foreach (var k in knjige)
            {
                knjigaDataGridView.Rows.Add(new string[]
                { k.Id.ToString(), k.Naslov, k.GodinaIzdanja.ToString(), k.ISBN, k.Izdavac });
            }

            knjigaDataGridView.Refresh();
            knjigaDataGridView.ClearSelection();

            brojKnjigaLabel.Text = knjigaDataGridView.RowCount.ToString();
        }
    }

    private void knjigaDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća knjiga";

            DataGridViewRow row = knjigaDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

            naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
            godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
            isbnMaskedTextBox.Text = row.Cells["isbnColumn"].Value.ToString();
            izdavacTextBox.Text = row.Cells["izdavacColumn"].Value.ToString();

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            naslovTextBox.Enabled = true;
            godinaIzdanjaTextBox.Enabled = true;
            isbnMaskedTextBox.Enabled = true;
            izdavacTextBox.Enabled = true;

            naslovErrorLabel.Text = string.Empty;
            godinaIzdanjaErrorLabel.Text = string.Empty;
            isbnErrorLabel.Text = string.Empty;
            izdavacErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (naslovTextBox.Text.Trim().Length < 1)
        {
            result = false;
            naslovErrorLabel.Text = "Naslov knjige mora biti naveden";
        }
        else naslovErrorLabel.Text = string.Empty;

        if (godinaIzdanjaTextBox.Text.Length < 4 || int.Parse(godinaIzdanjaTextBox.Text) > DateTime.Now.Year)
        {
            result = false;
            godinaIzdanjaErrorLabel.Text = "Nevalidna godina izdanja";
        }
        else godinaIzdanjaErrorLabel.Text = string.Empty;

        isbnMaskedTextBox.TextMaskFormat  = MaskFormat.ExcludePromptAndLiterals;
        if (isbnMaskedTextBox.Text.Length < 13)
        {
            result = false;
            isbnErrorLabel.Text = "ISBN mora da ima 13 cifara";
        }
        else isbnErrorLabel.Text = string.Empty;
        isbnMaskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

        if (izdavacTextBox.Text.Trim().Length < 1)
        {
            result = false;
            izdavacErrorLabel.Text = "Izdavač mora biti naveden";
        }
        else izdavacErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća knjiga";

        DataGridViewRow row = knjigaDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

        naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
        godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
        isbnMaskedTextBox.Text = row.Cells["isbnColumn"].Value.ToString();
        izdavacTextBox.Text = row.Cells["izdavacColumn"].Value.ToString();

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        naslovTextBox.Enabled = true;
        godinaIzdanjaTextBox.Enabled = true;
        isbnMaskedTextBox.Enabled = true;
        izdavacTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        isbnErrorLabel.Text = string.Empty;
        izdavacErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiKnjiga;
            KnjigaBasic knjiga = new KnjigaBasic
            {
                Id = Id,
                Naslov = naslovTextBox.Text.Trim(),
                GodinaIzdanja = int.Parse(godinaIzdanjaTextBox.Text),
                ISBN = isbnMaskedTextBox.Text,
                Izdavac = izdavacTextBox.Text.Trim()
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                KnjigaBasic? knjigaZaProveru = await DTOManager.VratiKnjigaBasicAsync(Id);
                if (knjigaZaProveru!.Naslov != knjiga.Naslov && knjigaZaProveru.GodinaIzdanja != knjiga.GodinaIzdanja)
                {
                    rez = await DTOManager.PostojiKnjigaAsync(knjiga.ISBN);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Knjiga sa ovim ISBN već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniKnjiguAsync(knjiga);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Knjiga uspešno ažurirana";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja knjige";
                }
            }
            else
            {
                postojiKnjiga = await DTOManager.PostojiKnjigaAsync(knjiga.ISBN);
                if (postojiKnjiga == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Knjiga sa ovim ISBN već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajKnjiguAsync(knjiga);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Knjiga uspešno dodata";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja knjige";
                }
            }

            DodajKnjigeDataGridView();

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
        bool rez = await DTOManager.ObrisiKnjiguAsync(Id);
        if (rez == true)
        {
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Text = "Knjiga uspešno obrisana";
            DodajKnjigeDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja knjige";
        }

        timer1.Enabled = true;
        timer1.Start();

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        isbnMaskedTextBox.Text = string.Empty;
        izdavacTextBox.Text = string.Empty;

        naslovTextBox.Enabled = false;
        godinaIzdanjaTextBox.Enabled = false;
        isbnMaskedTextBox.Enabled = false;
        izdavacTextBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        isbnErrorLabel.Text = string.Empty;
        izdavacErrorLabel.Text = string.Empty;
    }
}
