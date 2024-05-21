using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class NastavnikMapiranja : ClassMap<Nastavnik>
{
    public NastavnikMapiranja()
    {
        Table("NASTAVNIK");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        Map(x => x.ImeNastavnika, "NASTAVNIK");
        HasMany(x => x.IdPredmeta).Inverse().Cascade.All();


    }
}
