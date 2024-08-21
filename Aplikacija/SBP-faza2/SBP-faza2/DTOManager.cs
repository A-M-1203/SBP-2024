using NHibernate;
using NHibernate.Linq;
using SBP_faza2.Data;
using SBP_faza2.Entiteti;

namespace SBP_faza2;

public class DTOManager
{
    #region Student
    public static async Task<Student?> VratiStudentAsync(long id)
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

    public static async Task<bool> PostojiIndeksAsync(string indeks)
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

    public static async Task<StudentBasic?> VratiStudentBasicAsync(long id)
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

    public static List<StudentBasic>? VratiStudenteBasic()
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

    public static List<string>? VratiImeRoditeljPrezimeStudenta()
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

    public static async Task<bool> IzmeniStudentAsync(StudentBasic student)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Student s = await session.LoadAsync<Student>(student.Id);

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

    public static async Task<bool> DodajStudentAsync(StudentBasic student)
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

    public static async Task<bool> ObrisiStudentAsync(long id)
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

    #region Predmet

    public static async Task<Predmet?> VratiPredmetAsync(long id)
    {
        Predmet? predmet = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                predmet = await session.LoadAsync<Predmet>(id);

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmet;
    }

    public static async Task<Predmet?> VratiPredmetAsync(string naziv, string sifra)
    {
        Predmet? predmet = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                predmet = await session.Query<Predmet>().FirstAsync(p => p.Naziv == naziv && p.Sifra == sifra);

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmet;
    }

    public static async Task<List<string>?> VratiPredmetePoSemestruAsync(string semestar)
    {
        List<string>? predmeti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                predmeti = await session.Query<Predmet>()
                    .Where(p => p.Semestar.Trim() == semestar.Trim())
                    .Select(p => p.Naziv + " " + "(" + p.Sifra + ")")
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmeti;
    }

