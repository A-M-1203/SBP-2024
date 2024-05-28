namespace SBP_faza2.Entiteti;

public class ProjekatLiteratura
{
    public virtual int Id { get; protected set; }
    public virtual required Projekat Projekat { get; set; }
    public virtual Knjiga? Knjiga { get; set; }
    public virtual Clanak? Clanak { get; set; }
    public virtual Rad? Rad { get; set; }
}