using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;
public class NastavnikMapiranja : ClassMap<Nastavnik>
{
    public NastavnikMapiranja()
    {
        Table("NASTAVNIK");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.ImeNastavnika, "NASTAVNIK");

        References(x => x.Predmet).Column("ID_PREDMETA").LazyLoad();
    }
}