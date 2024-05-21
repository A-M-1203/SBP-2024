using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;
public class PreporuceneStraniceMapiranja : ClassMap<PreporuceneStranice>
{
    public PreporuceneStraniceMapiranja()
    {
        Table("PREPORUCENE_STRANICE");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdProjekta);
        Map(x => x.Stranice, "PREPORUCENE_STRANICE");


    }
}
