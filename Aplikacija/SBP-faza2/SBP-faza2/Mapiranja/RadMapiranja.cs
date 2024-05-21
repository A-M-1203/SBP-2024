using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class RadMapiranja : ClassMap<Rad>
{
    public RadMapiranja()
    {
        Table("RAD");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        Map(x => x.Naslov, "NASLOV");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
        Map(x => x.NazivKonferencije, "NAZIV_KONFERENCIJE");
        Map(x => x.URL, "URL");
        HasManyToMany(x => x.Projekti);
        References(x => x.Autor);
        HasMany(x => x.Formati).Inverse().Cascade.All();


    }
}
