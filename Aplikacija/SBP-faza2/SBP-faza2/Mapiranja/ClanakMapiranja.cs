using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;
public class ClanakMapiranja : ClassMap<Clanak>
{
    public ClanakMapiranja()
    {
        Table("CLANAK");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naslov, "NASLOV");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
        Map(x => x.NazivCasopisa, "NAZIV_CASOPISA");
        Map(x => x.BrojCasopisa, "BROJ_CASOPISA");
        Map(x => x.ISSN, "ISSN");

        HasMany(x => x.LiteratureProjekti).KeyColumn("ID_CLANKA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Autori).KeyColumn("ID_CLANKA").LazyLoad().Cascade.All().Inverse();
    }
}