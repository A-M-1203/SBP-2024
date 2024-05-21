using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Grupa
{
    public virtual int Id { get; protected set; }
    public virtual Projekat IdProjekta { get; set; }
    public virtual required string NazivGrupe { get; set; }
    public virtual required DateTime DatumPocetka { get; set; }
    public virtual DateTime? DatumZavrsetka { get; set; }
    public virtual required DateTime RokZaZavrsetak { get; set; }
    public virtual IList<Izvestaj> Izvestaji { get; set; }
    public virtual IList<Student> Studenti { get; set; }

    public Grupa()
    {
        Izvestaji = new List<Izvestaj>();
        Studenti = new List<Student>();
    }

}