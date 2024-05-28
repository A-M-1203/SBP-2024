namespace SBP_faza2.Entiteti;

public class PreporuceneStranice
{
    public virtual int Id { get; protected set; }
    public virtual required Projekat Projekat { get; set; }
    public virtual required string Stranice { get; set; }
}