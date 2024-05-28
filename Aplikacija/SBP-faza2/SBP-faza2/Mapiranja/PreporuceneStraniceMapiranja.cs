using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;
public class PreporuceneStraniceMapiranja : ClassMap<PreporuceneStranice>
{
    public PreporuceneStraniceMapiranja()
    {
        Table("PREPORUCENE_STRANICE");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        
        Map(x => x.Stranice, "PREPORUCENE_STRANICE");

        References(x => x.Projekat).Column("ID_PROJEKTA").LazyLoad();
    }
}