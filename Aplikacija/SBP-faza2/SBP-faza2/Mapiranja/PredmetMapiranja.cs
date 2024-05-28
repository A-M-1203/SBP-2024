using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class PredmetMapiranja : ClassMap<Predmet>
{
    public PredmetMapiranja()
    {
        Table("PREDMET");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Sifra, "SIFRA_PREDMETA");
        Map(x => x.Naziv, "NAZIV_PREDMETA");
        Map(x => x.Katedra, "KATEDRA");
        Map(x => x.Semestar, "SEMESTAR");

        HasMany(x => x.Projekti).KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Nastavnici).KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();
    }
}