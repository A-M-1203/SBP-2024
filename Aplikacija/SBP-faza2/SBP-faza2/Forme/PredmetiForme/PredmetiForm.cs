using NHibernate;
using NHibernate.Criterion;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme.PredmetiForme;

public partial class PredmetiForm : Form
{
    public PredmetiForm()
    {
        InitializeComponent();
    }

    private void buttonDodaj_Click(object sender, EventArgs e)
    {
        DodajPredmetForm dodajPredmetForma = new DodajPredmetForm();
        dodajPredmetForma.ShowDialog(this);
    }

    private void buttonAzuriraj_Click(object sender, EventArgs e)
    {
        AzurirajPredmetForm azurirajPredmetForma = new AzurirajPredmetForm(int.Parse(listViewPredmeti.SelectedItems[0].SubItems[0].Text));
        azurirajPredmetForma.ShowDialog(this);
    }

    private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
    {
        PrakticniProjektiForm prakticniProjektiForma = new PrakticniProjektiForm();
        prakticniProjektiForma.ShowDialog(this);
    }

    private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
    {
        TeorijskiProjektiForm teorijskiProjektiForma = new TeorijskiProjektiForm();
        teorijskiProjektiForma.ShowDialog(this);
    }

    private void PredmetiForm_Load(object sender, EventArgs e)
    {
        listViewPredmeti.View = View.Details;
        listViewPredmeti.Columns.Add("Id", 30, HorizontalAlignment.Left);
        listViewPredmeti.Columns.Add("Sifra", 120, HorizontalAlignment.Left);
        listViewPredmeti.Columns.Add("Naziv", 200, HorizontalAlignment.Left);
        listViewPredmeti.Columns.Add("Katedra", 120, HorizontalAlignment.Left);
        listViewPredmeti.Columns.Add("Semestar", 90, HorizontalAlignment.Left);
    }

    private void listViewPredmeti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listViewPredmeti.SelectedIndices.Count == 1)
        {
            buttonAzuriraj.Enabled = true;
            buttonObrisi.Enabled = true;
            buttonPrakticniProjekti.Enabled = true;
            buttonTeorijskiProjekti.Enabled = true;
        }
        else
        {
            buttonAzuriraj.Enabled = false;
            buttonObrisi.Enabled = false;
            buttonPrakticniProjekti.Enabled = false;
            buttonTeorijskiProjekti.Enabled = false;
        }
    }

    private void buttonObrisi_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                int id = int.Parse(listViewPredmeti.SelectedItems[0].SubItems[0].Text);
                Predmet predmet = session.Load<Predmet>(id);

                session.Delete(predmet);
                session.Flush();

                session.Close();

                MessageBox.Show("Predmet uspešno obrisan");
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

    private void PredmetiForm_Activated(object sender, EventArgs e)
    {
        buttonAzuriraj.Enabled = false;
        buttonObrisi.Enabled = false;
        buttonPrakticniProjekti.Enabled = false;
        buttonTeorijskiProjekti.Enabled = false;

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

                    listViewPredmeti.Items.Clear();

                    foreach (var p in predmeti)
                    {
                        var listItem = new ListViewItem(new string[]
                        { p.Id.ToString(), p.Sifra, p.Naziv, p.Katedra, p.Semestar });
                        listViewPredmeti.Items.Add(listItem);
                    }

                    listViewPredmeti.Refresh();
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