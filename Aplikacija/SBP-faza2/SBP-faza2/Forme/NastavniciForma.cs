using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class NastavniciForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public NastavniciForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvana nova grupa";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        imePrezimeNastavnikaTextBox.Enabled = true;
        predmetComboBox.Enabled = true;

        imePrezimeNastavnikaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        if (nastavnikDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
        }

        imePrezimeNastavnikaTextBox.Enabled = false;
        predmetComboBox.Enabled = false;

        imePrezimeNastavnikaTextBox.Text = string.Empty;
        predmetComboBox.SelectedIndex = -1;

        imePrezimeNastavnikaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
    }

    private void nastavnikDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (nastavnikDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(nastavnikDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        imePrezimeNastavnikaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
    }

    private void NastavniciForma_Activated(object sender, EventArgs e)
    {
        PopuniComboBoxPredmetima();
        DodajNastavnikeDataGridView();
    }

    private void PopuniComboBoxPredmetima()
    {
        List<PredmetBasic>? predmeti = DTOManager.VratiPredmeteBasic();
        if (predmeti != null)
        {
            predmetComboBox.Items.Clear();
            foreach (var p in predmeti)
            {
                predmetComboBox.Items.Add(p.Naziv + " " + "(" + p.Sifra + ")");
            }
        }
    }

    private void DodajNastavnikeDataGridView()
    {
        List<NastavnikPregled>? nastavnici = DTOManager.VratiNastavnikePregled();
        if (nastavnici != null)
        {
            nastavnikDataGridView.Rows.Clear();

            foreach (var n in nastavnici)
            {
                nastavnikDataGridView.Rows.Add(new string[]
                { n.Id.ToString(), n.ImePrezime, n.Predmet });
            }

            nastavnikDataGridView.Refresh();
            nastavnikDataGridView.ClearSelection();

            brojNastavnikaLabel.Text = nastavnikDataGridView.RowCount.ToString();
        }
    }

    private void nastavnikDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

            DataGridViewRow row = nastavnikDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

            imePrezimeNastavnikaTextBox.Text = row.Cells["imePrezimeColumn"].Value.ToString();
            predmetComboBox.SelectedItem = row.Cells["predmetColumn"].Value.ToString();

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            imePrezimeNastavnikaTextBox.Enabled = true;
            predmetComboBox.Enabled = true;

            imePrezimeNastavnikaErrorLabel.Text = string.Empty;
            predmetErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (imePrezimeNastavnikaTextBox.Text.Trim().Length < 2)
        {
            result = false;
            imePrezimeNastavnikaErrorLabel.Text = "Ime i prezime nastavnika mora da bude najmanje 2 karaktera";
        }
        else imePrezimeNastavnikaErrorLabel.Text = string.Empty;

        if (predmetComboBox.SelectedItem == null)
        {
            result = false;
            predmetErrorLabel.Text = "Predmet mora da bude naveden";
        }
        else predmetErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

        DataGridViewRow row = nastavnikDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

        imePrezimeNastavnikaTextBox.Text = row.Cells["imePrezimeColumn"].Value.ToString();
        predmetComboBox.SelectedItem = row.Cells["predmetColumn"].Value.ToString();

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        imePrezimeNastavnikaTextBox.Enabled = true;
        predmetComboBox.Enabled = true;

        imePrezimeNastavnikaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            string[] predmetSifra = predmetComboBox.SelectedItem!.ToString()!.Split('(');
            string nazivPredmeta = predmetSifra[0];
            string sifraPredmeta = predmetSifra[1];

            nazivPredmeta = nazivPredmeta.Substring(0, nazivPredmeta.Length - 1);
            sifraPredmeta = sifraPredmeta.Substring(0, sifraPredmeta.Length - 1);
            PredmetBasic predmetBasic = (await DTOManager.VratiPredmetBasicAsync(nazivPredmeta, sifraPredmeta))!;
            NastavnikBasic nastavnik = new NastavnikBasic
            {
                Id = Id,
                ImePrezime = imePrezimeNastavnikaTextBox.Text.Trim(),
                Predmet = predmetBasic
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                rez = await DTOManager.IzmeniNastavnikaAsync(nastavnik);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Nastavnik uspešno ažuriran";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja nastavnika";
                }
            }
            else
            {
                rez = await DTOManager.DodajNastavnikAsync(nastavnik);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Nastavnik uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja nastavnika";
                }
            }

            DodajNastavnikeDataGridView();

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
        bool rez = await DTOManager.ObrisiNastavnikAsync(Id);
        if (rez == true)
        {
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Text = "Nastavnik uspešno obrisan";
            DodajNastavnikeDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja nastavnika";
        }

        timer1.Enabled = true;
        timer1.Start();

        imePrezimeNastavnikaTextBox.Text = string.Empty;
        predmetComboBox.SelectedIndex = -1;

        imePrezimeNastavnikaTextBox.Enabled = false;
        predmetComboBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        imePrezimeNastavnikaErrorLabel.Text = string.Empty;
        predmetErrorLabel.Text = string.Empty;
    }
}
