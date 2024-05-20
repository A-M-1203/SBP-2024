using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class PreporucenaLiteratura
{
    public virtual int Id { get; protected set; }
    public virtual required int IdStudentProjekat { get; set; }
    public virtual required string Literatura { get; set; }
}