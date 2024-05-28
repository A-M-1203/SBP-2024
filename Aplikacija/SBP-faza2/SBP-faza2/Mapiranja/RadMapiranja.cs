using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class RadMapiranja : ClassMap<Rad>
{
    public RadMapiranja()
    {
        Table("RAD");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naslov, "NASLOV");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
        Map(x => x.NazivKonferencije, "NAZIV_KONFERENCIJE");
        Map(x => x.URL, "URL");

        HasMany(x => x.LiteratureProjekti).KeyColumn("ID_RADA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Formati).KeyColumn("ID_RADA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Autori).KeyColumn("ID_RADA").LazyLoad().Cascade.All().Inverse();
    }
}