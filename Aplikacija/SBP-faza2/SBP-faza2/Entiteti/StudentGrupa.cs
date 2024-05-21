using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class StudentGrupa
{
    public virtual int Id { get; protected set; }
    public virtual required Student IdStudenta { get; set; }
    public virtual required Grupa IdGrupe { get; set; }
}