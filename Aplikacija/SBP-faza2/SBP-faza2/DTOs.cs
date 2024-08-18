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
    public required int Id { get; set; }
    public required string Naziv { get; set; }
    public required string SkolskaGodina { get; set; }
    public required string Grupni { get; set; }
    public required string RokZaZavrsetak { get; set; }
    public string MaksimalanBrojStrana { get; set; } = "0";
    public string PreporuceniProgramskiJezik { get; set; } = string.Empty;
    public string KratakOpis { get; set; } = string.Empty;
    public required string BrojIzvestaja { get; set; } = "0";
    public required string NazivPredmeta { get; set; }
    public required string TipProjekta { get; set; }
    public required string DatumPocetka { get; set; }
    public string DatumZavrsetka { get; set; } = string.Empty;

    public ProjekatBasic(
        int id, string nazivProjekta, string skolskaGodina, string grupni, string rokZaZavrsetak,
        string maksimalanBrojStrana, string preporuceniProgramskiJezik, string kratakOpis, string brojIzvestaja,
        string nazivPredmeta, string tipProjekta, string datumPocetka, string datumZavrsetka)
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
        NazivPredmeta = nazivPredmeta;
        TipProjekta = tipProjekta;
        DatumPocetka = datumPocetka;
        DatumZavrsetka = datumZavrsetka;
    }

    public ProjekatBasic()
    {
        
    }
}

#endregion
