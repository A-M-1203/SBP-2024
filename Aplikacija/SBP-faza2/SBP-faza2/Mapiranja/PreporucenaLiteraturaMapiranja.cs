using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class PreporucenaLiteraturaMapiranja : ClassMap<PreporucenaLiteratura>
{
    public PreporucenaLiteraturaMapiranja()
    {
        Table("PREPORUCENA_LITERATURA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Literatura, "PREPORUCENA_LITERATURA");

        References(x => x.StudentProjekat).Column("ID_STUDENT_PROJEKAT").LazyLoad();
    }
}