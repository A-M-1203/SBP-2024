using NHibernate.Criterion;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Data;

namespace SBP_faza2.Forme;

public partial class PredmetiForma : Form
{
    private int Id = 0;
    public PredmetiForma()
    {
        InitializeComponent();
    }

    private void dodajPredmetToolStripButton_Click(object sender, EventArgs e)
    {
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
        successStatusLabel.Text = string.Empty;

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
            Id = int.Parse(predmetDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
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
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    IList<PredmetBasic> predmeti = session.QueryOver<Predmet>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("Sifra"),
                            Projections.Property("Naziv"),
                            Projections.Property("Katedra"),
                            Projections.Property("Semestar")
                        ).List<object[]>()
                        .Select(row => new PredmetBasic
                        {
                            Id = (int)row[0],
                            Sifra = (string)row[1],
                            Naziv = (string)row[2],
                            Katedra = (string)row[3],
                            Semestar = (string)row[4]
                        }).ToList();

                    predmetDataGridView.Rows.Clear();

                    foreach (var p in predmeti)
                    {
                        predmetDataGridView.Rows.Add(new string[]
                        { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                    }

                    predmetDataGridView.Refresh();
                    predmetDataGridView.ClearSelection();

                    brojPredmetaLabel.Text = session.Query<Predmet>().Count().ToString();
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
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći predmet";

            DataGridViewRow row = predmetDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
            sifraPredmetaTextBox.Text = row.Cells["sifraPredmetaColumn"].Value.ToString();
            nazivPredmetaTextBox.Text = row.Cells["nazivPredmetaColumn"].Value.ToString();

            string katedra = row.Cells["katedraColumn"].Value.ToString()!;
            katedra = katedra.Trim();
            foreach (var item in katedraComboBox.Items)
            {
                if (item.ToString() == katedra)
                {
                    katedraComboBox.SelectedItem = item;
                    break;
                }
            }

            string semestar = row.Cells["semestarColumn"].Value.ToString()!;
            semestar = semestar.Trim();
            foreach (var item in semestarComboBox.Items)
            {
                if (item.ToString() == semestar)
                {
                    semestarComboBox.SelectedItem = item;
                    break;
                }
            }

            sifraPredmetaTextBox.Enabled = true;
            nazivPredmetaTextBox.Enabled = true;
            katedraComboBox.Enabled = true;
            semestarComboBox.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;
        }
    }

    private bool proveriUnos()
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
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći predmet";
        DataGridViewRow row = predmetDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
        sifraPredmetaTextBox.Text = row.Cells["sifraPredmetaColumn"].Value.ToString();
        nazivPredmetaTextBox.Text = row.Cells["nazivPredmetaColumn"].Value.ToString();

        string katedra = row.Cells["katedraColumn"].Value.ToString()!;
        katedra = katedra.Trim();
        foreach (var item in katedraComboBox.Items)
        {
            if (item.ToString() == katedra)
            {
                katedraComboBox.SelectedItem = item;
                break;
            }
        }

        string semestar = row.Cells["semestarColumn"].Value.ToString()!;
        semestar = semestar.Trim();
        foreach (var item in semestarComboBox.Items)
        {
            if (item.ToString() == semestar)
            {
                semestarComboBox.SelectedItem = item;
                break;
            }
        }

        sifraPredmetaTextBox.Enabled = true;
        nazivPredmetaTextBox.Enabled = true;
        katedraComboBox.Enabled = true;
        semestarComboBox.Enabled = true;

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
                    Predmet predmet = session.Query<Predmet>().FirstOrDefault(p => p.Sifra == sifraPredmetaTextBox.Text)!;
                    if (predmet == null)
                    {
                        predmet = new Predmet
                        {
                            Sifra = sifraPredmetaTextBox.Text,
                            Naziv = nazivPredmetaTextBox.Text.Trim(),
                            Katedra = katedraComboBox.SelectedItem!.ToString()!,
                            Semestar = semestarComboBox.SelectedItem!.ToString()!
                        };

                        session.Save(predmet);
                        session.Flush();

                        IList<PredmetBasic> predmeti = session.QueryOver<Predmet>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("Sifra"),
                            Projections.Property("Naziv"),
                            Projections.Property("Katedra"),
                            Projections.Property("Semestar")
                        ).List<object[]>()
                        .Select(row => new PredmetBasic
                        {
                            Id = (int)row[0],
                            Sifra = (string)row[1],
                            Naziv = (string)row[2],
                            Katedra = (string)row[3],
                            Semestar = (string)row[4]
                        }).ToList();

                        predmetDataGridView.Rows.Clear();

                        foreach (var p in predmeti)
                        {
                            predmetDataGridView.Rows.Add(new string[]
                            { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                        }

                        predmetDataGridView.Refresh();
                        predmetDataGridView.ClearSelection();

                        brojPredmetaLabel.Text = session.Query<Predmet>().Count().ToString();

                        successStatusLabel.Text = "Predmet uspešno sačuvan";

                    }
                    else
                    {
                        predmet.Sifra = sifraPredmetaTextBox.Text;
                        predmet.Naziv = nazivPredmetaTextBox.Text.Trim();
                        predmet.Katedra = katedraComboBox.SelectedItem!.ToString()!;
                        predmet.Semestar = semestarComboBox.SelectedItem!.ToString()!;

                        session.Save(predmet);
                        session.Flush();

                        IList<PredmetBasic> predmeti = session.QueryOver<Predmet>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("Sifra"),
                            Projections.Property("Naziv"),
                            Projections.Property("Katedra"),
                            Projections.Property("Semestar")
                        ).List<object[]>()
                        .Select(row => new PredmetBasic
                        {
                            Id = (int)row[0],
                            Sifra = (string)row[1],
                            Naziv = (string)row[2],
                            Katedra = (string)row[3],
                            Semestar = (string)row[4]
                        }).ToList();

                        predmetDataGridView.Rows.Clear();

                        foreach (var p in predmeti)
                        {
                            predmetDataGridView.Rows.Add(new string[]
                            { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                        }

                        predmetDataGridView.Refresh();
                        predmetDataGridView.ClearSelection();

                        successStatusLabel.Text = "Predmet uspešno ažuriran";

                    }

                    session.Close();

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
        else
            successStatusLabel.Text = string.Empty;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        successStatusLabel.Text = string.Empty;
        timer1.Stop();
        timer1.Enabled = false;
    }

    private void obrisiToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet predmet = session.Load<Predmet>(Id);

                session.Delete(predmet);
                session.Flush();

                IList<PredmetBasic> predmeti = session.QueryOver<Predmet>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("Sifra"),
                            Projections.Property("Naziv"),
                            Projections.Property("Katedra"),
                            Projections.Property("Semestar")
                        ).List<object[]>()
                        .Select(row => new PredmetBasic
                        {
                            Id = (int)row[0],
                            Sifra = (string)row[1],
                            Naziv = (string)row[2],
                            Katedra = (string)row[3],
                            Semestar = (string)row[4]
                        }).ToList();

                predmetDataGridView.Rows.Clear();

                foreach (var p in predmeti)
                {
                    predmetDataGridView.Rows.Add(new string[]
                    { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                }

                predmetDataGridView.Refresh();
                predmetDataGridView.ClearSelection();

                brojPredmetaLabel.Text = session.Query<Predmet>().Count().ToString();

                session.Close();

                successStatusLabel.Text = "Predmet uspešno obrisan";
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

    private void pretraziButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                var query = session.Query<Predmet>().AsQueryable();

                if (!string.IsNullOrEmpty(sifraPretraziTextBox.Text))
                {
                    query = query.Where(p => p.Sifra.Contains(sifraPretraziTextBox.Text));
                }

                if (!string.IsNullOrEmpty(nazivPretraziTextBox.Text))
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



                IList<PredmetBasic> predmeti = query.Select(p => new PredmetBasic
                {
                    Id = p.Id,
                    Sifra = p.Sifra,
                    Naziv = p.Naziv,
                    Katedra = p.Katedra,
                    Semestar = p.Semestar
                }).ToList();

                predmetDataGridView.Rows.Clear();

                foreach (var p in predmeti)
                {
                    predmetDataGridView.Rows.Add(new string[]
                    { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                }

                predmetDataGridView.Refresh();
                predmetDataGridView.ClearSelection();

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
