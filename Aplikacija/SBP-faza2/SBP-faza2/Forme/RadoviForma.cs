using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class RadoviForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public RadoviForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvan novi rad";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        naslovTextBox.Enabled = true;
        godinaIzdanjaTextBox.Enabled = true;
        nazivKonferencijeTextBox.Enabled = true;
        urlTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivKonferencijeErrorLabel.Text = string.Empty;
        urlErrorLabel.Text = string.Empty;
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
        nazivKonferencijeTextBox.Enabled = false;
        urlTextBox.Enabled = false;

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        nazivKonferencijeTextBox.Text = string.Empty;
        urlTextBox.Text = string.Empty;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivKonferencijeErrorLabel.Text = string.Empty;
        urlErrorLabel.Text = string.Empty;
    }

    private void radDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (radDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(radDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivKonferencijeErrorLabel.Text = string.Empty;
        urlErrorLabel.Text = string.Empty;
    }

    private void RadoviForma_Activated(object sender, EventArgs e)
    {
        DodajRadoveDataGridView();
    }

    private void DodajRadoveDataGridView()
    {
        List<RadBasic>? radovi = DTOManager.VratiRadoveBasic();
        if (radovi != null)
        {
            radDataGridView.Rows.Clear();

            foreach (var r in radovi)
            {
                radDataGridView.Rows.Add(new string[]
                { r.Id.ToString(), r.Naslov, r.GodinaIzdanja.ToString(),
                    r?.NazivKonferencije ?? string.Empty, r?.URL ?? string.Empty });
            }

            radDataGridView.Refresh();
            radDataGridView.ClearSelection();

            brojRadovaLabel.Text = radDataGridView.RowCount.ToString();
        }
    }

    private void radDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći rad";

            DataGridViewRow row = radDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

            naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
            godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
            nazivKonferencijeTextBox.Text = row.Cells["nazivKonferencijeColumn"].Value.ToString();
            urlErrorLabel.Text = row.Cells["urlColumn"].Value.ToString();

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            naslovTextBox.Enabled = true;
            godinaIzdanjaTextBox.Enabled = true;
            nazivKonferencijeTextBox.Enabled = true;
            urlTextBox.Enabled = true;

            naslovErrorLabel.Text = string.Empty;
            godinaIzdanjaErrorLabel.Text = string.Empty;
            nazivKonferencijeErrorLabel.Text = string.Empty;
            urlErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (naslovTextBox.Text.Trim().Length < 1)
        {
            result = false;
            naslovErrorLabel.Text = "Naslov rada mora biti naveden";
        }
        else naslovErrorLabel.Text = string.Empty;

        if (godinaIzdanjaTextBox.Text.Length < 4 || int.Parse(godinaIzdanjaTextBox.Text) > DateTime.Now.Year)
        {
            result = false;
            godinaIzdanjaErrorLabel.Text = "Nevalidna godina izdanja";
        }
        else godinaIzdanjaErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći rad";

        DataGridViewRow row = radDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);

        naslovTextBox.Text = row.Cells["naslovColumn"].Value.ToString();
        godinaIzdanjaTextBox.Text = row.Cells["godinaIzdanjaColumn"].Value.ToString();
        nazivKonferencijeTextBox.Text = row.Cells["nazivKonferencijeColumn"].Value.ToString();
        urlErrorLabel.Text = row.Cells["urlColumn"].Value.ToString();

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        naslovTextBox.Enabled = true;
        godinaIzdanjaTextBox.Enabled = true;
        nazivKonferencijeTextBox.Enabled = true;
        urlTextBox.Enabled = true;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivKonferencijeErrorLabel.Text = string.Empty;
        urlErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiRad;
            RadBasic rad = new RadBasic
            {
                Id = Id,
                Naslov = naslovTextBox.Text.Trim(),
                GodinaIzdanja = int.Parse(godinaIzdanjaTextBox.Text),
                NazivKonferencije = (nazivKonferencijeTextBox.Text == string.Empty) ? null : nazivKonferencijeTextBox.Text,
                URL = (urlTextBox.Text == string.Empty) ? null : urlTextBox.Text
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                RadBasic? radZaProveru = await DTOManager.VratiRadBasicAsync(Id);
                if (radZaProveru!.Naslov != rad.Naslov && radZaProveru.GodinaIzdanja != rad.GodinaIzdanja)
                {
                    rez = await DTOManager.PostojiRadAsync(rad.Naslov, rad.GodinaIzdanja);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Rad sa ovim naslovom i godinom izdanja već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniRadAsync(rad);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Rad uspešno ažurirana";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja rada";
                }
            }
            else
            {
                postojiRad = await DTOManager.PostojiRadAsync(rad.Naslov, rad.GodinaIzdanja);
                if (postojiRad == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Rad sa ovim naslovom i godinom izdanja već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajRadAsync(rad);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Rad uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja rada";
                }
            }

            DodajRadoveDataGridView();

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
        bool rez = await DTOManager.ObrisiRadAsync(Id);
        if (rez == true)
        {
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Text = "Rad uspešno obrisan";
            DodajRadoveDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja rada";
        }

        timer1.Enabled = true;
        timer1.Start();

        naslovTextBox.Text = string.Empty;
        godinaIzdanjaTextBox.Text = string.Empty;
        nazivKonferencijeTextBox.Text = string.Empty;
        urlTextBox.Text = string.Empty;

        naslovTextBox.Enabled = false;
        godinaIzdanjaTextBox.Enabled = false;
        nazivKonferencijeTextBox.Enabled = false;
        urlTextBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        naslovErrorLabel.Text = string.Empty;
        godinaIzdanjaErrorLabel.Text = string.Empty;
        nazivKonferencijeErrorLabel.Text = string.Empty;
        urlErrorLabel.Text = string.Empty;
    }
}
