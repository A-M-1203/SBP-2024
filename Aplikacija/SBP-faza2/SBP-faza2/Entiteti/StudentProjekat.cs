using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class StudentProjekat
{
    public virtual int Id { get; protected set; }
    public virtual required Student IdStudenta { get; set; }
    public virtual required Projekat IdProjekta { get; set; }
    //public virtual int? IdPreporuceneLiterature { get; set; }
    public virtual string? ProgramskiJezik { get; set; }
    public virtual required DateTime DatumPocetka { get; set; }
    public virtual DateTime? DatumZavrsetka { get; set; }
    public virtual IList<PreporucenaLiteratura> IdPreporuceneLiterature { get; set; }
    public StudentProjekat()
    {
        IdPreporuceneLiterature = new List<PreporucenaLiteratura>();
    }
}