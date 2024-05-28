namespace SBP_faza2.Entiteti;

public class Autor
{
    public virtual int Id { get; protected set; }
    public virtual required string ImeAutora { get; set; }
    public virtual Knjiga? Knjiga { get; set; }
    public virtual Rad? Rad { get; set; }
    public virtual Clanak? Clanak { get; set; }
}