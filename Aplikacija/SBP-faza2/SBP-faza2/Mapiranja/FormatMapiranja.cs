using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class FormatMapiranja : ClassMap<Format>
{
    public FormatMapiranja()
    {
        Table("FORMAT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.NazivFormata, "FORMAT");

        References(x => x.Rad).Column("ID_RADA").LazyLoad();
    }
}