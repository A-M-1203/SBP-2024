using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class AutorMapiranja : ClassMap<Autor>
{
    public AutorMapiranja()
    {
        Table("AUTOR");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        Map(x => x.ImeAutora, "AUTOR");
        HasMany(x => x.IdKnjige).Inverse().Cascade.All();
        HasMany(x => x.IdClanka).Inverse().Cascade.All();
        HasMany(x => x.IdRada).Inverse().Cascade.All();


    }
}
