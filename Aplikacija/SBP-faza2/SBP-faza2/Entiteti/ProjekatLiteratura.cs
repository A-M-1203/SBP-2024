using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class ProjekatLiteratura
{
    public virtual int Id { get; protected set; }
    public virtual required int IdProjekta { get; set; }
    public virtual int? IdKnjige { get; set; }
    public virtual int? IdClanka { get; set; }
    public virtual int? IdRada { get; set; }
}