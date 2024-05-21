using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Nastavnik
{
    public virtual int Id { get; protected set; }
    public virtual IList<Predmet>  IdPredmeta { get; set; }
    public virtual required string ImeNastavnika { get; set; }
    public Nastavnik()
    {
        IdPredmeta = new List<Predmet>();
    }
}