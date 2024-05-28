using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class KnjigaMapiranja : ClassMap<Knjiga>
{
    public KnjigaMapiranja() 
    {
        Table("KNJIGA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naslov, "NASLOV");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");
        Map(x => x.ISBN, "ISBN");
        Map(x => x.Izdavac, "IZDAVAC");

        HasMany(x => x.LiteratureProjekti).KeyColumn("ID_KNJIGE").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Autori).KeyColumn("ID_KNJIGE").LazyLoad().Cascade.All().Inverse();
    }
}