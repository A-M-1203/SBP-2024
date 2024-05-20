using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Predmet
{
    public virtual int Id { get; protected set; }
    public virtual required string Sifra { get; set; }
    public virtual required string Naziv { get; set; }
    public virtual required string Katedra { get; set; }
    public virtual required string Semestar { get; set; }
}