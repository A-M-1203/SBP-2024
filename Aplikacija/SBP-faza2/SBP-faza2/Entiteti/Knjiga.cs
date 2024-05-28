namespace SBP_faza2.Entiteti;

public class Knjiga
{
    public virtual int Id { get; protected set; }
    public virtual required string Naslov { get; set; }
    public virtual required int GodinaIzdanja { get; set; }
    public virtual required string ISBN { get; set; }
    public virtual required string Izdavac { get; set; }
    public virtual IList<ProjekatLiteratura> LiteratureProjekti { get; set; }
    public virtual IList<Autor> Autori { get; set; }
    public Knjiga()
    {
        LiteratureProjekti = new List<ProjekatLiteratura>();
        Autori = new List<Autor>();
    }
}