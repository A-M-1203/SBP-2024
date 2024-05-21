using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Knjiga
{
    public virtual int Id { get; protected set; }
    public virtual required string Naslov { get; set; }
    public virtual required int GodinaIzdanja { get; set; }
    public virtual required string ISBN { get; set; }
    public virtual required string Izdavac { get; set; }
    public virtual IList<Projekat> Projekti { get; set; }
    public Knjiga()
    {
        Projekti = new List<Projekat>();
    }
    public virtual Autor Autor { get; set; }


}