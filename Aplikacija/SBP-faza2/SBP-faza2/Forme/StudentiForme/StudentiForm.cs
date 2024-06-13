using NHibernate;
using NHibernate.Criterion;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using SBP_faza2.Forme.GrupeForme;

namespace SBP_faza2.Forme;

public partial class StudentiForm : Form
{
    public StudentiForm()
    {
        InitializeComponent();
    }

    private void buttonDodaj_Click(object sender, EventArgs e)
    {
        DodajStudentaForm dodajStudentaForma = new DodajStudentaForm();
        dodajStudentaForma.ShowDialog(this);
    }

    private void buttonAzuriraj_Click(object sender, EventArgs e)
    {
        AzurirajStudentaForm azurirajStudentaForma = new AzurirajStudentaForm(int.Parse(listViewStudenti.SelectedItems[0].SubItems[0].Text));
        azurirajStudentaForma.ShowDialog(this);
    }

    private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
    {
        PrakticniProjektiForm prakticniProjektiForm = new PrakticniProjektiForm();
        prakticniProjektiForm.ShowDialog(this);
    }

    private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
    {
        TeorijskiProjektiForm teorijskiProjektiForm = new TeorijskiProjektiForm();
        teorijskiProjektiForm.ShowDialog(this);
    }

    private void buttonGrupe_Click(object sender, EventArgs e)
    {
        GrupeForm grupeForma = new GrupeForm();
        grupeForma.ShowDialog();
    }

    private void StudentiForm_Load(object sender, EventArgs e)
    {
        listViewStudenti.View = View.Details;
        listViewStudenti.Columns.Add("Id", 50, HorizontalAlignment.Left);
        listViewStudenti.Columns.Add("Ime", 120, HorizontalAlignment.Left);
        listViewStudenti.Columns.Add("Ime roditelja", 120, HorizontalAlignment.Left);
        listViewStudenti.Columns.Add("Prezime", 120, HorizontalAlignment.Left);
        listViewStudenti.Columns.Add("Broj indeksa", 120, HorizontalAlignment.Left);
        listViewStudenti.Columns.Add("Smer", 80, HorizontalAlignment.Left);
    }

    private void listViewStudenti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listViewStudenti.SelectedIndices.Count == 1)
        {
            buttonAzuriraj.Enabled = true;
            buttonObrisiStudenta.Enabled = true;
            buttonPrakticniProjekti.Enabled = true;
            buttonTeorijskiProjekti.Enabled = true;
            buttonGrupe.Enabled = true;
        }
    }

    private void buttonObrisiStudenta_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                int id = int.Parse(listViewStudenti.SelectedItems[0].SubItems[0].Text);
                Student student = session.Load<Student>(id);

                session.Delete(student);
                session.Flush();

                session.Close();

                MessageBox.Show("Student uspešno obrisan");
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

    private void StudentiForm_Activated(object sender, EventArgs e)
    {
        buttonAzuriraj.Enabled = false;
        buttonObrisiStudenta.Enabled = false;
        buttonPrakticniProjekti.Enabled = false;
        buttonTeorijskiProjekti.Enabled = false;
        buttonGrupe.Enabled = false;

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

                    

                    listViewStudenti.Items.Clear();

                    foreach (var s in studenti)
                    {
                        var listItem = new ListViewItem(new string[]
                        { s.Id.ToString(), s.LicnoIme, s.ImeRoditelja, s.Prezime, s.BrojIndeksa, s.Smer });
                        listViewStudenti.Items.Add(listItem);
                    }

                    listViewStudenti.Refresh();
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