    public static async Task<List<string>?> VratiPredmetePoTipuProjektaAsync(string tipProjekta)
    {
        List<string>? predmeti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IList<Projekat> projekti = await session.Query<Projekat>().ToListAsync();
                predmeti = new List<string>();
                if (tipProjekta == "Teorijski")
                {
                    foreach (var p in projekti)
                    {
                        if (p.GetType() == typeof(TeorijskiProjekat))
                        {
                            if (predmeti.Contains(p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")") == false)
                            {
                                predmeti.Add(p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")");
                            }
                        }
                    }
                }
                else
                {
                    foreach (var p in projekti)
                    {
                        if (p.GetType() == typeof(PrakticniProjekat))
                        {
                            if (predmeti.Contains(p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")") == false)
                            {
                                predmeti.Add(p.Predmet.Naziv + " " + "(" + p.Predmet.Sifra + ")");
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmeti;
    }

    public static async Task<bool> PostojiSifra(string sifra)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet? predmet = await session.Query<Predmet>().FirstOrDefaultAsync(s => s.Sifra == sifra);
                if (predmet != null)
                    return true;
                else
                    return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<PredmetBasic?> VratiPredmetBasicAsync(long id)
    {
        PredmetBasic? predmet = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet p = await session.LoadAsync<Predmet>(id);
                predmet = new PredmetBasic
                {
                    Id = p.Id,
                    Sifra = p.Sifra,
                    Naziv = p.Naziv,
                    Katedra = p.Katedra,
                    Semestar = p.Semestar
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

        return predmet;
    }

    public static async Task<PredmetBasic?> VratiPredmetBasicAsync(string naziv, string sifra)
    {
        PredmetBasic? predmet = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet p = await session.Query<Predmet>().FirstAsync(p => p.Naziv == naziv && p.Sifra == sifra);
                predmet = new PredmetBasic
                {
                    Id = p.Id,
                    Sifra = p.Sifra,
                    Naziv = p.Naziv,
                    Katedra = p.Katedra,
                    Semestar = p.Semestar
                };

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmet;
    }

    public static List<PredmetBasic>? VratiPredmeteBasic()
    {
        List<PredmetBasic>? predmeti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Predmet> p = session.Query<Predmet>();

                predmeti = new List<PredmetBasic>();
                foreach (var pred in p)
                {
                    predmeti.Add(new PredmetBasic
                    {
                        Id = pred.Id,
                        Sifra = pred.Sifra,
                        Naziv = pred.Naziv,
                        Katedra = pred.Katedra,
                        Semestar = pred.Semestar
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmeti;
    }

    public static async Task<List<string>?> VratiNazivSifruPredmeta()
    {
        List<string>? predmetiNazivSifra = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                predmetiNazivSifra = await session.Query<Predmet>()
                    .Select(p => p.Naziv + " " + "(" + p.Sifra + ")").ToListAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmetiNazivSifra;
    }

    public static List<string>? VratiNazivSifruPredmeta(string semestar)
    {
        List<string>? predmetiNazivSifra = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Predmet> predmeti = session.Query<Predmet>()
                    .Where(p => p.Semestar.Trim() == semestar.Trim());

                predmetiNazivSifra = new List<string>();
                foreach (var p in predmeti)
                {
                    predmetiNazivSifra
                        .Add(p.Naziv + " " + "(" + p.Sifra + ")");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja predmeta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return predmetiNazivSifra;
    }

    public static async Task<bool> IzmeniPredmetAsync(PredmetBasic predmet)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet p = session.Load<Predmet>(predmet.Id);

                p.Sifra = predmet.Sifra;
                p.Naziv = predmet.Naziv.Trim();
                p.Katedra = predmet.Katedra;
                p.Semestar = predmet.Semestar;

                await session.SaveOrUpdateAsync(p);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja predmeta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajPredmetAsync(PredmetBasic predmet)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet p = new Predmet
                {
                    Sifra = predmet.Sifra,
                    Naziv = predmet.Naziv.Trim(),
                    Katedra = predmet.Katedra,
                    Semestar = predmet.Semestar
                };

                await session.SaveAsync(p);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom čuvanja predmeta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiPredmetAsync(long id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet predmet = await session.LoadAsync<Predmet>(id);

                await session.DeleteAsync(predmet);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja predmeta.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    #endregion

    #region Projekat

    public static async Task<Projekat?> VratiProjekatAsync(long id)
    {
        Projekat? projekat = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                projekat = await session.LoadAsync<Projekat>(id);

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return projekat;
    }

    public static async Task<Projekat?> VratiProjekatPoNazivuAsync(string nazivProjekta)
    {
        Projekat? projekat = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                projekat = await session.Query<Projekat>().FirstAsync(p => p.Naziv == nazivProjekta);

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return projekat;
    }

    public static async Task<ProjekatBasic?> VratiProjekatBasicPoNazivuAsync(string nazivProjekta)
    {
        ProjekatBasic? projekat = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat p = (await DTOManager.VratiProjekatPoNazivuAsync(nazivProjekta))!;
                PredmetBasic pred = (await DTOManager.VratiPredmetBasicAsync(p.Predmet.Id))!;
                if (p.GetType() == typeof(TeorijskiProjekat))
                {
                    projekat = new TeorijskiProjekatBasic
                    {
                        Id = p.Id,
                        Naziv = p.Naziv,
                        SkolskaGodina = p.SkolskaGodina,
                        Grupni = p.Grupni,
                        RokZaZavrsetak = p.RokZaZavrsetak,
                        MaksimalanBrojStrana = p.MaksimalanBrojStrana,
                        Predmet = pred,
                        Tip = "Teorijski",
                        DatumPocetka = p.DatumPocetka,
                        DatumZavrsetka = p.DatumZavrsetka
                    };
                }
                else
                {
                    projekat = new PrakticniProjekatBasic
                    {
                        Id = p.Id,
                        Naziv = p.Naziv,
                        SkolskaGodina = p.SkolskaGodina,
                        Grupni = p.Grupni,
                        RokZaZavrsetak = p.RokZaZavrsetak,
                        PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik,
                        BrojIzvestaja = p.BrojIzvestaja,
                        KratakOpis = p.KratakOpis,
                        Predmet = pred,
                        Tip = "Teorijski",
                        DatumPocetka = p.DatumPocetka,
                        DatumZavrsetka = p.DatumZavrsetka
                    };
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return projekat;
    }

    public static async Task<ProjekatBasic?> VratiProjekatBasicAsync(long id)
    {
        ProjekatBasic? projekat = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat p = await session.LoadAsync<Projekat>(id);
                if (p.GetType() == typeof(TeorijskiProjekat))
                {
                    projekat = new TeorijskiProjekatBasic
                    {
                        Id = p.Id,
                        Naziv = p.Naziv,
                        SkolskaGodina = p.SkolskaGodina,
                        Grupni = p.Grupni,
                        RokZaZavrsetak = p.RokZaZavrsetak,
                        MaksimalanBrojStrana = p.MaksimalanBrojStrana,
                        PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik,
                        KratakOpis = p.KratakOpis,
                        BrojIzvestaja = p.BrojIzvestaja,
                        Predmet = (await DTOManager.VratiPredmetBasicAsync(p.Predmet.Id))!,
                        Tip = "Teorijski",
                        DatumPocetka = p.DatumPocetka,
                        DatumZavrsetka = p.DatumZavrsetka
                    };
                }
                else
                {
                    projekat = new PrakticniProjekatBasic
                    {
                        Id = p.Id,
                        Naziv = p.Naziv,
                        SkolskaGodina = p.SkolskaGodina,
                        Grupni = p.Grupni,
                        RokZaZavrsetak = p.RokZaZavrsetak,
                        MaksimalanBrojStrana = p.MaksimalanBrojStrana,
                        PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik,
                        KratakOpis = p.KratakOpis,
                        BrojIzvestaja = p.BrojIzvestaja,
                        Predmet = (await DTOManager.VratiPredmetBasicAsync(p.Predmet.Id))!,
                        Tip = "Praktični",
                        DatumPocetka = p.DatumPocetka,
                        DatumZavrsetka = p.DatumZavrsetka
                    };
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return projekat;
    }

    public static List<ProjekatPregled>? VratiSveProjektePregled()
    {
        List<ProjekatPregled>? projekti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Projekat> p = session.Query<Projekat>();

                projekti = new List<ProjekatPregled>();
                foreach (var proj in p)
                {
                    if (proj.GetType() == typeof(TeorijskiProjekat))
                    {
                        projekti.Add(new ProjekatPregled
                        {
                            Id = proj.Id,
                            Naziv = proj.Naziv,
                            SkolskaGodina = proj.SkolskaGodina,
                            Grupni = proj.Grupni,
                            RokZaZavrsetak = proj.RokZaZavrsetak,
                            MaksimalanBrojStrana = proj.MaksimalanBrojStrana,
                            PreporuceniProgramskiJezik = proj.PreporuceniProgramskiJezik,
                            KratakOpis = proj.KratakOpis,
                            BrojIzvestaja = proj.BrojIzvestaja,
                            Tip = "Teorijski",
                            Predmet = proj.Predmet.Naziv + " " + "(" + proj.Predmet.Sifra + ")",
                            DatumPocetka = proj.DatumPocetka,
                            DatumZavrsetka = proj.DatumZavrsetka
                        });
                    }
                    else
                    {
                        projekti.Add(new ProjekatPregled
                        {
                            Id = proj.Id,
                            Naziv = proj.Naziv,
                            SkolskaGodina = proj.SkolskaGodina,
                            Grupni = proj.Grupni,
                            RokZaZavrsetak = proj.RokZaZavrsetak,
                            MaksimalanBrojStrana = proj.MaksimalanBrojStrana,
                            PreporuceniProgramskiJezik = proj.PreporuceniProgramskiJezik,
                            KratakOpis = proj.KratakOpis,
                            BrojIzvestaja = proj.BrojIzvestaja,
                            Tip = "Praktični",
                            Predmet = proj.Predmet.Naziv + " " + "(" + proj.Predmet.Sifra + ")",
                            DatumPocetka = proj.DatumPocetka,
                            DatumZavrsetka = proj.DatumZavrsetka
                        });
                    }
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekata iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return projekti;
    }

    public static async Task<List<TeorijskiProjekat>?> VratiTeorijskeProjekteAsync()
    {
        List<TeorijskiProjekat>? teorijskiProjekti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                teorijskiProjekti = await session.Query<TeorijskiProjekat>().ToListAsync();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekata iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
              "Greška",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
        }

        return teorijskiProjekti;
    }

    public static async Task<List<PrakticniProjekat>?> VratiPrakticneProjekteAsync()
    {
        List<PrakticniProjekat>? prakticniProjekti = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                prakticniProjekti = await session.Query<PrakticniProjekat>().ToListAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekata iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
              "Greška",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
        }

        return prakticniProjekti;
    }

    public static async Task<bool> PostojiProjekatAsync(string naziv, string skolskaGodina, Type tip)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat? projekat = await session.Query<Projekat>()
                    .FirstOrDefaultAsync(p => p.Naziv.Trim() == naziv.Trim() && p.SkolskaGodina == skolskaGodina);
         
                if (projekat != null && projekat.GetType() == tip)
                    return true;
                else
                    return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> IzmeniProjekatAsync(ProjekatBasic projekat)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat p;
                if (projekat.GetType() == typeof(TeorijskiProjekatBasic))
                {
                    p = session.Load<Projekat>(projekat.Id);
                    p.Naziv = projekat.Naziv;
                    p.SkolskaGodina = projekat.SkolskaGodina;
                    p.Grupni = projekat.Grupni;
                    p.RokZaZavrsetak = projekat.RokZaZavrsetak;
                    p.MaksimalanBrojStrana = projekat.MaksimalanBrojStrana;
                    p.Predmet = (((p.Predmet.Naziv != projekat.Predmet.Naziv)
                        || (p.Predmet.Sifra != projekat.Predmet.Sifra)) 
                        ? await VratiPredmetAsync(projekat.Predmet.Id) : p.Predmet)!;
                    p.DatumPocetka = projekat.DatumPocetka;
                    p.DatumZavrsetka = projekat.DatumZavrsetka;
                }
                else
                {
                    p = session.Load<Projekat>(projekat.Id);
                    p.Naziv = projekat.Naziv;
                    p.SkolskaGodina = projekat.SkolskaGodina;
                    p.Grupni = projekat.Grupni;
                    p.RokZaZavrsetak = projekat.RokZaZavrsetak;
                    p.PreporuceniProgramskiJezik = projekat.PreporuceniProgramskiJezik;
                    p.KratakOpis = projekat.KratakOpis;
                    p.BrojIzvestaja = projekat.BrojIzvestaja;
                    p.Predmet = (((p.Predmet.Naziv != projekat.Predmet.Naziv)
                        || (p.Predmet.Sifra != projekat.Predmet.Sifra))
                        ? await VratiPredmetAsync(projekat.Predmet.Id) : p.Predmet)!;
                    p.DatumPocetka = projekat.DatumPocetka;
                    p.DatumZavrsetka = projekat.DatumZavrsetka;
                }

                await session.SaveOrUpdateAsync(p);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja projekta u bazi.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajProjekatAsync(ProjekatBasic projekat)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Predmet? predmet = await session.LoadAsync<Predmet>(projekat.Predmet.Id);
                if (predmet != null) 
                {
                    Projekat p;
                    if (projekat.GetType() == typeof(TeorijskiProjekatBasic))
                    {
                        p = new TeorijskiProjekat
                        {
                            Naziv = projekat.Naziv,
                            SkolskaGodina = projekat.SkolskaGodina,
                            Grupni = projekat.Grupni,
                            RokZaZavrsetak = projekat.RokZaZavrsetak,
                            MaksimalanBrojStrana = projekat.MaksimalanBrojStrana,
                            Predmet = predmet,
                            DatumPocetka = projekat.DatumPocetka,
                            DatumZavrsetka = projekat.DatumZavrsetka
                        };
                    }
                    else
                    {
                        p = new PrakticniProjekat
                        {
                            Naziv = projekat.Naziv,
                            SkolskaGodina = projekat.SkolskaGodina,
                            Grupni = projekat.Grupni,
                            RokZaZavrsetak = projekat.RokZaZavrsetak,
                            PreporuceniProgramskiJezik = projekat.PreporuceniProgramskiJezik,
                            KratakOpis = projekat.KratakOpis,
                            BrojIzvestaja = projekat.BrojIzvestaja,
                            Predmet = predmet,
                            DatumPocetka = projekat.DatumPocetka,
                            DatumZavrsetka = projekat.DatumZavrsetka
                        };
                    }

                    await session.SaveAsync(p);
                    await session.FlushAsync();
                    session.Close();
                    return true;
                }

                session.Close();
                return false;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom dodavanja projekta u bazu.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiProjekatAsync(long id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat projekat = session.Load<Projekat>(id);

                await session.DeleteAsync(projekat);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja projekta iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<List<string>?> VratiSkolskeGodine()
    {
        List<string>? skolskeGodine = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                skolskeGodine = await session.Query<Projekat>()
                    .Select(p => p.SkolskaGodina.Trim()).Distinct().ToListAsync();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja školskih godina iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
               "Greška",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }

        return skolskeGodine;
    }

    #endregion

    #region Grupa

    public static async Task<GrupaBasic?> VratiGrupaBasicAsync(long id)
    {
        GrupaBasic? grupa = null;

        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Grupa g = await session.LoadAsync<Grupa>(id);
                ProjekatBasic p = (await DTOManager.VratiProjekatBasicAsync(g.Projekat.Id))!;
                grupa = new GrupaBasic
                {
                    Id = g.Id,
                    Naziv = g.NazivGrupe,
                    Projekat = p
                };

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja grupe iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return grupa;
    }

    public static async Task<List<GrupaBasic>?> VratiGrupeBasicAsync()
    {
        List<GrupaBasic>? grupe = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                ProjekatBasic p;
                IEnumerable<Grupa> g = session.Query<Grupa>();

                grupe = new List<GrupaBasic>();
                foreach (var gru in g)
                {
                    p = (await DTOManager.VratiProjekatBasicAsync(gru.Projekat.Id))!;
                    grupe.Add(new GrupaBasic
                    {
                        Id = gru.Id,
                        Naziv = gru.NazivGrupe,
                        Projekat = p
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja grupa iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return grupe;
    }

    public static List<GrupaPregled>? VratiGrupePregled()
    {
        List<GrupaPregled>? grupe = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Grupa> g = session.Query<Grupa>();

                grupe = new List<GrupaPregled>();
                foreach (var gru in g)
                {
                    grupe.Add(new GrupaPregled
                    {
                        Id = gru.Id,
                        Naziv = gru.NazivGrupe,
                        Projekat = gru.Projekat.Naziv
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja grupa iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return grupe;
    }

    public static List<GrupaPregled>? VratiGrupePoTipuProjekta(Type tipProjekta)
    {
        List<GrupaPregled>? g = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                List<GrupaPregled>? grupe = DTOManager.VratiGrupePregled();
                if (grupe != null)
                {
                    foreach (var gru in grupe)
                    {
                        if (gru.Projekat.GetType() == tipProjekta)
                            g?.Add(gru);
                    }
                }
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja grupa iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return g;
    }

    public static async Task<bool> IzmeniGrupaAsync(GrupaBasic grupa)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Grupa g = await session.LoadAsync<Grupa>(grupa.Id);

                g.NazivGrupe = grupa.Naziv.Trim();
                if (g.Projekat.Id != grupa.Projekat.Id)
                {
                    Projekat p = await session.LoadAsync<Projekat>(grupa.Projekat.Id);
                    g.Projekat = p;
                }

                await session.SaveOrUpdateAsync(g);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja grupe.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajGrupaAsync(GrupaBasic grupa)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Projekat p = await session.LoadAsync<Projekat>(grupa.Projekat.Id);

                Grupa g = new Grupa
                {
                    NazivGrupe = grupa.Naziv.Trim(),
                    Projekat = p
                };

                await session.SaveAsync(g);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom čuvanja grupe.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiGrupaAsync(long id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Grupa grupa = await session.LoadAsync<Grupa>(id);

                await session.DeleteAsync(grupa);
                await session.FlushAsync();
                session.Close();

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja grupe.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> PostojiGrupa(string naziv)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Grupa? grupa = await session.Query<Grupa>().FirstOrDefaultAsync(g => g.NazivGrupe == naziv);
                if (grupa != null)
                    return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja grupe.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    #endregion

    #region Nastavnik

    public static async Task<NastavnikBasic?> VratiNastavnikBasicAsync(int id)
    {
        NastavnikBasic? nastavnik = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Nastavnik n = await session.LoadAsync<Nastavnik>(id);
                PredmetBasic p = (await DTOManager.VratiPredmetBasicAsync(n.Predmet.Id))!;
                nastavnik = new NastavnikBasic
                {
                    Id = n.Id,
                    ImePrezime = n.ImeNastavnika,
                    Predmet = p
                };

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja nastavnika iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return nastavnik;
    }

    public static async Task<List<NastavnikBasic>?> VratiNastavnikeBasicAsync()
    {
        List<NastavnikBasic>? n = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                n = new List<NastavnikBasic>();
                IEnumerable<Nastavnik> nastavnici = session.Query<Nastavnik>();
                foreach (var nas in nastavnici)
                {
                    PredmetBasic p = (await DTOManager.VratiPredmetBasicAsync(nas.Predmet.Id))!;
                    n.Add(new NastavnikBasic
                    {
                        Id = nas.Id,
                        ImePrezime = nas.ImeNastavnika,
                        Predmet = p
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja nastavnika iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return n;
    }

    public static List<NastavnikPregled>? VratiNastavnikePregled()
    {
        List<NastavnikPregled>? n = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                n = new List<NastavnikPregled>();
                IEnumerable<Nastavnik> nastavnici = session.Query<Nastavnik>();

                foreach (var nas in nastavnici)
                {
                    n.Add(new NastavnikPregled
                    {
                        Id = nas.Id,
                        ImePrezime = nas.ImeNastavnika,
                        Predmet = nas.Predmet.Naziv + " " + "(" + nas.Predmet.Sifra + ")"
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja nastavnika iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return n;
    }

    public static List<NastavnikPregled>? VratiNastavnikePoPredmetu(string nazivPredmeta, string sifraPredmeta)
    {
        List<NastavnikPregled>? n = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                n = new List<NastavnikPregled>();
                IEnumerable<Nastavnik> nastavnici = session.Query<Nastavnik>();
                foreach (var nas in nastavnici)
                {
                    if (nas.Predmet.Naziv == nazivPredmeta && nas.Predmet.Sifra == sifraPredmeta)
                    {
                        n.Add(new NastavnikPregled
                        {
                            Id = nas.Id,
                            ImePrezime = nas.ImeNastavnika,
                            Predmet = nas.Predmet.Naziv + " " + "(" + nas.Predmet.Sifra + ")"
                        });
                    }
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavlajnja nastavnika iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return n;
    }

    public static async Task<bool> IzmeniNastavnikaAsync(NastavnikBasic nastavnik)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Nastavnik nastavnikZaAzuriranje = await session.LoadAsync<Nastavnik>(nastavnik.Id);
                nastavnikZaAzuriranje.ImeNastavnika = PrvoSlovoVeliko(nastavnik.ImePrezime.Trim());
                if (nastavnikZaAzuriranje.Predmet.Id != nastavnik.Predmet.Id)
                {
                    nastavnikZaAzuriranje.Predmet = await session.LoadAsync<Predmet>(nastavnik.Predmet.Id);
                }

                await session.SaveOrUpdateAsync(nastavnikZaAzuriranje);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja nastavnika u bazi.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajNastavnikAsync(NastavnikBasic nastavnik)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Nastavnik noviNastavnik = new Nastavnik
                {
                    ImeNastavnika = PrvoSlovoVeliko(nastavnik.ImePrezime.Trim()),
                    Predmet = await session.LoadAsync<Predmet>(nastavnik.Predmet.Id)
                };

                await session.SaveAsync(noviNastavnik);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom dodavanja nastavnika u bazu.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiNastavnikAsync(int id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Nastavnik nastavnik = await session.LoadAsync<Nastavnik>(id);

                await session.DeleteAsync(nastavnik);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja nastavnika iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    #endregion

    #region Knjiga

    public static async Task<KnjigaBasic?> VratiKnjigaBasicAsync(int id)
    {
        KnjigaBasic? knjiga = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Knjiga k = await session.LoadAsync<Knjiga>(id);
                knjiga = new KnjigaBasic
                {
                    Id = k.Id,
                    Naslov = k.Naslov,
                    GodinaIzdanja = k.GodinaIzdanja,
                    ISBN = k.ISBN,
                    Izdavac = k.Izdavac
                };

                session.Close();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja knjige iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return knjiga;
    }

    public static List<KnjigaBasic>? VratiKnjigeBasic()
    {
        List<KnjigaBasic>? k = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Knjiga> knjige = session.Query<Knjiga>();
                k = new List<KnjigaBasic>();
                foreach (var kn in knjige)
                {
                    k.Add(new KnjigaBasic
                    {
                        Id = kn.Id,
                        Naslov = kn.Naslov,
                        GodinaIzdanja = kn.GodinaIzdanja,
                        ISBN = kn.ISBN,
                        Izdavac = kn.Izdavac
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja knjige iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return k;
    }

    public static async Task<bool> PostojiKnjigaAsync(string isbn)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Knjiga? knjiga = await session.Query<Knjiga>()
                    .FirstOrDefaultAsync(k => k.ISBN == isbn);

                session.Close();
                if (knjiga != null)
                    return true;

                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja knjige iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> IzmeniKnjiguAsync(KnjigaBasic knjiga)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Knjiga knjigaZaAzuriranje = await session.LoadAsync<Knjiga>(knjiga.Id);
                knjigaZaAzuriranje.Naslov = knjiga.Naslov;
                knjigaZaAzuriranje.GodinaIzdanja = knjiga.GodinaIzdanja;
                knjigaZaAzuriranje.ISBN = knjiga.ISBN;
                knjigaZaAzuriranje.Izdavac = knjiga.Izdavac;

                await session.SaveOrUpdateAsync(knjigaZaAzuriranje);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja knjige u bazi.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajKnjiguAsync(KnjigaBasic knjiga)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Knjiga novaKnjiga = new Knjiga
                {
                    Naslov = knjiga.Naslov,
                    GodinaIzdanja = knjiga.GodinaIzdanja,
                    ISBN = knjiga.ISBN,
                    Izdavac = knjiga.Izdavac
                };

                await session.SaveAsync(novaKnjiga);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom dodavanja knjige u bazu.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiKnjiguAsync(int id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Knjiga knjiga = await session.LoadAsync<Knjiga>(id);

                await session.DeleteAsync(knjiga);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja knjige iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    #endregion

    #region Clanak

    public static async Task<ClanakBasic?> VratiClanakBasicAsync(int id)
    {
        ClanakBasic? clanak = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Clanak c = await session.LoadAsync<Clanak>(id);
                clanak = new ClanakBasic
                {
                    Id = c.Id,
                    Naslov = c.Naslov,
                    GodinaIzdanja = c.GodinaIzdanja,
                    NazivCasopisa = c.NazivCasopisa,
                    BrojCasopisa = c.BrojCasopisa,
                    ISSN = c.ISSN
                };

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja clanka iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return clanak;
    }

    public static List<ClanakBasic>? VratiClankeBasic()
    {
        List<ClanakBasic>? c = null;
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                IEnumerable<Clanak> clanci = session.Query<Clanak>();
                c = new List<ClanakBasic>();
                foreach (var cl in clanci)
                {
                    c.Add(new ClanakBasic
                    {
                        Id = cl.Id,
                        Naslov = cl.Naslov,
                        GodinaIzdanja = cl.GodinaIzdanja,
                        NazivCasopisa = cl.NazivCasopisa,
                        BrojCasopisa = cl.BrojCasopisa,
                        ISSN = cl.ISSN
                    });
                }

                session.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja clanaka iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return c;
    }

    public static async Task<bool> PostojiClanakAsync(string issn)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Clanak? clanak = await session.Query<Clanak>().FirstOrDefaultAsync(c => c.ISSN == issn);
                session.Close();
                if (clanak != null)
                    return true;

                return false;
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show("Greška prilikom pribavljanja clanaka iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> IzmeniClanakAsync(ClanakBasic clanak)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Clanak c = await session.LoadAsync<Clanak>(clanak.Id);
                c.Naslov = clanak.Naslov;
                c.GodinaIzdanja = clanak.GodinaIzdanja;
                c.NazivCasopisa = clanak.NazivCasopisa;
                c.BrojCasopisa = clanak.BrojCasopisa;
                c.ISSN = clanak.ISSN;

                await session.SaveOrUpdateAsync(c);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom ažuriranja clanka iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> DodajClanakAsync(ClanakBasic clanak)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Clanak c = new Clanak
                {
                    Naslov = clanak.Naslov,
                    GodinaIzdanja = clanak.GodinaIzdanja,
                    NazivCasopisa = clanak.NazivCasopisa,
                    BrojCasopisa = clanak.BrojCasopisa,
                    ISSN = clanak.ISSN,
                };

                await session.SaveAsync(c);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom dodavanja clanka u bazu.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    public static async Task<bool> ObrisiClanakAsync(int id)
    {
        try
        {
            ISession? session = DataLayer.GetSession();
            if (session != null)
            {
                Clanak clanak = await session.LoadAsync<Clanak>(id);

                await session.DeleteAsync(clanak);
                await session.FlushAsync();

                session.Close();
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Greška prilikom brisanja clanka iz baze.\nDetalji:\n" + ex.FormatExceptionMessage(),
                "Greška",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return false;
    }

    #endregion
}
