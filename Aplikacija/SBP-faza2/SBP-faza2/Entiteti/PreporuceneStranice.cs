using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class PreporuceneStranice
{
    public virtual int Id { get; protected set; }
    public virtual required int IdProjekta { get; set; }
    public virtual required string Stranice { get; set; }
}