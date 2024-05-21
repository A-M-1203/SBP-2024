using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class ProjekatLiteraturaMapiranja : ClassMap<ProjekatLiteratura>
{
    public ProjekatLiteraturaMapiranja()
    {
        Table("PROJEKAT_LITERATURA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdProjekta);
        References(x => x.IdKnjige);
        References(x => x.IdClanka);
        References(x => x.IdRada);

    }
}
