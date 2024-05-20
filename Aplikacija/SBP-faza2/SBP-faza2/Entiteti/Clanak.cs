using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Clanak
{
    public virtual int Id { get; protected set; }
    public virtual required string Naslov { get; set; }
    public virtual required int GodinaIzdanja { get; set; }
    public virtual required string NazivCasopisa { get; set; }
    public virtual required int BrojCasopisa { get; set; }
    public virtual required string ISSN { get; set; }
}