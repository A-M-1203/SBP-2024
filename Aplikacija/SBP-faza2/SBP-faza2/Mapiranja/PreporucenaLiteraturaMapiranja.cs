using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class PreporucenaLiteraturaMapiranja : ClassMap<PreporucenaLiteratura>
{
    public PreporucenaLiteraturaMapiranja()
    {
        Table("PREPORUCENA_LITERATURA");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdStudentProjekat);
        Map(x => x.Literatura, "PREPORUCENA_LITERATURA");







    }
}
