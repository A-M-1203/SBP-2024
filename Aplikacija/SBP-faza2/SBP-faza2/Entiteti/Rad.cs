namespace SBP_faza2.Entiteti;

public class Rad
{
    public virtual int Id { get; protected set; }
    public virtual required string Naslov { get; set; }
    public virtual required int GodinaIzdanja { get; set; }
    public virtual string? NazivKonferencije { get; set; }
    public virtual string? URL { get; set; }
    public virtual IList<ProjekatLiteratura> LiteratureProjekti { get; set; }
    public virtual IList<Format> Formati { get; set; }
    public virtual IList<Autor> Autori { get; set; }
    public Rad()
    {
        LiteratureProjekti = new List<ProjekatLiteratura>();
        Formati = new List<Format>();
        Autori = new List<Autor>();
    }
}