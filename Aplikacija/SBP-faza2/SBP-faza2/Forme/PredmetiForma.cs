using NHibernate.Criterion;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Data;
using NHibernate.Linq;

namespace SBP_faza2.Forme;

public partial class PredmetiForma : Form
{
    private long Id = 0;
    private bool dodajButtonClicked = false;
    public PredmetiForma()
    {
        InitializeComponent();
    }

    private void dodajPredmetToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvan novi predmet";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        sifraPredmetaTextBox.Enabled = true;
        nazivPredmetaTextBox.Enabled = true;
        katedraComboBox.Enabled = true;
        semestarComboBox.Enabled = true;

        sifraPredmetaErrorLabel.Text = string.Empty;
        nazivPredmetaErrorLabel.Text = string.Empty;
        katedraErrorLabel.Text = string.Empty;
        semestarErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        if (predmetDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
        }

        sifraPredmetaTextBox.Enabled = false;
        nazivPredmetaTextBox.Enabled = false;
        katedraComboBox.Enabled = false;
        semestarComboBox.Enabled = false;

        sifraPredmetaTextBox.Text = string.Empty;
        nazivPredmetaTextBox.Text = string.Empty;
        katedraComboBox.SelectedIndex = -1;
        semestarComboBox.SelectedIndex = -1;

