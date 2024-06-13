using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Forme.PredmetiForme;

public partial class AzurirajPredmetForm : Form
{
    private readonly int _predmetId;

    public AzurirajPredmetForm()
    {
        InitializeComponent();
    }

    public AzurirajPredmetForm(int predmetId)
    {
        InitializeComponent();
        _predmetId = predmetId;
    }

    private void textBoxNazivPredmeta_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
        {
            e.Handled = true;
        }
    }

    private void textBoxSifraPredmeta_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void textBoxNazivPredmeta_TextChanged(object sender, EventArgs e)
    {
        bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                            !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                            comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

        buttonAzurirajPredmet.Enabled = enableButton;
    }

    private void textBoxSifraPredmeta_TextChanged(object sender, EventArgs e)
    {
        bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                            !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                            comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

        buttonAzurirajPredmet.Enabled = enableButton;
    }

    private void comboBoxKatedra_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                            !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                            comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

        buttonAzurirajPredmet.Enabled = enableButton;
    }

    private void comboBoxSemestar_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool enableButton = !string.IsNullOrWhiteSpace(textBoxNazivPredmeta.Text) &&
                            !string.IsNullOrWhiteSpace(textBoxSifraPredmeta.Text) &&
                            comboBoxKatedra.SelectedIndex >= 0 && comboBoxSemestar.SelectedIndex >= 0;

        buttonAzurirajPredmet.Enabled = enableButton;
    }

    private void buttonAzurirajPredmet_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();

            if (session != null)
            {
                Predmet predmet = session.Load<Predmet>(_predmetId);
                predmet.Naziv = textBoxNazivPredmeta.Text;
                predmet.Sifra = textBoxSifraPredmeta.Text;
                predmet.Semestar = comboBoxSemestar.SelectedItem!.ToString()!;
                predmet.Katedra = comboBoxKatedra.SelectedItem!.ToString()!;

                session.SaveOrUpdate(predmet);
                session.Flush();

                session.Close();

                MessageBox.Show("Predmet uspešno ažuriran");
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

    private void AzurirajPredmetForm_Load(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();

            if (session != null)
            {
                Predmet predmet = session.Load<Predmet>(_predmetId);
                textBoxNazivPredmeta.Text = predmet.Naziv;
                textBoxSifraPredmeta.Text = predmet.Sifra;
                comboBoxSemestar.SelectedItem = predmet.Semestar;
                comboBoxKatedra.SelectedItem = predmet.Katedra;
            }
        }
        catch(Exception ec)
        {
            Console.WriteLine(ec.Message);
        }
    }
}