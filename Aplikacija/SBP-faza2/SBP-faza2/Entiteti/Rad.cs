using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Rad
{
    public virtual int Id { get; protected set; }
    public virtual required string Naslov { get; set; }
    public virtual required int GodinaIzdanja { get; set; }
    public virtual string? NazivKonferencije { get; set; }
    public virtual string? URL { get; set; }
    public virtual IList<Projekat> Projekti { get; set; }
    public virtual IList<Format> Formati { get; set; }

    public Rad()
    {
        Projekti = new List<Projekat>();
        Formati = new List<Format>();
    }
    public virtual Autor Autor { get; set; }


}