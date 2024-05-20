using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class IzvestajMapiranja : ClassMap<Izvestaj>
{
    public IzvestajMapiranja()
    {
        Table("IZVESTAJ");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdProjekta);
        References(x => x.IdStudenta);
        References(x => x.IdGrupe);
        Map(x => x.VremeZavrsetka, "VREME_ZAVRSETKA");
        Map(x => x.Opis, "OPIS");




    }
}
