using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class KnjigaMapiranja : ClassMap<Knjiga>
{
        public KnjigaMapiranja() 
        {
            Table("KNJIGA");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naslov, "NASLOV");
            Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
            Map(x => x.ISBN, "ISBN");
            Map(x => x.Izdavac, "IZDAVAC");
            HasManyToMany(x => x.Projekti);
            References(x => x.Autor);


    }
}

   
