using NHibernate;
using NHibernate.Linq;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Data;

namespace SBP_faza2.Forme;

public partial class StudentiForma : Form
{
    private long Id = 0;
    private bool dodajButtonClicked = false;
    public StudentiForma()
    {
        InitializeComponent();
    }

    private void dodajStudentaToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = true;

        successStatusLabel.Text = "Klikom na dugme sačuvaj biće sačuvan novi student";

        dodajToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        licnoImeTextBox.Enabled = true;
        imeRoditeljaTextBox.Enabled = true;
        prezimeTextBox.Enabled = true;
        brojIndeksaTextBox.Enabled = true;
        smerComboBox.Enabled = true;

        licnoImeErrorLabel.Text = string.Empty;
        imeRoditeljaErrorLabel.Text = string.Empty;
        prezimeErrorLabel.Text = string.Empty;
        brojIndeksaErrorLabel.Text = string.Empty;
        smerErrorLabel.Text = string.Empty;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.Text = "Polja označena zvezdicom su obavezna";

        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;

        dodajToolStripButton.Enabled = true;

        if (studentDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
        }

        licnoImeTextBox.Enabled = false;
        imeRoditeljaTextBox.Enabled = false;
        prezimeTextBox.Enabled = false;
        brojIndeksaTextBox.Enabled = false;
        smerComboBox.Enabled = false;

        licnoImeTextBox.Text = string.Empty;
        imeRoditeljaTextBox.Text = string.Empty;
        prezimeTextBox.Text = string.Empty;
        brojIndeksaTextBox.Text = string.Empty;
        smerComboBox.SelectedIndex = -1;

