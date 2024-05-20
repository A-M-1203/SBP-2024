using NHibernate;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}