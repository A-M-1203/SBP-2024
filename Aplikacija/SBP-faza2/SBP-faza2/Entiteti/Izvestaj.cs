using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Izvestaj
{
    public virtual int Id { get; protected set; }
    public virtual Projekat IdProjekta { get; set; }
    public virtual Student IdStudenta { get; set; }
    public virtual Grupa IdGrupe { get; set; }
    public virtual required DateTime VremeZavrsetka { get; set; }
    public virtual string? Opis { get; set; }
}