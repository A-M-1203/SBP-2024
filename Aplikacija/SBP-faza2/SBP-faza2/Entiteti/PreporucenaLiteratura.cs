namespace SBP_faza2.Entiteti;

public class PreporucenaLiteratura
{
    public virtual int Id { get; protected set; }
    public virtual required StudentProjekat StudentProjekat { get; set; }
    public virtual required string Literatura { get; set; }
}