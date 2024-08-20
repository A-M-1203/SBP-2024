using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;
using SBP_faza2.Forme;
using SBP_faza2.Forme.PredmetiForme;

namespace SBP_faza2;

public partial class Form1 : Form
{
    string exception = string.Empty;
    public Form1()
    {
        InitializeComponent();

        try
        {
            ISession? session = DataLayer.GetSession();

            session?.Close();

            statusLabel.Text = "POVEZAN";
            statusLabel.ForeColor = Color.Green;
        }
        catch (Exception ec)
        {
            detaljiLinkLabel.Visible = true;
            exception = ec.FormatExceptionMessage();
        }
    }

    private void btnVratiStudenta_Click(object sender, EventArgs e)
    {
        try
        {
            ISession? session = DataLayer.GetSession();

            Student s = session!.Load<Student>(4);

            MessageBox.Show(s.LicnoIme + " " + s.ImeRoditelja + " " + s.Prezime);

            session.Close();
        }
        catch (Exception ec)
        {
            MessageBox.Show(ec.Message);
        }
    }

    private void buttonStudenti_Click(object sender, EventArgs e)
    {
        StudentiForm studentiForma = new StudentiForm();
        studentiForma.ShowDialog(this);
    }

    private void buttonTeorijskiProjekti_Click(object sender, EventArgs e)
    {
        TeorijskiProjektiForm teorijskiProjektiForma = new TeorijskiProjektiForm();
        teorijskiProjektiForma.ShowDialog(this);
    }

    private void buttonPrakticniProjekti_Click(object sender, EventArgs e)
    {
        PrakticniProjektiForm prakticniProjektiForma = new PrakticniProjektiForm();
        prakticniProjektiForma.ShowDialog(this);
    }

    private void buttonPredmeti_Click(object sender, EventArgs e)
    {
        PredmetiForm predmetiForma = new PredmetiForm();
        predmetiForma.ShowDialog(this);
    }

    private void minButton_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        dateTimeLabel.Text = DateTime.Now.Date.ToShortDateString()
            + " | " + DateTime.Now.ToLongTimeString();
    }

    private void detaljiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show(exception);
    }

    private void studentiButton_Click(object sender, EventArgs e)
    {
        StudentiForma studentiForma = new StudentiForma();
        studentiForma.Show(this);
    }

    private void predmetiButton_Click(object sender, EventArgs e)
    {
        PredmetiForma predmetiForma = new PredmetiForma();
        predmetiForma.Show(this);
    }

    private void projektiButton_Click(object sender, EventArgs e)
    {
        ProjektiForma projektiForma = new ProjektiForma();
        projektiForma.Show(this);
    }

    private void grupeButton_Click(object sender, EventArgs e)
    {
        GrupeForma grupeForma = new GrupeForma();
        grupeForma.Show(this);
    }

    private void nastavniciButton_Click(object sender, EventArgs e)
    {
        NastavniciForma nastavniciForma = new NastavniciForma();
        nastavniciForma.Show(this);
    }
}