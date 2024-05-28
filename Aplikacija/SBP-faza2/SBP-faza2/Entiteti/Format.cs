namespace SBP_faza2.Entiteti;

public class Format
{
    public virtual int Id { get; protected set; }
    public virtual required Rad Rad { get; set; }
    public virtual required string NazivFormata { get; set; }
}