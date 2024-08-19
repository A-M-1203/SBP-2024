﻿namespace SBP_faza2;


#region Student
public class StudentBasic
{
    public required long Id { get; set; }
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
    public required long Id { get; set; }
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

public class PredmetNazivSifra
{
    public required int Id { get; set; }
    public required string Naziv { get; set; }
    public required string Sifra { get; set; }

    public PredmetNazivSifra(int id, string naziv, string sifra)
    {
        Id = id;
        Naziv = naziv;
        Sifra = sifra;
    }

    public PredmetNazivSifra()
    {
        
    }
}

public class PredmetNazivSifraSemestar
{
    public required int Id { get; set; }
    public required string Naziv { get; set; }
    public required string Sifra { get; set; }
    public required string Semestar { get; set; }

    public PredmetNazivSifraSemestar(int id, string naziv, string sifra, string semestar)
    {
        Id = id;
        Naziv = naziv;
        Sifra = sifra;
        Semestar = semestar;
    }

    public PredmetNazivSifraSemestar()
    {

    }
}

#endregion

#region Projekat
public class ProjekatBasic
{
    public required long Id { get; set; }
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
    public long Id { get; set; }
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
