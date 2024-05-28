using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
namespace SBP_faza2.Mapiranja;

public class GrupaMapiranja : ClassMap<Grupa>
{
    public GrupaMapiranja()
    {
        Table("GRUPA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.NazivGrupe, "NAZIV_GRUPE");

        References(x => x.Projekat).Column("ID_PROJEKTA").LazyLoad();
        HasMany(x => x.Izvestaji).KeyColumn("ID_GRUPE").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.GrupeStudenti).KeyColumn("ID_GRUPE").LazyLoad().Cascade.All().Inverse();
    }
}