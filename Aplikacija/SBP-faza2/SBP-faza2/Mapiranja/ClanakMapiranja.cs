using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class ClanakMapiranja : ClassMap<Clanak>
{
    public ClanakMapiranja()
    {
        Table("CLANAK");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        Map(x => x.Naslov, "NASLOV");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
        Map(x => x.NazivCasopisa, "NAZIV_CASOPISA");
        Map(x => x.BrojCasopisa, "BROJ_CASOPISA");
        Map(x => x.ISSN, "ISSN");
    }
}
