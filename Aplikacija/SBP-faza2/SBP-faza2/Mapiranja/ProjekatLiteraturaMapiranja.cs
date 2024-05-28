using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class ProjekatLiteraturaMapiranja : ClassMap<ProjekatLiteratura>
{
    public ProjekatLiteraturaMapiranja()
    {
        Table("PROJEKAT_LITERATURA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        References(x => x.Projekat).Column("ID_PROJEKTA").LazyLoad();
        References(x => x.Knjiga).Column("ID_KNJIGE").LazyLoad();
        References(x => x.Clanak).Column("ID_CLANKA").LazyLoad();
        References(x => x.Rad).Column("ID_RADA").LazyLoad();
    }
}