namespace SBP_faza2.Entiteti;

public class Student
{
    public virtual int Id { get; protected set; }
    public virtual required string BrojIndeksa { get; set; }
    public virtual required string LicnoIme { get; set; }
    public virtual required string ImeRoditelja { get; set; }
    public virtual required string Prezime { get; set; }
    public virtual required string Smer { get; set; }
    public virtual IList<Izvestaj> Izvestaji { get; set; }
    public virtual IList<StudentGrupa> StudentiGrupe { get; set; }
    public virtual IList<StudentProjekat> StudentiProjekti { get; set; }


    public Student()
    {
        Izvestaji = new List<Izvestaj>();
        StudentiGrupe = new List<StudentGrupa>();
        StudentiProjekti = new List<StudentProjekat>();
    }
}