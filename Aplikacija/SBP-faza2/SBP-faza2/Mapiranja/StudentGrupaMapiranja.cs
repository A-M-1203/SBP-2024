using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;

namespace SBP_faza2.Mapiranja;

public class StudentGrupaMapiranja : ClassMap<StudentGrupa>
{
    public StudentGrupaMapiranja()
    {
        Table("STUDENT_GRUPA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        References(x => x.Student).Column("ID_STUDENTA").LazyLoad();
        References(x => x.Grupa).Column("ID_GRUPE").LazyLoad();
    }
}