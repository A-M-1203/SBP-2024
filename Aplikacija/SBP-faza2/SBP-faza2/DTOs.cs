namespace SBP_faza2;

public class StudentList
{
    public required int Id { get; set; }
    public required string LicnoIme { get; set; }
    public required string ImeRoditelja { get; set; }
    public required string Prezime { get; set; }
    public required string BrojIndeksa { get; set; }
    public required string Smer { get; set; }

    public StudentList(int id, string licnoIme, string imeRoditelja, string prezime, string brojIndeksa, string smer) 
    {
        Id = id;
        LicnoIme = licnoIme;
        ImeRoditelja = imeRoditelja;
        Prezime = prezime;
        BrojIndeksa = brojIndeksa;
        Smer = smer;
    }

    public StudentList()
    {
        
    }
}

public class PredmetList
{
    public required int Id { get; set; }
    public required string Sifra { get; set; }
    public required string Naziv { get; set; }
    public required string Katedra { get; set; }
    public required string Semestar { get; set; }

    public PredmetList(int id, string sifra, string naziv, string katedra, string semestar)
    {
        Id = id;
        Sifra = sifra;
        Naziv = naziv;
        Katedra = katedra;
        Semestar = semestar;
    }

    public PredmetList()
    {
        
    }
}