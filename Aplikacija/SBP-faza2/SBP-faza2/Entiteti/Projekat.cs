namespace SBP_faza2.Entiteti;

public abstract class Projekat
{
    public virtual int Id { get; protected set; }
    public virtual required string Naziv { get; set; }
    public virtual required string SkolskaGodina { get; set; }
    public virtual required string Grupni { get; set; }
    public virtual required DateTime RokZaZavrsetak { get; set; }
    public virtual required Predmet Predmet { get; set; }
    public virtual required string Tip { get; set; }
    public virtual required DateTime DatumPocetka { get; set; }
    public virtual DateTime? DatumZavrsetka { get; set; }
    public virtual IList<Grupa> Grupe { get; set; }
    public virtual IList<StudentProjekat> StudentiProjekti { get; set; }
    

    public Projekat()
    {
        Grupe = new List<Grupa>();
        StudentiProjekti = new List<StudentProjekat>();
    }
}

public class PrakticniProjekat : Projekat 
{
    public virtual string? PreporuceniProgramskiJezik { get; set; }
    public virtual string? KratakOpis { get; set; }
    public virtual required int BrojIzvestaja { get; set; }
    public virtual IList<Izvestaj> Izvestaji { get; set; } = new List<Izvestaj>();
    public virtual IList<PreporuceneStranice> Stranice { get; set; } = new List<PreporuceneStranice>();
}
public class TeorijskiProjekat : Projekat 
{
    public virtual int MaksimalanBrojStrana { get; set; }
    public virtual IList<ProjekatLiteratura> ProjektiLiterature { get; set; } = new List<ProjekatLiteratura>();
}
