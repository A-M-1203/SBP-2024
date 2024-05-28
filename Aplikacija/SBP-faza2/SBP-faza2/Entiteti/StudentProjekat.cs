namespace SBP_faza2.Entiteti;

public class StudentProjekat
{
    public virtual int Id { get; protected set; }
    public virtual required Student Student { get; set; }
    public virtual required Projekat Projekat { get; set; }
    public virtual string? ProgramskiJezik { get; set; }
    public virtual IList<PreporucenaLiteratura> PreporuceneLiterature { get; set; }

    public StudentProjekat()
    {
        PreporuceneLiterature = new List<PreporucenaLiteratura>();
    }
}