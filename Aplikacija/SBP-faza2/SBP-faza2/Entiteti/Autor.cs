using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Autor
{
    public virtual int Id { get; protected set; }
    //public virtual int? IdKnjige { get; set; }
    //public virtual int? IdClanka { get; set; }
    //public virtual int? IdRada { get; set; }
    public virtual required string ImeAutora { get; set; }
    public virtual IList<Knjiga> IdKnjige { get; set; }
    public virtual IList<Rad> IdRada { get; set; }
    public virtual IList<Clanak> IdClanka { get; set; }


    public Autor()
    {
        IdKnjige = new List<Knjiga>();
        IdRada = new List<Rad>();
        IdClanka = new List<Clanak>();
    }

}