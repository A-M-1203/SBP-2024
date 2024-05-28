namespace SBP_faza2.Entiteti;

public class Grupa
{
    public virtual int Id { get; protected set; }
    public virtual required Projekat Projekat { get; set; }
    public virtual required string NazivGrupe { get; set; }
    public virtual IList<Izvestaj> Izvestaji { get; set; }
    public virtual IList<StudentGrupa> GrupeStudenti { get; set; }

    public Grupa()
    {
        Izvestaji = new List<Izvestaj>();
        GrupeStudenti = new List<StudentGrupa>();
    }
}