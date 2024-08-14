using NHibernate.Criterion;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Data;

namespace SBP_faza2.Forme;

public partial class StudentiForma : Form
{
    private int Id = 0;
    public StudentiForma()
    {
        InitializeComponent();
    }

    private void dodajStudentaToolStripButton_Click(object sender, EventArgs e)
    {
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće zapamćen novi student";

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
        successStatusLabel.Text = string.Empty;

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

    private void studentaDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (studentDataGridView.SelectedRows.Count > 0)
        {
            izmeniToolStripButton.Enabled = true;
            obrisiToolStripButton.Enabled = true;
            Id = int.Parse(studentDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()!);
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
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    IList<StudentBasic> studenti = session.QueryOver<Student>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("LicnoIme"),
                            Projections.Property("ImeRoditelja"),
                            Projections.Property("Prezime"),
                            Projections.Property("BrojIndeksa"),
                            Projections.Property("Smer")
                        ).List<object[]>()
                        .Select(row => new StudentBasic
                        {
                            Id = (int)row[0],
                            LicnoIme = (string)row[1],
                            ImeRoditelja = (string)row[2],
                            Prezime = (string)row[3],
                            BrojIndeksa = (string)row[4],
                            Smer = (string)row[5]
                        }).ToList();

                    studentDataGridView.Rows.Clear();

                    foreach (var s in studenti)
                    {
                        studentDataGridView.Rows.Add(new string[]
                        { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                    }

                    studentDataGridView.Refresh();
                    studentDataGridView.ClearSelection();

                    brojStudenataLabel.Text = session.Query<Student>().Count().ToString();
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
            successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći student";

            DataGridViewRow row = studentDataGridView.Rows[e.RowIndex];

            Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
            licnoImeTextBox.Text = row.Cells["licnoImeColumn"].Value.ToString();
            imeRoditeljaTextBox.Text = row.Cells["imeRoditeljaColumn"].Value.ToString();
            prezimeTextBox.Text = row.Cells["prezimeColumn"].Value.ToString();
            brojIndeksaTextBox.Text = row.Cells["brojIndeksaColumn"].Value.ToString();

            string smer = row.Cells["smerColumn"].Value.ToString()!;
            smer = smer.Trim();
            foreach (var item in smerComboBox.Items)
            {
                if (item.ToString() == smer)
                {
                    smerComboBox.SelectedItem = item;
                    break;
                }
            }

            licnoImeTextBox.Enabled = true;
            imeRoditeljaTextBox.Enabled = true;
            prezimeTextBox.Enabled = true;
            brojIndeksaTextBox.Enabled = true;
            smerComboBox.Enabled = true;

            dodajToolStripButton.Enabled = false;
            izmeniToolStripButton.Enabled = false;

            sacuvajToolStripButton.Enabled = true;
            odustaniToolStripButton.Enabled = true;
        }
    }

    private bool proveriUnos()
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

    private void izmeniStudentaToolStripButton_Click(object sender, EventArgs e)
    {
        successStatusLabel.Text = "Klikom na dugme sačuvaj biće izmenjen postojeći student";
        DataGridViewRow row = studentDataGridView.SelectedRows[0];

        Id = int.Parse(row.Cells["idColumn"].Value.ToString()!);
        licnoImeTextBox.Text = row.Cells["licnoImeColumn"].Value.ToString();
        imeRoditeljaTextBox.Text = row.Cells["imeRoditeljaColumn"].Value.ToString();
        prezimeTextBox.Text = row.Cells["prezimeColumn"].Value.ToString();
        brojIndeksaTextBox.Text = row.Cells["brojIndeksaColumn"].Value.ToString();

        string smer = row.Cells["smerColumn"].Value.ToString()!;
        smer = smer.Trim();
        foreach (var item in smerComboBox.Items)
        {
            if (item.ToString() == smer)
            {
                smerComboBox.SelectedItem = item;
                break;
            }
        }

        licnoImeTextBox.Enabled = true;
        imeRoditeljaTextBox.Enabled = true;
        prezimeTextBox.Enabled = true;
        brojIndeksaTextBox.Enabled = true;
        smerComboBox.Enabled = true;

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
                    Student student = session.Query<Student>().FirstOrDefault(s => s.BrojIndeksa == brojIndeksaTextBox.Text)!;
                    if (student == null)
                    {
                        student = new Student
                        {
                            LicnoIme = CapitalizeEachWord(licnoImeTextBox.Text.Trim()),
                            ImeRoditelja = CapitalizeEachWord(imeRoditeljaTextBox.Text.Trim()),
                            Prezime = CapitalizeEachWord(prezimeTextBox.Text.Trim()),
                            BrojIndeksa = brojIndeksaTextBox.Text,
                            Smer = smerComboBox.SelectedItem!.ToString()!
                        };

                        session.Save(student);
                        session.Flush();

                        IList<StudentBasic> studenti = session.QueryOver<Student>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("LicnoIme"),
                            Projections.Property("ImeRoditelja"),
                            Projections.Property("Prezime"),
                            Projections.Property("BrojIndeksa"),
                            Projections.Property("Smer")
                        ).List<object[]>()
                        .Select(row => new StudentBasic
                        {
                            Id = (int)row[0],
                            LicnoIme = (string)row[1],
                            ImeRoditelja = (string)row[2],
                            Prezime = (string)row[3],
                            BrojIndeksa = (string)row[4],
                            Smer = (string)row[5]
                        }).ToList();

                        studentDataGridView.Rows.Clear();

                        foreach (var s in studenti)
                        {
                            studentDataGridView.Rows.Add(new string[]
                            { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                        }

                        studentDataGridView.Refresh();
                        studentDataGridView.ClearSelection();

                        brojStudenataLabel.Text = session.Query<Student>().Count().ToString();

                        successStatusLabel.Text = "Student uspešno sačuvan";

                    }
                    else
                    {
                        student.LicnoIme = CapitalizeEachWord(licnoImeTextBox.Text.Trim());
                        student.ImeRoditelja = CapitalizeEachWord(imeRoditeljaTextBox.Text.Trim());
                        student.Prezime = CapitalizeEachWord(prezimeTextBox.Text.Trim());
                        student.BrojIndeksa = brojIndeksaTextBox.Text;
                        student.Smer = smerComboBox.SelectedItem!.ToString()!;

                        session.Save(student);
                        session.Flush();

                        IList<StudentBasic> studenti = session.QueryOver<Student>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("LicnoIme"),
                            Projections.Property("ImeRoditelja"),
                            Projections.Property("Prezime"),
                            Projections.Property("BrojIndeksa"),
                            Projections.Property("Smer")
                        ).List<object[]>()
                        .Select(row => new StudentBasic
                        {
                            Id = (int)row[0],
                            LicnoIme = (string)row[1],
                            ImeRoditelja = (string)row[2],
                            Prezime = (string)row[3],
                            BrojIndeksa = (string)row[4],
                            Smer = (string)row[5]
                        }).ToList();

                        studentDataGridView.Rows.Clear();

                        foreach (var s in studenti)
                        {
                            studentDataGridView.Rows.Add(new string[]
                            { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                        }

                        studentDataGridView.Refresh();
                        studentDataGridView.ClearSelection();

                        successStatusLabel.Text = "Student uspešno ažuriran";

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

    public static string CapitalizeEachWord(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
        }

        return string.Join(' ', words);
    }

    private void obrisiStudentaToolStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student student = session.Load<Student>(Id);

                session.Delete(student);
                session.Flush();

                IList<StudentBasic> studenti = session.QueryOver<Student>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("LicnoIme"),
                            Projections.Property("ImeRoditelja"),
                            Projections.Property("Prezime"),
                            Projections.Property("BrojIndeksa"),
                            Projections.Property("Smer")
                        ).List<object[]>()
                        .Select(row => new StudentBasic
                        {
                            Id = (int)row[0],
                            LicnoIme = (string)row[1],
                            ImeRoditelja = (string)row[2],
                            Prezime = (string)row[3],
                            BrojIndeksa = (string)row[4],
                            Smer = (string)row[5]
                        }).ToList();

                studentDataGridView.Rows.Clear();

                foreach (var s in studenti)
                {
                    studentDataGridView.Rows.Add(new string[]
                    { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                }

                studentDataGridView.Refresh();
                studentDataGridView.ClearSelection();

                brojStudenataLabel.Text = session.Query<Student>().Count().ToString();

                session.Close();

                successStatusLabel.Text = "Student uspešno obrisan";
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

    private void pretraziButton_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                var query = session.Query<Student>().AsQueryable();

                if (!string.IsNullOrEmpty(imePretraziTextBox.Text))
                {
                    query = query.Where(s => s.LicnoIme.ToLower().Contains(imePretraziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrEmpty(roditeljPretraziTextBox.Text))
                {
                    query = query.Where(s => s.ImeRoditelja.ToLower().Contains(roditeljPretraziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrEmpty(prezimePretaziTextBox.Text))
                {
                    query = query.Where(s => s.Prezime.ToLower().Contains(prezimePretaziTextBox.Text.Trim().ToLower()));
                }

                if (!string.IsNullOrEmpty(indeksPretraziTextBox.Text))
                {
                    query = query.Where(s => s.BrojIndeksa.Contains(indeksPretraziTextBox.Text));
                }

                if (smerPretraziComboBox.SelectedItem != null)
                {
                    query = query.Where(s => s.Smer.Trim() == smerPretraziComboBox.SelectedItem.ToString());
                }

                IList<StudentBasic> studenti = query.Select(s => new StudentBasic
                {
                    Id = s.Id,
                    LicnoIme = s.LicnoIme,
                    ImeRoditelja = s.ImeRoditelja,
                    Prezime = s.Prezime,
                    BrojIndeksa = s.BrojIndeksa,
                    Smer = s.Smer
                }).ToList();

                studentDataGridView.Rows.Clear();

                foreach (var s in studenti)
                {
                    studentDataGridView.Rows.Add(new string[]
                    { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                }

                studentDataGridView.Refresh();
                studentDataGridView.ClearSelection();

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
