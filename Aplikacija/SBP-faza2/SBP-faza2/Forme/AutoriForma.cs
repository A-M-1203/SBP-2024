namespace SBP_faza2.Forme;

public partial class AutoriForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public AutoriForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvan novi autor";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        imeAutoraTextBox.Enabled = true;
        knjigaComboBox.Enabled = true;
        clanakComboBox.Enabled = true;
        radComboBox.Enabled = true;

        imeAutoraErrorLabel.Text = string.Empty;
        knjigaErrorLabel.Text = string.Empty;
        clanakErrorLabel.Text = string.Empty;
        radErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        imeAutoraTextBox.Enabled = false;
        knjigaComboBox.Enabled = false;
        clanakComboBox.Enabled = false;
        radComboBox.Enabled = false;

        imeAutoraTextBox.Text = string.Empty;
        knjigaComboBox.SelectedIndex = -1;
        clanakComboBox.SelectedIndex = -1;
        radComboBox.SelectedIndex = -1;

        imeAutoraErrorLabel.Text = string.Empty;
        knjigaErrorLabel.Text = string.Empty;
        clanakErrorLabel.Text = string.Empty;
        radErrorLabel.Text = string.Empty;
    }

    private void autorDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (autorDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(autorDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        imeAutoraErrorLabel.Text = string.Empty;
        knjigaErrorLabel.Text = string.Empty;
        clanakErrorLabel.Text = string.Empty;
        radErrorLabel.Text = string.Empty;
    }

    private void AutoriForma_Activated(object sender, EventArgs e)
    {
        DodajAutoreDataGridView();
        PopuniComboBoxeve();
    }

    private void PopuniComboBoxeve()
    {
        List<string>? nasloviISBN = DTOManager.VratiNasloveKnjigaISBN();
        if (nasloviISBN != null)
        {
            knjigaComboBox.Items.Clear();
            foreach (var n in nasloviISBN)
                knjigaComboBox.Items.Add(n);
        }

        List<string>? nasloviISSN = DTOManager.VratiNasloveClanakaISSN();
        if (nasloviISSN != null)
        {
            clanakComboBox.Items.Clear();
            foreach (var n in nasloviISSN)
                clanakComboBox.Items.Add(n);
        }

        List<string>? nasloviRadova = DTOManager.VratiNasloveRadova();
        if (nasloviRadova != null)
        {
            radComboBox.Items.Clear();
            foreach (var n in nasloviRadova)
                radComboBox.Items.Add(n);
        }
    }

    private void DodajAutoreDataGridView()
    {
        List<AutorPregled>? autori = DTOManager.VratiAutorePregled();
        if (autori != null)
        {
            autorDataGridView.Rows.Clear();

            foreach (var a in autori)
            {
                autorDataGridView.Rows.Add(new string[]
                { a.Id.ToString(), a.ImeAutora, a?.Knjiga ?? string.Empty,
                    a?.Clanak ?? string.Empty, a?.Rad ?? string.Empty });
            }

            autorDataGridView.Refresh();
            autorDataGridView.ClearSelection();

            brojAutoraLabel.Text = autorDataGridView.RowCount.ToString();
        }
    }

    private void autorDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći autor";

            DataGridViewRow row = autorDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

            imeAutoraTextBox.Text = row.Cells["imeAutoraColumn"].Value.ToString();

            string? knjiga = row.Cells["knjigaColumn"].Value.ToString();
            if (string.IsNullOrEmpty(knjiga))
                knjigaComboBox.SelectedIndex = -1;
            else
                knjigaComboBox.SelectedItem = knjiga;

            string? clanak = row.Cells["clanakColumn"].Value.ToString();
            if (string.IsNullOrEmpty(clanak))
                clanakComboBox.SelectedIndex = -1;
            else
                clanakComboBox.SelectedItem = clanak;

            string? rad = row.Cells["radColumn"].Value.ToString();
            if (string.IsNullOrEmpty(rad))
                radComboBox.SelectedIndex = -1;
            else
                radComboBox.Text = rad;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            imeAutoraTextBox.Enabled = true;
            knjigaComboBox.Enabled = true;
            clanakComboBox.Enabled = true;
            radComboBox.Enabled = true;

            imeAutoraErrorLabel.Text = string.Empty;
            knjigaErrorLabel.Text = string.Empty;
            clanakErrorLabel.Text = string.Empty;
            radErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (imeAutoraTextBox.Text.Trim().Length < 1)
        {
            result = false;
            imeAutoraErrorLabel.Text = "Ime autora mora biti navedeno";
        }
        else imeAutoraErrorLabel.Text = string.Empty;

        if (knjigaComboBox.SelectedItem == null && clanakComboBox.SelectedItem == null
            && radComboBox.SelectedItem == null)
        {
            result = false;
            knjigaErrorLabel.Text = "Mora da se odabere knjiga, clanak ili rad";
            clanakErrorLabel.Text = "Mora da se odabere knjiga, clanak ili rad";
            radErrorLabel.Text = "Mora da se odabere knjiga, clanak ili rad";
        }
        else
        {
            knjigaErrorLabel.Text = string.Empty;
            clanakErrorLabel.Text = string.Empty;
            radErrorLabel.Text = string.Empty;
        }

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći autor";

        DataGridViewRow row = autorDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

        imeAutoraTextBox.Text = row.Cells["imeAutoraColumn"].Value.ToString();
        knjigaComboBox.SelectedItem = row.Cells["knjigaColumn"].Value.ToString();
        clanakComboBox.SelectedItem = row.Cells["clanakColumn"].Value.ToString();
        radComboBox.Text = row.Cells["radColumn"].Value.ToString();

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        imeAutoraTextBox.Enabled = true;
        knjigaComboBox.Enabled = true;
        clanakComboBox.Enabled = true;
        radComboBox.Enabled = true;

        imeAutoraErrorLabel.Text = string.Empty;
        knjigaErrorLabel.Text = string.Empty;
        clanakErrorLabel.Text = string.Empty;
        radErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojAutor;
            KnjigaBasic? knjiga = null;
            ClanakBasic? clanak = null;
            RadBasic? rad = null;

            if (knjigaComboBox.SelectedItem != null)
            {
                string? isbn = IzdvojiIzZagrada(knjigaComboBox.SelectedItem.ToString()!);
                if (isbn != null)
                    knjiga = DTOManager.VratiKnjigaBasicPoISBN(isbn);
            }
            if (clanakComboBox.SelectedItem != null)
            {
                string? issn = IzdvojiIzZagrada(clanakComboBox.SelectedItem.ToString()!);
                if (issn != null)
                    clanak = DTOManager.VratiClanakBasicPoISSN(issn);
            }
            if (radComboBox.SelectedItem != null)
            {
                rad = DTOManager.VratiRadBasicPoNaslovu(radComboBox.SelectedItem.ToString()!);
            }

            AutorBasic autor = new AutorBasic
            {
                Id = Id,
                ImeAutora = imeAutoraTextBox.Text.Trim(),
                Knjiga = knjiga,
                Clanak = clanak,
                Rad = rad
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                AutorBasic? autorZaProveru = await DTOManager.VratiAutorBasicAsync(Id);
                if (autorZaProveru != null)
                {
                    if (autorZaProveru.ImeAutora != autor.ImeAutora)
                    {
                        rez = await DTOManager.PostojiAutorAsync(autor.ImeAutora);
                        if (rez == true)
                        {
                            successStatusLabel.ForeColor = Color.Red;
                            successStatusLabel.Text = "Autor sa ovim imenom već postoji";

                            timer1.Enabled = true;
                            timer1.Start();
                            return;
                        }
                    }
                }

                rez = await DTOManager.IzmeniAutoraAsync(autor);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Autor uspešno ažurirana";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja autora";
                }
            }
            else
            {
                postojAutor = await DTOManager.PostojiAutorAsync(autor.ImeAutora);
                if (postojAutor == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Autor sa ovim imenom već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajAutoraAsync(autor);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Autor uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja autora";
                }
            }

            DodajAutoreDataGridView();

            timer1.Enabled = true;
            timer1.Start();
        }
    }

    private string? IzdvojiIzZagrada(string input)
    {
        int startIndex = input.IndexOf('(');
        int endIndex = input.IndexOf(')');

        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
        {
            string result = input.Substring(startIndex + 1, endIndex - startIndex - 1);
            return result;
        }

        return null;
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
        bool rez = await DTOManager.ObrisiAutoraAsync(Id);
        if (rez == true)
        {
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Text = "Autor uspešno obrisan";
            DodajAutoreDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja autora";
        }

        timer1.Enabled = true;
        timer1.Start();

        imeAutoraTextBox.Text = string.Empty;
        knjigaComboBox.SelectedIndex = -1;
        clanakComboBox.SelectedIndex = -1;
        radComboBox.SelectedIndex = -1;

        imeAutoraTextBox.Enabled = false;
        knjigaComboBox.Enabled = false;
        clanakComboBox.Enabled = false;
        radComboBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        imeAutoraErrorLabel.Text = string.Empty;
        knjigaErrorLabel.Text = string.Empty;
        clanakErrorLabel.Text = string.Empty;
        radErrorLabel.Text = string.Empty;
    }
}