        sifraPredmetaErrorLabel.Text = string.Empty;
        nazivPredmetaErrorLabel.Text = string.Empty;
        katedraErrorLabel.Text = string.Empty;
        semestarErrorLabel.Text = string.Empty;
    }

    private void predmetDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (predmetDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = long.Parse(predmetDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        sifraPredmetaErrorLabel.Text = string.Empty;
        nazivPredmetaErrorLabel.Text = string.Empty;
        katedraErrorLabel.Text = string.Empty;
        semestarErrorLabel.Text = string.Empty;
    }

    private void PredmetiForma_Activated(object sender, EventArgs e)
    {
        List<PredmetBasic>? predmeti = DTOManager.VratiPredmeteBasic();
        if (predmeti != null)
        {
            predmetDataGridView.Rows.Clear();

            foreach (var p in predmeti)
            {
                predmetDataGridView.Rows.Add(new string[]
                { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
            }

            predmetDataGridView.Refresh();
            predmetDataGridView.ClearSelection();

            brojPredmetaLabel.Text = predmetDataGridView.RowCount.ToString();
        }
    }

    private void sifraPredmetaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (!char.IsLetterOrDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void sifraPredmetaTextBox_TextChanged(object sender, EventArgs e)
    {
        int selectionStart = sifraPredmetaTextBox.SelectionStart;
        sifraPredmetaTextBox.Text = sifraPredmetaTextBox.Text.ToUpper();
        sifraPredmetaTextBox.SelectionStart = selectionStart;
    }

    private void nazivPredmetaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void predmetDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći predmet";

            DataGridViewRow row = predmetDataGridView.Rows[e.RowIndex];

            Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
            sifraPredmetaTextBox.Text = row.Cells["sifraPredmetaColumn"].Value.ToString();
            nazivPredmetaTextBox.Text = row.Cells["nazivPredmetaColumn"].Value.ToString();
            katedraComboBox.SelectedItem = row.Cells["katedraColumn"].Value.ToString();
            semestarComboBox.SelectedItem = row.Cells["semestarColumn"].Value.ToString()!.Trim();

            sifraPredmetaTextBox.Enabled = true;
            nazivPredmetaTextBox.Enabled = true;
            katedraComboBox.Enabled = true;
            semestarComboBox.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            sifraPredmetaErrorLabel.Text = string.Empty;
            nazivPredmetaErrorLabel.Text = string.Empty;
            katedraErrorLabel.Text = string.Empty;
            semestarErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (sifraPredmetaTextBox.Text.Length != 8)
        {
            result = false;
            sifraPredmetaErrorLabel.Text = "Šifra predmeta mora da ima 8 karaktera";
        }
        else sifraPredmetaErrorLabel.Text = string.Empty;

        if (nazivPredmetaTextBox.Text.Length < 2)
        {
            result = false;
            nazivPredmetaErrorLabel.Text = "Naziv predmeta mora da ima barem 2 karaktera";
        }
        else nazivPredmetaErrorLabel.Text = string.Empty;

        if (katedraComboBox.SelectedItem == null)
        {
            result = false;
            katedraErrorLabel.Text = "Katedra mora biti izabrana";
        }
        else katedraErrorLabel.Text = string.Empty;

        if (semestarComboBox.SelectedItem == null)
        {
            result = false;
            semestarErrorLabel.Text = "Semestar mora biti izabran";
        }
        else semestarErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći predmet";
        DataGridViewRow row = predmetDataGridView.SelectedRows[0];

        Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
        sifraPredmetaTextBox.Text = row.Cells["sifraPredmetaColumn"].Value.ToString();
        nazivPredmetaTextBox.Text = row.Cells["nazivPredmetaColumn"].Value.ToString();
        katedraComboBox.SelectedItem = row.Cells["katedraColumn"].Value.ToString();
        semestarComboBox.SelectedItem = row.Cells["semestarColumn"].Value.ToString()!.Trim();

        sifraPredmetaTextBox.Enabled = true;
        nazivPredmetaTextBox.Enabled = true;
        katedraComboBox.Enabled = true;
        semestarComboBox.Enabled = true;

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        sifraPredmetaErrorLabel.Text = string.Empty;
        nazivPredmetaErrorLabel.Text = string.Empty;
        katedraErrorLabel.Text = string.Empty;
        semestarErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiSifra;

            PredmetBasic predmet = new PredmetBasic
            {
                Id = this.Id,
                Sifra = sifraPredmetaTextBox.Text,
                Naziv = nazivPredmetaTextBox.Text,
                Katedra = katedraComboBox.SelectedItem!.ToString()!,
                Semestar = semestarComboBox.SelectedItem!.ToString()!.Trim()!
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                PredmetBasic? predmetZaProveru = await DTOManager.VratiPredmetBasicAsync(Id);
                if (predmetZaProveru!.Sifra != sifraPredmetaTextBox.Text)
                {
                    rez = await DTOManager.PostojiSifra(sifraPredmetaTextBox.Text);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Predmet sa ovom šifrom već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniPredmetAsync(predmet);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Predmet uspešno ažuriran";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja predmeta";
                }
            }
            else
            {
                postojiSifra = await DTOManager.PostojiSifra(sifraPredmetaTextBox.Text);
                if (postojiSifra == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Predmet sa ovom šifrom već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajPredmetAsync(predmet);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Predmet uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja predmeta";
                }
            }

            predmetDataGridView.Rows.Clear();

            List<PredmetBasic>? predmeti = DTOManager.VratiPredmeteBasic();
            if (predmeti != null)
            {
                foreach (var p in predmeti)
                {
                    predmetDataGridView.Rows.Add(new string[]
                    { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                }

                predmetDataGridView.Refresh();
                predmetDataGridView.ClearSelection();

                brojPredmetaLabel.Text = predmetDataGridView.RowCount.ToString();
            }

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
        bool rez = await DTOManager.ObrisiPredmetAsync(Id);
        if (rez == true)
        {
            List<PredmetBasic>? predmeti = DTOManager.VratiPredmeteBasic();
            if (predmeti != null)
            {
                predmetDataGridView.Rows.Clear();

                foreach (var p in predmeti)
                {
                    predmetDataGridView.Rows.Add(new string[]
                    { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                }

                predmetDataGridView.Refresh();
                predmetDataGridView.ClearSelection();

                brojPredmetaLabel.Text = predmetDataGridView.RowCount.ToString();

                successStatusLabel.ForeColor = Color.Lime;
                successStatusLabel.Text = "Predmet uspešno obrisan";
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

    private void pretagaToolStripButton_Click(object sender, EventArgs e)
    {
        if (pretragaPanel.Visible == false)
        {
            pretragaPanel.Visible = true;
        }
        else
        {
            pretragaPanel.Visible = false;
        }
    }

    private void sifraPretraziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (!char.IsLetterOrDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void sifraPretraziTextBox_TextChanged(object sender, EventArgs e)
    {
        int selectionStart = sifraPretraziTextBox.SelectionStart;
        sifraPretraziTextBox.Text = sifraPretraziTextBox.Text.ToUpper();
        sifraPretraziTextBox.SelectionStart = selectionStart;
    }

    private void nazivPretraziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private async void pretraziButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                var query = session.Query<Predmet>().AsQueryable();

                if (!string.IsNullOrWhiteSpace(sifraPretraziTextBox.Text))
                {
                    query = query.Where(p => p.Sifra.Contains(sifraPretraziTextBox.Text));
                }

                if (!string.IsNullOrWhiteSpace(nazivPretraziTextBox.Text))
                {
                    query = query.Where(p => p.Naziv.ToLower().Contains(nazivPretraziTextBox.Text.ToLower()));
                }

                if (katedraPretaziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.Katedra == katedraPretaziComboBox.SelectedItem.ToString());
                }

                if (semestarPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(p => p.Semestar.Trim() == semestarPretraziComboBox.SelectedItem.ToString());
                }

                IList<PredmetBasic> predmeti = await query.Select(p => new PredmetBasic
                {
                    Id = p.Id,
                    Sifra = p.Sifra,
                    Naziv = p.Naziv,
                    Katedra = p.Katedra,
                    Semestar = p.Semestar
                }).ToListAsync();

                predmetDataGridView.Rows.Clear();

                foreach (var p in predmeti)
                {
                    predmetDataGridView.Rows.Add(new string[]
                    { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                }

                predmetDataGridView.Refresh();
                predmetDataGridView.ClearSelection();

                brojPredmetaLabel.Text = predmetDataGridView.RowCount.ToString();

                session.Close();
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }

    private void minimizePanelButton_Click(object sender, EventArgs e)
    {
        pretragaPanel.Visible = false;
    }

    private void ocistiPretraguButton_Click(object sender, EventArgs e)
    {
        sifraPretraziTextBox.Text = string.Empty;
        nazivPretraziTextBox.Text = string.Empty;

        katedraPretaziComboBox.SelectedIndex = -1;
        semestarPretraziComboBox.SelectedIndex = -1;
    }
}
