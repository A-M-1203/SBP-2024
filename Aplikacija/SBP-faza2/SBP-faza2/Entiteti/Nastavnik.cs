namespace SBP_faza2.Entiteti;

public class Nastavnik
{
    public virtual int Id { get; protected set; }
    public virtual required Predmet Predmet { get; set; }
    public virtual required string ImeNastavnika { get; set; }
}