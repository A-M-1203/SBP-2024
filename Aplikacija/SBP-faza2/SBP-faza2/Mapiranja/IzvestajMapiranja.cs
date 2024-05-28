using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;
public class IzvestajMapiranja : ClassMap<Izvestaj>
{
    public IzvestajMapiranja()
    {
        Table("IZVESTAJ");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        
        Map(x => x.VremeZavrsetka, "VREME_ZAVRSETKA");
        Map(x => x.Opis, "OPIS");

        References(x => x.Projekat).Column("ID_PROJEKTA").LazyLoad();
        References(x => x.Student).Column("ID_STUDENTA").LazyLoad();
        References(x => x.Grupa).Column("ID_GRUPE").LazyLoad();
    }
}