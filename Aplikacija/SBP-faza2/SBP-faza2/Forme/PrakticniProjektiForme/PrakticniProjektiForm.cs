using FluentNHibernate.Conventions;
using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Forme.IzvestajiForme;
using SBP_faza2.Forme.PrakticniProjektiForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme
{
    public partial class PrakticniProjektiForm : Form
    {
        public PrakticniProjektiForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajPrakticniProjekatForm dodajPrakticniProjekatForma = new DodajPrakticniProjekatForm();
            dodajPrakticniProjekatForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajPrakticniProjekatForm azurirajPrakticniProjekatForma = new AzurirajPrakticniProjekatForm();
            azurirajPrakticniProjekatForma.ShowDialog(this);
        }

        private void buttonIzvestaji_Click(object sender, EventArgs e)
        {
            IzvestajiForm izvestajiForma = new IzvestajiForm();
            izvestajiForma.ShowDialog();
        }

        private void PrakticniProjektiForm_Load(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("select p.Id, p.Naziv, p.SkolskaGodina, p.Grupni, p.DatumPocetka, p.DatumZavrsetka, p.RokZaZavrsetak, p.PreporuceniProgramskiJezik, p.KratakOpis, p.BrojIzvestaja from Projekat as p");
                    IEnumerable<object[]> prakticniProjekti = query.Enumerable<object[]>();
                    if (prakticniProjekti.IsNotEmpty())
                    {
                        string?[] stringArray = prakticniProjekti.Select(x => x == null ? "null" : x.ToString()).ToArray();

                        foreach (object[] s in prakticniProjekti)
                        {
                            ListViewItem listViewItem = new ListViewItem(new string[] { stringArray[0]!, stringArray[1]!, stringArray[2]!, stringArray[3]!, stringArray[4]!, stringArray[5]!, stringArray[6]!, stringArray[7]!, stringArray[8]!, stringArray[9]! });
                            listViewPrakticniProjekti.Items.Add(listViewItem);
                        }

                        listViewPrakticniProjekti.Refresh();
                    }

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

        private void PrakticniProjektiForm_Activated(object sender, EventArgs e)
        {
            try
            {
                ISession? session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("select p.Id, p.Naziv, p.SkolskaGodina, p.Grupni, p.DatumPocetka, p.DatumZavrsetka, p.RokZaZavrsetak, p.PreporuceniProgramskiJezik, p.KratakOpis, p.BrojIzvestaja from Projekat as p");
                    IEnumerable<object[]> prakticniProjekti = query.Enumerable<object[]>();
                    if (prakticniProjekti.IsNotEmpty())
                    {
                        string?[] stringArray = prakticniProjekti.Select(x => x == null ? "null" : x.ToString()).ToArray();

                        listViewPrakticniProjekti.Clear();

                        foreach (object[] s in prakticniProjekti)
                        {
                            ListViewItem listViewItem = new ListViewItem(new string[] { stringArray[0]!, stringArray[1]!, stringArray[2]!, stringArray[3]!, stringArray[4]!, stringArray[5]!, stringArray[6]!, stringArray[7]!, stringArray[8]!, stringArray[9]! });
                            listViewPrakticniProjekti.Items.Add(listViewItem);
                        }

                        listViewPrakticniProjekti.Refresh();
                    }

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
}