        licnoImeErrorLabel.Text = string.Empty;
        imeRoditeljaErrorLabel.Text = string.Empty;
        prezimeErrorLabel.Text = string.Empty;
        brojIndeksaErrorLabel.Text = string.Empty;
        smerErrorLabel.Text = string.Empty;
    }

    private void studentDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (studentDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = long.Parse(studentDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
        }
        else
        {
            izmeniToolStripButton.Enabled = false;
            obrisiToolStripButton.Enabled = false;
        }

        licnoImeErrorLabel.Text = string.Empty;
        imeRoditeljaErrorLabel.Text = string.Empty;
        prezimeErrorLabel.Text = string.Empty;
        brojIndeksaErrorLabel.Text = string.Empty;
        smerErrorLabel.Text = string.Empty;
    }

    private void StudentiForma_Activated(object sender, EventArgs e)
    {
        List<StudentBasic>? studenti = DTOManager.VratiStudenteBasic();
        if (studenti != null)
        {
            studentDataGridView.Rows.Clear();

            foreach (var s in studenti)
            {
                studentDataGridView.Rows.Add(new string[]
                { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
            }

            studentDataGridView.Refresh();
            studentDataGridView.ClearSelection();

            brojStudenataLabel.Text = studentDataGridView.RowCount.ToString();
        }
    }

    private void licnoImeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void imeRoditeljaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void prezimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void brojIndeksaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private void studentaDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            dodajButtonClicked = false;
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći student";

            DataGridViewRow row = studentDataGridView.Rows[e.RowIndex];

            Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
            licnoImeTextBox.Text = row.Cells["licnoImeColumn"].Value.ToString();
            imeRoditeljaTextBox.Text = row.Cells["imeRoditeljaColumn"].Value.ToString();
            prezimeTextBox.Text = row.Cells["prezimeColumn"].Value.ToString();
            brojIndeksaTextBox.Text = row.Cells["brojIndeksaColumn"].Value.ToString();
            smerComboBox.SelectedItem = row.Cells["smerColumn"].Value.ToString()!.Trim();

            licnoImeTextBox.Enabled = true;
            imeRoditeljaTextBox.Enabled = true;
            prezimeTextBox.Enabled = true;
            brojIndeksaTextBox.Enabled = true;
            smerComboBox.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;

            licnoImeErrorLabel.Text = string.Empty;
            imeRoditeljaErrorLabel.Text = string.Empty;
            prezimeErrorLabel.Text = string.Empty;
            brojIndeksaErrorLabel.Text = string.Empty;
            smerErrorLabel.Text = string.Empty;
        }
    }

    private bool ProveriUnos()
    {
        bool result = true;

        if (licnoImeTextBox.Text.Length < 2)
        {
            result = false;
            licnoImeErrorLabel.Text = "Lično ime mora da ima barem 2 karaktera";
        }
        else licnoImeErrorLabel.Text = string.Empty;

        if (imeRoditeljaTextBox.Text.Length < 2)
        {
            result = false;
            imeRoditeljaErrorLabel.Text = "Ime roditelja mora da ima barem 2 karaktera";
        }
        else imeRoditeljaErrorLabel.Text = string.Empty;

        if (prezimeTextBox.Text.Length < 3)
        {
            result = false;
            prezimeErrorLabel.Text = "Prezime mora da ima barem 3 karaktera";
        }
        else prezimeErrorLabel.Text = string.Empty;

        if (brojIndeksaTextBox.Text.Length != 5)
        {
            result = false;
            brojIndeksaErrorLabel.Text = "Broj indeksa mora da ima 5 cifara";
        }
        else if (brojIndeksaTextBox.Text.StartsWith('0'))
        {
            result = false;
            brojIndeksaErrorLabel.Text = "Broj indeksa ne sme da počinje nulom";
        }
        else brojIndeksaErrorLabel.Text = string.Empty;

        if (smerComboBox.SelectedItem == null)
        {
            result = false;
            smerErrorLabel.Text = "Smer mora biti izabran";
        }
        else smerErrorLabel.Text = string.Empty;

        return result;
    }

    private void izmeniToolStripButton_Click(object sender, EventArgs e)
    {
        dodajButtonClicked = false;

        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći student";
        DataGridViewRow row = studentDataGridView.SelectedRows[0];

        Id = long.Parse(row.Cells["idColumn"].Value.ToString()!);
        licnoImeTextBox.Text = row.Cells["licnoImeColumn"].Value.ToString();
        imeRoditeljaTextBox.Text = row.Cells["imeRoditeljaColumn"].Value.ToString();
        prezimeTextBox.Text = row.Cells["prezimeColumn"].Value.ToString();
        brojIndeksaTextBox.Text = row.Cells["brojIndeksaColumn"].Value.ToString();
        smerComboBox.SelectedItem = row.Cells["smerColumn"].Value.ToString()!.Trim();

        licnoImeTextBox.Enabled = true;
        imeRoditeljaTextBox.Enabled = true;
        prezimeTextBox.Enabled = true;
        brojIndeksaTextBox.Enabled = true;
        smerComboBox.Enabled = true;

        dodajToolStripButton.Enabled = false;
        izmeniToolStripButton.Enabled = false;

        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        licnoImeErrorLabel.Text = string.Empty;
        imeRoditeljaErrorLabel.Text = string.Empty;
        prezimeErrorLabel.Text = string.Empty;
        brojIndeksaErrorLabel.Text = string.Empty;
        smerErrorLabel.Text = string.Empty;
    }

    private async void sacuvajToolStripButton_Click(object sender, EventArgs e)
    {
        bool result = ProveriUnos();

        if (result == true)
        {
            bool postojiIndeks;

            StudentBasic student = new StudentBasic
            {
                Id = this.Id,
                LicnoIme = licnoImeTextBox.Text,
                ImeRoditelja = imeRoditeljaTextBox.Text,
                Prezime = prezimeTextBox.Text,
                BrojIndeksa = brojIndeksaTextBox.Text,
                Smer = smerComboBox.SelectedItem!.ToString()!
            };

            bool rez;
            if (dodajButtonClicked == false)
            {
                StudentBasic? studentZaProveru = await DTOManager.VratiStudentBasicAsync(Id);
                if (studentZaProveru!.BrojIndeksa != brojIndeksaTextBox.Text)
                {
                    rez = await DTOManager.PostojiIndeks(brojIndeksaTextBox.Text);
                    if (rez == true)
                    {
                        successStatusLabel.ForeColor = Color.Red;
                        successStatusLabel.Text = "Student sa ovim indeksom već postoji";

                        timer1.Enabled = true;
                        timer1.Start();
                        return;
                    }
                }

                rez = await DTOManager.IzmeniStudentaAsync(student);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Student uspešno ažuriran";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom ažuriranja studenta";
                }
            }
            else
            {
                postojiIndeks = await DTOManager.PostojiIndeks(brojIndeksaTextBox.Text);
                if (postojiIndeks == true)
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Student sa ovim indeksom već postoji";

                    timer1.Enabled = true;
                    timer1.Start();
                    return;
                }

                rez = await DTOManager.DodajStudentaAsync(student);
                if (rez == true)
                {
                    successStatusLabel.ForeColor = Color.Lime;
                    successStatusLabel.Text = "Student uspešno dodat";
                }
                else
                {
                    successStatusLabel.ForeColor = Color.Red;
                    successStatusLabel.Text = "Greška prilikom dodavanja studenta";
                }
            }

            studentDataGridView.Rows.Clear();

            List<StudentBasic>? studenti = DTOManager.VratiStudenteBasic();
            if (studenti != null)
            {
                foreach (var s in studenti)
                {
                    studentDataGridView.Rows.Add(new string[]
                    { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                }

                studentDataGridView.Refresh();
                studentDataGridView.ClearSelection();

                brojStudenataLabel.Text = studentDataGridView.RowCount.ToString();
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
        bool rez = await DTOManager.ObrisiStudentaAsync(Id);
        if (rez == true)
        {
            List<StudentBasic>? studenti = DTOManager.VratiStudenteBasic();
            if (studenti != null)
            {
                studentDataGridView.Rows.Clear();

                foreach (var s in studenti)
                {
                    studentDataGridView.Rows.Add(new string[]
                    { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                }

                studentDataGridView.Refresh();
                studentDataGridView.ClearSelection();

                brojStudenataLabel.Text = studentDataGridView.RowCount.ToString();

                successStatusLabel.ForeColor = Color.Lime;
                successStatusLabel.Text = "Student uspešno obrisan";
            }
        }
        else
        {
            successStatusLabel.ForeColor = Color.Red;
            successStatusLabel.Text = "Greška prilikom brisanja studenta";
        }

        timer1.Enabled = true;
        timer1.Start();
    }

    private void imePretraziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void roditeljPretraziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void prezimePretaziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void indeksPretraziTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
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
                var query = session.Query<Student>().AsQueryable();

                if (!string.IsNullOrWhiteSpace(imePretraziTextBox.Text))
                {
                    query = query.Where(s => s.LicnoIme.ToLower().Contains(imePretraziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrWhiteSpace(roditeljPretraziTextBox.Text))
                {
                    query = query.Where(s => s.ImeRoditelja.ToLower().Contains(roditeljPretraziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrWhiteSpace(prezimePretaziTextBox.Text))
                {
                    query = query.Where(s => s.Prezime.ToLower().Contains(prezimePretaziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrWhiteSpace(indeksPretraziTextBox.Text))
                {
                    query = query.Where(s => s.BrojIndeksa.Contains(indeksPretraziTextBox.Text));
                }

                if (smerPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(s => s.Smer.Trim() == smerPretraziComboBox.SelectedItem.ToString());
                }

                IList<StudentBasic> studenti = await query.Select(s => new StudentBasic
                {
                    Id = s.Id,
                    LicnoIme = s.LicnoIme,
                    ImeRoditelja = s.ImeRoditelja,
                    Prezime = s.Prezime,
                    BrojIndeksa = s.BrojIndeksa,
                    Smer = s.Smer
                }).ToListAsync();

                studentDataGridView.Rows.Clear();

                foreach (var s in studenti)
                {
                    studentDataGridView.Rows.Add(new string[]
                    { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                }

                studentDataGridView.Refresh();
                studentDataGridView.ClearSelection();

                brojStudenataLabel.Text = studentDataGridView.RowCount.ToString();

                session.Close();
            }
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }

    private void ocistiPretraguButton_Click(object sender, EventArgs e)
    {
        imePretraziTextBox.Text = string.Empty;
        roditeljPretraziTextBox.Text = string.Empty;
        prezimePretaziTextBox.Text = string.Empty;
        indeksPretraziTextBox.Text = string.Empty;

        smerPretraziComboBox.SelectedIndex = -1;
    }
}
