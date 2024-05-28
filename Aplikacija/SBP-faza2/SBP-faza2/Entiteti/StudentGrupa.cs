namespace SBP_faza2.Entiteti;

public class StudentGrupa
{
    public virtual int Id { get; protected set; }
    public virtual required Student Student { get; set; }
    public virtual required Grupa Grupa { get; set; }
}