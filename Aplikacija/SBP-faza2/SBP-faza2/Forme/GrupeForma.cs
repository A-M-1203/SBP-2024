using NHibernate;
using NHibernate.Linq;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme;

public partial class GrupeForma : Form
{
    private long Id = 0;
    private bool dodajButtonClicked = false;
    public GrupeForma()
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

        nazivGrupeTextBox.Enabled = true;
        tipProjektaComboBox.Enabled = true;

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

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
            Id = long.Parse(grupaDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private void GrupeForma_Activated(object sender, EventArgs e)
    {
        DodajGrupeDataGridView();
    }

    private async void grupaDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.ForeColor = Color.Black;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

            DataGridViewRow row = grupaDataGridView.Rows[e.RowIndex];

            Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
            nazivGrupeTextBox.Text = row.Cells["nazivGrupeColumn"].Value.ToString();
            string nazivProjekta = row.Cells["projekatColumn"].Value.ToString()!;

            Projekat? projekat = await DTOManager.VratiProjekatPoNazivuAsync(nazivProjekta);
            if (projekat != null)
            {
                string? tipProjekta;
                if (projekat.GetType() == typeof(TeorijskiProjekat))
                    tipProjekta = "Teorijski";
                else
                    tipProjekta = "Praktični";

                tipProjektaComboBox.SelectedItem = tipProjekta;

                projekatComboBox.SelectedItem = projekat.Naziv;
            }

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            nazivGrupeTextBox.Enabled = true;
            tipProjektaComboBox.Enabled = true;
            projekatComboBox.Enabled = true;

            nazivGrupeErrorLabel.Text = string.Empty;
            tipProjektaErrorLabel.Text = string.Empty;
            projekatErrorLabel.Text = string.Empty;
        }
    }

    private async void tipProjektaComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                List<TeorijskiProjekat>? teorijskiProjekti = await DTOManager.VratiTeorijskeProjekteAsync();
                if (teorijskiProjekti != null)
                {
                    projekatComboBox.Items.Clear();
                    foreach (var tp in teorijskiProjekti)
                        projekatComboBox.Items.Add(tp.Naziv);
                }
            }
            else
            {
                List<PrakticniProjekat>? prakticniProjekti = await DTOManager.VratiPrakticneProjekteAsync();
                if (prakticniProjekti != null)
                {
                    projekatComboBox.Items.Clear();
                    foreach (var pp in prakticniProjekti)
                        projekatComboBox.Items.Add(pp.Naziv);
                }
            }

            projekatComboBox.Enabled = true;
        }
        else
        {
            projekatComboBox.SelectedIndex = -1;
            projekatComboBox.Enabled = false;
        }
    }

    private bool ProveriUnos()
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

    private async void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;
        successStatusLabel.ForeColor = Color.Black;
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjena postojeća grupa";

        DataGridViewRow row = grupaDataGridView.SelectedRows[0];

        Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
        nazivGrupeTextBox.Text = row.Cells["nazivGrupeColumn"].Value.ToString();
        string nazivProjekta = row.Cells["projekatColumn"].Value.ToString()!;

        Projekat? projekat = await DTOManager.VratiProjekatPoNazivuAsync(nazivProjekta);
        if (projekat != null)
        {
            string? tipProjekta;
            if (projekat.GetType() == typeof(TeorijskiProjekat))
                tipProjekta = "Teorijski";
            else
                tipProjekta = "Praktični";

            tipProjektaComboBox.SelectedItem = tipProjekta;

            projekatComboBox.SelectedItem = projekat.Naziv;
        }

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        nazivGrupeTextBox.Enabled = true;
        tipProjektaComboBox.Enabled = true;
        projekatComboBox.Enabled = true;

        nazivGrupeErrorLabel.Text = string.Empty;
        tipProjektaErrorLabel.Text = string.Empty;
        projekatErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiGrupa;
            ProjekatBasic projekatBasic = (await DTOManager.VratiProjekatBasicPoNazivuAsync(projekatComboBox.SelectedItem!.ToString()!))!;
            GrupaBasic grupa = new GrupaBasic
            {
                Id = Id,
                Naziv = nazivGrupeTextBox.Text,
                Projekat = projekatBasic
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                GrupaBasic? grupaZaProveru = await DTOManager.VratiGrupaBasicAsync(Id);
                if (grupaZaProveru!.Naziv != grupa.Naziv)
                {
                    rez = await DTOManager.PostojiGrupa(grupa.Naziv);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Grupa sa ovim nazivom već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniGrupaAsync(grupa);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Grupa uspešno ažuriran";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja grupe";
                }
            }
            else
            {
                postojiGrupa = await DTOManager.PostojiGrupa(grupa.Naziv);
                if (postojiGrupa == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Grupa sa ovim nazivom već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajGrupaAsync(grupa);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Grupa uspešno dodata";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja grupe";
                }
            }

            DodajGrupeDataGridView();

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

        bool rez = await DTOManager.ObrisiGrupaAsync(Id);
        if (rez == true)
        {
            DodajGrupeDataGridView();
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja grupe";
        }

        timer1.Enabled = true;
        timer1.Start();

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

    private async void tipPretragaComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipPretragaComboBox.SelectedIndex != -1)
        {
            if (tipPretragaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                List<TeorijskiProjekat>? teorijskiProjekti = await DTOManager.VratiTeorijskeProjekteAsync();
                if (teorijskiProjekti != null)
                {
                    projekatPretragaComboBox.Items.Clear();
                    foreach (var tp in teorijskiProjekti)
                        projekatPretragaComboBox.Items.Add(tp.Naziv);
                }
            }
            else
            {
                List<PrakticniProjekat>? prakticniProjekti = await DTOManager.VratiPrakticneProjekteAsync();
                if (prakticniProjekti != null)
                {
                    projekatPretragaComboBox.Items.Clear();
                    foreach (var pp in prakticniProjekti)
                        projekatPretragaComboBox.Items.Add(pp.Naziv);
                }
            }

            projekatPretragaComboBox.Enabled = true;
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

    private async void pretraziButton_Click(object sender, EventArgs e)
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

                IList<GrupaPregled> grupe = await query.Select(g => new GrupaPregled
                {
                    Id = g.Id,
                    Naziv = g.NazivGrupe,
                    Projekat = g.Projekat.Naziv
                }).ToListAsync();

                grupaDataGridView.Rows.Clear();

                foreach (var g in grupe)
                {
                    grupaDataGridView.Rows.Add(new string[]
                    {
                        g.Id.ToString(),
                        g.Naziv,
                        g.Projekat
                    });
                }

                grupaDataGridView.Refresh();
                grupaDataGridView.ClearSelection();

                brojGrupaLabel.Text = grupaDataGridView.RowCount.ToString();

                session.Close();
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }

    private void DodajGrupeDataGridView()
    {
        List<GrupaPregled>? grupe = DTOManager.VratiGrupePregled();
        if (grupe != null)
        {
            grupaDataGridView.Rows.Clear();

            foreach (var g in grupe)
            {
                grupaDataGridView.Rows.Add(new string[]
                { g.Id.ToString(), g.Naziv, g.Projekat });
            }

            grupaDataGridView.Refresh();
            grupaDataGridView.ClearSelection();

            brojGrupaLabel.Text = grupaDataGridView.RowCount.ToString();
        }
    }

    private async void tipProjektaComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (tipProjektaComboBox.SelectedIndex != -1)
        {
            if (tipProjektaComboBox.SelectedItem!.ToString() == "Teorijski")
            {
                List<TeorijskiProjekat>? teorijskiProjekti = await DTOManager.VratiTeorijskeProjekteAsync();
                if (teorijskiProjekti != null)
                {
                    projekatComboBox.Items.Clear();
                    foreach (var tp in teorijskiProjekti)
                        projekatComboBox.Items.Add(tp.Naziv);
                }
            }
            else
            {
                List<PrakticniProjekat>? prakticniProjekti = await DTOManager.VratiPrakticneProjekteAsync();
                if (prakticniProjekti != null)
                {
                    projekatComboBox.Items.Clear();
                    foreach (var pp in prakticniProjekti)
                        projekatComboBox.Items.Add(pp.Naziv);
                }
            }

            projekatComboBox.Enabled = true;
        }
        else
        {
            projekatComboBox.SelectedIndex = -1;
            projekatComboBox.Enabled = false;
        }
    }
}
