namespace SBP_faza2;


#region Student
public class StudentBasic
{
    public required long Id { get; init; }
    public required string LicnoIme { get; set; }
    public required string ImeRoditelja { get; set; }
    public required string Prezime { get; set; }
    public required string BrojIndeksa { get; set; }
    public required string Smer { get; set; }

    public StudentBasic(long id, string licnoIme, string imeRoditelja, string prezime, string brojIndeksa, string smer) 
    {
        Id = id;
        LicnoIme = licnoIme;
        ImeRoditelja = imeRoditelja;
        Prezime = prezime;
        BrojIndeksa = brojIndeksa;
        Smer = smer;
    }

    public StudentBasic()
    {
        
    }
}

#endregion

#region Predmet
public class PredmetBasic
{
    public required long Id { get; init; }
    public required string Sifra { get; set; }
    public required string Naziv { get; set; }
    public required string Katedra { get; set; }
    public required string Semestar { get; set; }

    public PredmetBasic(long id, string sifra, string naziv, string katedra, string semestar)
    {
        Id = id;
        Sifra = sifra;
        Naziv = naziv;
        Katedra = katedra;
        Semestar = semestar;
    }

    public PredmetBasic()
    {
        
    }
}

#endregion

#region Projekat
public class ProjekatBasic
{
    public required long Id { get; init; }
    public required string Naziv { get; set; }
    public required string SkolskaGodina { get; set; }
    public required string Grupni { get; set; }
    public required DateTime RokZaZavrsetak { get; set; }
    public int? MaksimalanBrojStrana { get; set; }
    public string? PreporuceniProgramskiJezik { get; set; }
    public string? KratakOpis { get; set; }
    public int? BrojIzvestaja { get; set; }
    public required PredmetBasic Predmet { get; set; }
    public required string Tip { get; set; }
    public required DateTime DatumPocetka { get; set; }
    public DateTime? DatumZavrsetka { get; set; }

    public ProjekatBasic(
        long id, string nazivProjekta, string skolskaGodina, string grupni, DateTime rokZaZavrsetak,
        int? maksimalanBrojStrana, string? preporuceniProgramskiJezik, string? kratakOpis, int? brojIzvestaja,
        string tipProjekta, DateTime datumPocetka, DateTime? datumZavrsetka)
    {
        Id = id;
        Naziv = nazivProjekta;
        SkolskaGodina = skolskaGodina;
        Grupni = grupni;
        RokZaZavrsetak = rokZaZavrsetak;
        MaksimalanBrojStrana = maksimalanBrojStrana;
        PreporuceniProgramskiJezik = preporuceniProgramskiJezik;
        KratakOpis = kratakOpis;
        BrojIzvestaja = brojIzvestaja;
        Tip = tipProjekta;
        DatumPocetka = datumPocetka;
        DatumZavrsetka = datumZavrsetka;
    }

    public ProjekatBasic()
    {
        
    }
}

public class TeorijskiProjekatBasic : ProjekatBasic
{
    public TeorijskiProjekatBasic(
        long id, string nazivProjekta, string skolskaGodina, string grupni, DateTime rokZaZavrsetak,
        int maksimalanBrojStrana, string tipProjekta, DateTime datumPocetka, DateTime? datumZavrsetka) 
        : base(id, nazivProjekta, skolskaGodina, grupni, rokZaZavrsetak, maksimalanBrojStrana, 
                null, null, null, tipProjekta, datumPocetka, datumZavrsetka)
    {
        
    }

    public TeorijskiProjekatBasic()
    {
        
    }
}

public class PrakticniProjekatBasic : ProjekatBasic
{
    public PrakticniProjekatBasic(
        long id, string nazivProjekta, string skolskaGodina, string grupni, DateTime rokZaZavrsetak,
        string preporuceniProgramskiJezik, string kratakOpis, int brojIzvestaja,
        string tipProjekta, DateTime datumPocetka, DateTime? datumZavrsetka)
        : base(id, nazivProjekta, skolskaGodina, grupni, rokZaZavrsetak, null, preporuceniProgramskiJezik, 
            kratakOpis, brojIzvestaja, tipProjekta, datumPocetka, datumZavrsetka)
    {
        
    }

    public PrakticniProjekatBasic()
    {
        
    }
}

public class ProjekatPregled
{
    public long Id { get; init; }
    public required string Naziv { get; set; }
    public required string SkolskaGodina { get; set; }
    public required string Grupni { get; set; }
    public required DateTime RokZaZavrsetak { get; set; }
    public int? MaksimalanBrojStrana { get; set; }
    public string? PreporuceniProgramskiJezik { get; set; }
    public string? KratakOpis { get; set; }
    public int? BrojIzvestaja { get; set; }
    public required string Tip { get; set; }
    public required string Predmet { get; set; }
    public required DateTime DatumPocetka { get; set; }
    public DateTime? DatumZavrsetka { get; set; }

