using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Format
{
    public virtual int Id { get; protected set; }
    public virtual required IList<Rad> IdRada { get; set; }
    public virtual required string NazivFormata { get; set; }
}