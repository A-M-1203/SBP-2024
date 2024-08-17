using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class GrupeForma : Form
{
    private int Id = 0;
    private bool dodajButtonClicked = false;
    public GrupeForma()
    {
        InitializeComponent();
    }

    private void dodajToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvana nova grupa";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        nazivGrupeTextBox.Enabled = true;
        tipProjektaComboBox.Enabled = true;

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.Text = string.Empty;

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        dodajToolStripButton.Enabled = true;

        if (grupaDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
        }

        nazivGrupeTextBox.Enabled = false;
        tipProjektaComboBox.Enabled = false;
        projekatComboBox.Enabled = false;

        nazivGrupeTextBox.Text = string.Empty;
        tipProjektaComboBox.SelectedIndex = -1;
        projekatComboBox.SelectedIndex = -1;

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private void grupaDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (grupaDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(grupaDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }
    }

    private void GrupeForma_Activated(object sender, EventArgs e)
    {
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    if (tipProjektaComboBox.SelectedIndex != -1)
                    {
                        projekatComboBox.Items.Clear();
                        IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                        if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(TeorijskiProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(PrakticniProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                    }

                    grupaDataGridView.Rows.Clear();

                    IList<Grupa> grupe = session.QueryOver<Grupa>().List<Grupa>();

                    foreach (var g in grupe)
                    {
                        grupaDataGridView.Rows.Add(new string[]
                        {
                            g.Id.ToString(),
                            g.NazivGrupe,
                            g.Projekat.Naziv
                        });
                    }

                    grupaDataGridView.Refresh();
                    grupaDataGridView.ClearSelection();

                    brojGrupaLabel.Text = session.Query<Grupa>().Count().ToString();
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

    private void tipProjektaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        projekatComboBox.Items.Clear();
                        IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                        if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(TeorijskiProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(PrakticniProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }

                        projekatComboBox.Enabled = true;
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
            projekatComboBox.SelectedIndex = -1;
            projekatComboBox.Enabled = false;
        }
    }

    private void grupaDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        dodajButtonClicked = false;
                        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

                        DataGridViewRow row = grupaDataGridView.Rows[e.RowIndex];

                        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
                        nazivGrupeTextBox.Text = row.Cells["nazivGrupeColumn"].Value.ToString();
                        string nazivProjekta = row.Cells["projekatColumn"].Value.ToString()!;

                        Projekat projekat = session.Query<Projekat>().First(p => p.Naziv == nazivProjekta);
                        string? tipProjekta = null;
                        if (projekat.GetType() == typeof(TeorijskiProjekat))
                            tipProjekta = "Teorijski";
                        else
                            tipProjekta = "Praktični";

                        foreach (var item in tipProjektaComboBox.Items)
                        {
                            if (item.ToString() == tipProjekta)
                            {
                                tipProjektaComboBox.SelectedItem = item;
                                break;
                            }
                        }

                        foreach (var item in projekatComboBox.Items)
                        {
                            if (item.ToString() == row.Cells["projekatColumn"].Value.ToString())
                            {
                                projekatComboBox.SelectedItem = item;
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

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            nazivGrupeTextBox.Enabled = true;
            tipProjektaComboBox.Enabled = true;
        }
    }

    private void tipProjektaComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        projekatComboBox.Items.Clear();
                        IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                        if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(TeorijskiProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(PrakticniProjekat))
                                {
                                    projekatComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }

                        projekatComboBox.Enabled = true;
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
            projekatComboBox.SelectedIndex = -1;
            projekatComboBox.Enabled = false;
        }
    }

    private bool proveriUnos()
    {
        bool result = true;

        if (nazivGrupeTextBox.Text.Trim().Length < 1)
        {
            result = false;
            nazivGrupeErrorLabel.Text = "Naziv grupe mora da bude naveden";
        }
        else nazivGrupeErrorLabel.Text = string.Empty;

        if (projekatComboBox.SelectedItem == null)
        {
            result = false;
            projekatErrorLabel.Text = "Projekat mora da bude naveden";
        }
        else projekatErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    dodajButtonClicked = false;
                    successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

                    DataGridViewRow row = grupaDataGridView.SelectedRows[0];

                    Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
                    nazivGrupeTextBox.Text = row.Cells["nazivGrupeColumn"].Value.ToString();
                    string nazivProjekta = row.Cells["projekatColumn"].Value.ToString()!;

                    Projekat projekat = session.Query<Projekat>().First(p => p.Naziv == nazivProjekta);
                    string? tipProjekta = null;
                    if (projekat.GetType() == typeof(TeorijskiProjekat))
                        tipProjekta = "Teorijski";
                    else
                        tipProjekta = "Praktični";

                    foreach (var item in tipProjektaComboBox.Items)
                    {
                        if (item.ToString() == tipProjekta)
                        {
                            tipProjektaComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (var item in projekatComboBox.Items)
                    {
                        if (item.ToString() == row.Cells["projekatColumn"].Value.ToString())
                        {
                            projekatComboBox.SelectedItem = item;
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

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        nazivGrupeTextBox.Enabled = true;
        tipProjektaComboBox.Enabled = true;
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
                        Grupa grupaZaAzuriranje = session.Load<Grupa>(Id);

                        grupaZaAzuriranje.NazivGrupe = nazivGrupeTextBox.Text;

                        string noviProjekatNaziv = projekatComboBox.SelectedItem!.ToString()!;

                        if (grupaZaAzuriranje.Projekat.Naziv != noviProjekatNaziv)
                        {
                            Projekat stariProjekat = session.Query<Projekat>().First(p => p.Naziv == grupaZaAzuriranje.Projekat.Naziv);

                            stariProjekat.Grupe.Remove(grupaZaAzuriranje);

                            session.Update(stariProjekat);

                            Projekat noviProjekat = session.Query<Projekat>().First(p => p.Naziv == noviProjekatNaziv);

                            grupaZaAzuriranje.Projekat = noviProjekat;
                            noviProjekat.Grupe.Add(grupaZaAzuriranje);

                            session.Update(noviProjekat);
                        }
                        else
                        {
                            session.Update(grupaZaAzuriranje);
                        }

                        session.Flush();

                        successStatusLabel.ForeColor = Color.Lime;
                        successStatusLabel.Text = "Grupa je uspešno ažurirana";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Grupa? grupa = session.Query<Grupa>().FirstOrDefault(g => g.NazivGrupe == nazivGrupeTextBox.Text);

                        if (grupa == null)
                        {
                            string nazivProjekta = projekatComboBox.SelectedItem!.ToString()!;

                            Projekat projekat = session.Query<Projekat>().First(p => p.Naziv == nazivProjekta);

                            grupa = new Grupa
                            {
                                NazivGrupe = nazivGrupeTextBox.Text,
                                Projekat = projekat
                            };

                            projekat.Grupe.Add(grupa);
                            session.Update(projekat);
                            session.Flush();

                            successStatusLabel.ForeColor = Color.Lime;
                            successStatusLabel.Text = "Nova grupa je uspešno sačuvana";
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                        else
                        {
                            successStatusLabel.ForeColor = Color.Red;
                            successStatusLabel.Text = "Grupa sa datim nazivom već postoji";
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                    }

                    grupaDataGridView.Rows.Clear();

                    IList<Grupa> grupe = session.QueryOver<Grupa>().List<Grupa>();

                    foreach (var g in grupe)
                    {
                        grupaDataGridView.Rows.Add(new string[]
                        {
                            g.Id.ToString(),
                            g.NazivGrupe,
                            g.Projekat.Naziv
                        });
                    }

                    grupaDataGridView.Refresh();
                    grupaDataGridView.ClearSelection();

                    brojGrupaLabel.Text = session.Query<Grupa>().Count().ToString();

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

    private void obrisiToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Grupa grupa = session.Load<Grupa>(Id);

                grupa.Projekat.Grupe.Remove(grupa);

                session.Update(grupa.Projekat);
                session.Delete(grupa);
                session.Flush();

                grupaDataGridView.Rows.Clear();

                IList<Grupa> grupe = session.QueryOver<Grupa>().List<Grupa>();

                foreach (var g in grupe)
                {
                    grupaDataGridView.Rows.Add(new string[]
                    {
                        g.Id.ToString(),
                        g.NazivGrupe,
                        g.Projekat.Naziv
                    });
                }

                grupaDataGridView.Refresh();
                grupaDataGridView.ClearSelection();

                brojGrupaLabel.Text = session.Query<Grupa>().Count().ToString();

                session.Close();

                successStatusLabel.ForeColor = Color.Lime;
                successStatusLabel.Text = "Grupa uspešno obrisan";
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

        nazivGrupeTextBox.Text = string.Empty;
        tipProjektaComboBox.SelectedIndex = -1;
        projekatComboBox.SelectedIndex = -1;

        nazivGrupeTextBox.Enabled = false;
        tipProjektaComboBox.Enabled = false;
        projekatComboBox.Enabled = false;

        dodajToolStripButton.Enabled = true;
        izmeniToolStripButton.Enabled = false;
        obrisiToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        odustaniToolStripButton.Enabled = false;

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private void tipPretragaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (tipPretragaComboBox.SelectedIndex != -1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                        projekatPretragaComboBox.Items.Clear();
                        if (tipPretragaComboBox.SelectedItem!.ToString() == "Teorijski")
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(TeorijskiProjekat))
                                {
                                    projekatPretragaComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(PrakticniProjekat))
                                {
                                    projekatPretragaComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }

                        projekatPretragaComboBox.Enabled = true;
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
            projekatPretragaComboBox.SelectedIndex = -1;
            projekatPretragaComboBox.Enabled = false;
        }
    }

    private void tipPretragaComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipPretragaComboBox.SelectedIndex != -1)
        {
            try
            {
                using (ISession? session = DataLayer.GetSession())
                {
                    if (session != null)
                    {
                        IList<Projekat> projekti = session.QueryOver<Projekat>().List<Projekat>();

                        projekatPretragaComboBox.Items.Clear();
                        if (tipPretragaComboBox.SelectedItem!.ToString() == "Teorijski")
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(TeorijskiProjekat))
                                {
                                    projekatPretragaComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in projekti)
                            {
                                if (item.GetType() == typeof(PrakticniProjekat))
                                {
                                    projekatPretragaComboBox.Items.Add(item.Naziv);
                                }
                            }
                        }

                        projekatPretragaComboBox.Enabled = true;
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
            projekatPretragaComboBox.SelectedIndex = -1;
            projekatPretragaComboBox.Enabled = false;
        }
    }

    private void ocistiPretraguButton_Click(object sender, EventArgs e)
    {
        nazivPretragaTextBox.Text = string.Empty;
        tipPretragaComboBox.SelectedIndex = -1;
    }

    private void pretragaToolStripButton_Click(object sender, EventArgs e)
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
                var query = session.Query<Grupa>().AsQueryable();

                if (!string.IsNullOrEmpty(nazivPretragaTextBox.Text))
                {
                    query = query.Where(g => g.NazivGrupe.ToLower().Contains(nazivPretragaTextBox.Text.Trim().ToLower()));
                }

                if (projekatPretragaComboBox.SelectedItem != null)
                {
                    query = query.Where(g => g.Projekat.Naziv == projekatPretragaComboBox.SelectedItem.ToString());
                }

                grupaDataGridView.Rows.Clear();

                IList<Grupa> grupe = query.ToList();

                foreach (var g in grupe)
                {
                    grupaDataGridView.Rows.Add(new string[]
                    {
                        g.Id.ToString(),
                        g.NazivGrupe,
                        g.Projekat.Naziv
                    });
                }

                grupaDataGridView.Refresh();
                grupaDataGridView.ClearSelection();

                session.Close();
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }
}
