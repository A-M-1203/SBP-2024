namespace SBP_faza2.Entiteti;

public class Izvestaj
{
    public virtual int Id { get; protected set; }
    public virtual required Projekat Projekat { get; set; }
    public virtual Student? Student { get; set; }
    public virtual Grupa? Grupa { get; set; }
    public virtual required DateTime VremeZavrsetka { get; set; }
    public virtual string? Opis { get; set; }
}