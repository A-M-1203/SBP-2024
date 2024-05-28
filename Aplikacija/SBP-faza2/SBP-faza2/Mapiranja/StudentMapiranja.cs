using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
namespace SBP_faza2.Mapiranja;

public class StudentMapiranja : ClassMap<Student>
{
    public StudentMapiranja()
    {
        Table("STUDENT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.BrojIndeksa, "BROJ_INDEKSA");
        Map(x => x.LicnoIme, "LICNO_IME");
        Map(x => x.ImeRoditelja, "IME_RODITELJA");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.Smer, "SMER");

        HasMany(x => x.Izvestaji).KeyColumn("ID_STUDENTA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.StudentiGrupe).KeyColumn("ID_STUDENTA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.StudentiProjekti).KeyColumn("ID_STUDENTA").LazyLoad().Cascade.All().Inverse();
    }
}