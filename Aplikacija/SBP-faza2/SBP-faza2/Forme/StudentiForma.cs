using NHibernate.Criterion;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using System.Data;

namespace SBP_faza2.Forme;

public partial class StudentiForma : Form
{
    public StudentiForma()
    {
        InitializeComponent();
    }

    private void dodajStudentaToolStripButton_Click(object sender, EventArgs e)
    {
        dodajStudentaToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = true;
        odustaniToolStripButton.Enabled = true;

        licnoImeTextBox.Enabled = true;
        imeRoditeljaTextBox.Enabled = true;
        prezimeTextBox.Enabled = true;
        brojIndeksaTextBox.Enabled = true;
        smerComboBox.Enabled = true;
    }

    private void odustaniToolStripButton_Click(object sender, EventArgs e)
    {
        odustaniToolStripButton.Enabled = false;
        sacuvajToolStripButton.Enabled = false;
        dodajStudentaToolStripButton.Enabled = true;

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
    }

    private void studentaDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (studentaDataGridView.SelectedRows.Count > 0)
        {
            izmeniStudentaToolStripButton.Enabled = true;
            obrisiStudentaToolStripButton.Enabled = true;
        }
        else
        {
            izmeniStudentaToolStripButton.Enabled = false;
            obrisiStudentaToolStripButton.Enabled = false;
        }
    }

    private void StudentiForma_Activated(object sender, EventArgs e)
    {
        try
        {
            using (ISession? session = DataLayer.GetSession())
            {
                if (session != null)
                {
                    IList<StudentList> studenti = session.QueryOver<Student>()
                        .Select(
                            Projections.Property("Id"),
                            Projections.Property("LicnoIme"),
                            Projections.Property("ImeRoditelja"),
                            Projections.Property("Prezime"),
                            Projections.Property("BrojIndeksa"),
                            Projections.Property("Smer")
                        ).List<object[]>()
                        .Select(row => new StudentList
                        {
                            Id = (int)row[0],
                            LicnoIme = (string)row[1],
                            ImeRoditelja = (string)row[2],
                            Prezime = (string)row[3],
                            BrojIndeksa = (string)row[4],
                            Smer = (string)row[5]
                        }).ToList();


                    for (int i = 0; i < studentaDataGridView.Rows.Count; i++)
                        studentaDataGridView.Rows.RemoveAt(i);

                    foreach (var s in studenti)
                    {
                        studentaDataGridView.Rows.Add(new string[]
                        { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                    }

                    studentaDataGridView.Refresh();

                    if (studentaDataGridView.RowCount > 0)
                    {
                        studentaDataGridView.ClearSelection();
                    }
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
}
