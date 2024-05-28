using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
namespace SBP_faza2.Mapiranja;

public class StudentProjekatMapiranja : ClassMap<StudentProjekat>
{
    public StudentProjekatMapiranja()
    {
        Table("STUDENT_PROJEKAT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.ProgramskiJezik, "PROGRAMSKI_JEZIK");

        References(x => x.Student).Column("ID_STUDENTA").LazyLoad();
        References(x => x.Projekat).Column("ID_PROJEKTA").LazyLoad();
        HasMany(x => x.PreporuceneLiterature).KeyColumn("ID_STUDENT_PROJEKAT").LazyLoad().Cascade.All().Inverse();
    }
}