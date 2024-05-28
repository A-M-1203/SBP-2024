using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;
public class AutorMapiranja : ClassMap<Autor>
{
    public AutorMapiranja()
    {
        Table("AUTOR");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.ImeAutora, "AUTOR");

        References(x => x.Knjiga).Column("ID_KNJIGE").LazyLoad();
        References(x => x.Clanak).Column("ID_CLANKA").LazyLoad();
        References(x => x.Rad).Column("ID_RADA").LazyLoad();
    }
}