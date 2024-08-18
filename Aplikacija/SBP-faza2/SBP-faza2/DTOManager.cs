using NHibernate;
using NHibernate.Linq;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2;

public class DTOManager
{
    #region Student
    public static async Task<Student?> vratiStudentAsync(long id)
    {
        Student? student = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                student = await session.LoadAsync<Student>(id);

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja studenta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return student;
    }

    public static async Task<bool> PostojiIndeks(string indeks)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student? student = await session.Query<Student>().FirstOrDefaultAsync(s => s.BrojIndeksa.Trim() == indeks);
                if (student != null) 
                    return true;
                else 
                    return false;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja studenta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<StudentBasic?> vratiStudentBasicAsync(long id)
    {
        StudentBasic? student = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student s = await session.LoadAsync<Student>(id);
                student = new StudentBasic
                {
                    Id = s.Id,
                    LicnoIme = s.LicnoIme,
                    ImeRoditelja = s.ImeRoditelja,
                    Prezime = s.Prezime,
                    BrojIndeksa = s.BrojIndeksa,
                    Smer = s.Smer
                };

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja studenta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return student;
    }

    public static List<StudentBasic>? vratiStudenteBasic()
    {
        List<StudentBasic>? studenti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Student> s = session.Query<Student>();

                studenti = new List<StudentBasic>();
                foreach (var stud in s)
                {
                    studenti.Add(new StudentBasic
                    {
                        Id = stud.Id,
                        LicnoIme = stud.LicnoIme,
                        ImeRoditelja = stud.ImeRoditelja,
                        Prezime = stud.Prezime,
                        BrojIndeksa = stud.BrojIndeksa,
                        Smer = stud.Smer
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja studenata iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return studenti;
    }

    public static List<string>? vratiImeRoditeljPrezimeStudenta()
    {
        List<string>? studentiImeRoditeljPrezime = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Student> studenti = session.Query<Student>();

                studentiImeRoditeljPrezime = new List<string>();
                foreach (var s in studenti)
                {
                    studentiImeRoditeljPrezime
                        .Add(s.LicnoIme + " " + s.ImeRoditelja + " " + s.Prezime);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja studenata iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return studentiImeRoditeljPrezime;
    }

    public static async Task<bool> izmeniStudentaAsync(StudentBasic student)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student s = session.Load<Student>(student.Id);

                s.LicnoIme = PrvoSlovoVeliko(student.LicnoIme.Trim());
                s.ImeRoditelja = PrvoSlovoVeliko(student.ImeRoditelja.Trim());
                s.Prezime = PrvoSlovoVeliko(student.Prezime.Trim());
                s.BrojIndeksa = student.BrojIndeksa;
                s.Smer = student.Smer;

                await session.SaveOrUpdateAsync(s);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja studenta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> dodajStudentaAsync(StudentBasic student)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student s = new Student
                {
                    LicnoIme = PrvoSlovoVeliko(student.LicnoIme.Trim()),
                    ImeRoditelja = PrvoSlovoVeliko(student.ImeRoditelja.Trim()),
                    Prezime = PrvoSlovoVeliko(student.Prezime.Trim()),
                    BrojIndeksa = student.BrojIndeksa,
                    Smer = student.Smer
                };

                await session.SaveAsync(s);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom čuvanja studenta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> obrisiStudentaAsync(long id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student student = await session.LoadAsync<Student>(id);

                await session.DeleteAsync(student);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja studenta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    private static string PrvoSlovoVeliko(string input)
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

    #endregion
}