    public ProjekatPregled(long id, string naziv, string skolskaGodina, string grupni, DateTime rokZaZavrsetak,
        int? maksimalanBrojStrana, string? preporuceniProgramskiJezik, string? kratakOpis, int? brojIzvestaja,
        string tip, string predmet, DateTime datumPocetka, DateTime? datumZavrsetka)
    {
        Id = id;
        Naziv = naziv;
        SkolskaGodina = skolskaGodina;
        Grupni = grupni;
        RokZaZavrsetak = rokZaZavrsetak;
        MaksimalanBrojStrana = maksimalanBrojStrana;
        PreporuceniProgramskiJezik = preporuceniProgramskiJezik;
        KratakOpis = kratakOpis;
        BrojIzvestaja = brojIzvestaja;
        Tip = tip;
        Predmet = predmet;
        DatumPocetka = datumPocetka;
        DatumZavrsetka = datumZavrsetka;
    }

    public ProjekatPregled()
    {
        
    }
}

public class TeorijskiProjekatPregled : ProjekatPregled
{
    public TeorijskiProjekatPregled(int id, string naziv, string skolskaGodina, string grupni, DateTime rokZaZavrsetak, 
        int maksimalanBrojStrana, string tip, string predmet, DateTime datumPocetka, DateTime? datumZavrsetka) 
        : base(id, naziv, skolskaGodina, grupni, rokZaZavrsetak, maksimalanBrojStrana, null, null, null, tip, predmet, datumPocetka, datumZavrsetka)
    {
    }
}

public class PrakticniProjekatPregled : ProjekatPregled
{
    public PrakticniProjekatPregled(int id, string naziv, string skolskaGodina, string grupni, DateTime rokZaZavrsetak,
        string preporuceniProgramskiJezik, string kratakOpis, int brojIzvestaja, 
        string tip, string predmet, DateTime datumPocetka, DateTime? datumZavrsetka) 
        : base(id, naziv, skolskaGodina, grupni, rokZaZavrsetak, null, preporuceniProgramskiJezik, kratakOpis, brojIzvestaja, tip, predmet, datumPocetka, datumZavrsetka)
    {
    }
}

#endregion

#region Grupa

public class GrupaBasic
{
    public long Id { get; init; }
    public required string Naziv { get; set; }
    public required ProjekatBasic Projekat { get; set; }

    public GrupaBasic(long id, string naziv, ProjekatBasic projekat)
    {
        Id = id;
        Naziv = naziv;
        Projekat = projekat;
    }

    public GrupaBasic()
    {

    }
}

public class GrupaPregled
{
    public long Id { get; init; }
    public required string Naziv { get; set; }
    public required string Projekat { get; set; }

    public GrupaPregled(long id, string naziv, string projekat)
    {
        Id = id;
        Naziv = naziv;
        Projekat = projekat;
    }

    public GrupaPregled()
    {
        
    }
}

#endregion

#region Nastavnik

public class NastavnikBasic
{
    public int Id { get; init; }
    public required string ImePrezime { get; set; }
    public required PredmetBasic Predmet { get; set; }

    public NastavnikBasic(int id, string imePrezime, PredmetBasic predmet)
    {
        Id = id;
        ImePrezime = imePrezime;
        Predmet = predmet;
    }

    public NastavnikBasic()
    {
        
    }
}

public class NastavnikPregled
{
    public int Id { get; init; }
    public required string ImePrezime { get; set; }
    public required string Predmet { get; set; }

    public NastavnikPregled(int id, string imePrezime, string predmet)
    {
        Id = id;
        ImePrezime = imePrezime;
        Predmet = predmet;
    }

    public NastavnikPregled()
    {
        
    }
}

#endregion

#region Knjiga

public class KnjigaBasic
{
    public int Id { get; init; }
    public required string Naslov { get; set; }
    public required int GodinaIzdanja { get; set; }
    public required string ISBN { get; set; }
    public required string Izdavac { get; set; }

    public KnjigaBasic(int id, string naslov, int godinaIzdanja, string iSBN, string izdavac)
    {
        Id = id;
        Naslov = naslov;
        GodinaIzdanja = godinaIzdanja;
        ISBN = iSBN;
        Izdavac = izdavac;
    }

    public KnjigaBasic()
    {
        
    }
}

#endregion
