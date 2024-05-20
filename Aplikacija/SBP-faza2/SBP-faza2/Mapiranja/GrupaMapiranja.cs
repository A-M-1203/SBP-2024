using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class GrupaMapiranja : ClassMap<Grupa>
{
    public GrupaMapiranja()
    {
        Table("GRUPA");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdProjekta);

        Map(x => x.NazivGrupe, "NAZIV_GRUPE");
        Map(x => x.DatumPocetka, "DATUM_POCETKA");
        Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
        Map(x => x.RokZaZavrsetak, "ROK_ZA_ZAVRSETAK");
        /*HasManyToMany(x => x.Studenti)
        .ParentKeyColumn("")
        .ChildKeyColumn("");*/

    }
}
