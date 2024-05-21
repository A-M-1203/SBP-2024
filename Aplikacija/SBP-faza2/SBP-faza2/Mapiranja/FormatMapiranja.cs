using FluentNHibernate.Mapping;
using NHibernate.Cfg.MappingSchema;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class FormatMapiranja : ClassMap<Format>
{
    public FormatMapiranja()
    {
        Table("FORMAT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.NazivFormata, "FORMAT");
        References(x => x.IdRada);



    }
}
