using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public virtual IList<Grupa> Grupe { get; set; }
    public virtual IList<Projekat> Projekti { get; set; }


    public Student()
    {
        Izvestaji = new List<Izvestaj>();
        Grupe = new List<Grupa>();
        Projekti = new List<Projekat>();
    }
}