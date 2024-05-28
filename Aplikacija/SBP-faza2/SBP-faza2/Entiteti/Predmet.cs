namespace SBP_faza2.Entiteti;

public class Predmet
{
    public virtual int Id { get; protected set; }
    public virtual required string Sifra { get; set; }
    public virtual required string Naziv { get; set; }
    public virtual required string Katedra { get; set; }
    public virtual required string Semestar { get; set; }
    public virtual IList<Projekat> Projekti { get; set; }
    public virtual IList<Nastavnik> Nastavnici { get; set; }
    public Predmet()
    {
        Projekti = new List<Projekat>();
        Nastavnici = new List<Nastavnik>();
    }
}