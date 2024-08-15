using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
namespace SBP_faza2.Mapiranja;

public class ProjekatMapiranja : ClassMap<Projekat>
{
    public ProjekatMapiranja()
    {
        Table("PROJEKAT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv, "NAZIV");
        Map(x => x.SkolskaGodina, "SKOLSKA_GODINA");
        Map(x => x.Grupni, "GRUPNI");
        Map(x => x.DatumPocetka, "DATUM_POCETKA");
        Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
        Map(x => x.RokZaZavrsetak, "ROK_ZA_ZAVRSETAK");
        //Map(x => x.Tip, "TIP_PROJEKTA").Not.Nullable();

        DiscriminateSubClassesOnColumn("TIP_PROJEKTA").Not.Nullable();

        References(x => x.Predmet).Column("ID_PREDMETA").LazyLoad();
        
        HasMany(x => x.Grupe).KeyColumn("ID_PROJEKTA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.StudentiProjekti).KeyColumn("ID_PROJEKTA").LazyLoad().Cascade.All().Inverse();
    }
}

class TeorijskiProjekatMapiranja : SubclassMap<TeorijskiProjekat>
{
    public TeorijskiProjekatMapiranja()
    {
        DiscriminatorValue("Teorijski");

        Map(x => x.MaksimalanBrojStrana, "MAKSIMALAN_BROJ_STRANA");

        HasMany(x => x.ProjektiLiterature).KeyColumn("ID_PROJEKTA").LazyLoad().Cascade.All().Inverse();
    }
}

class PrakticniProjekatMapiranja : SubclassMap<PrakticniProjekat>
{
    public PrakticniProjekatMapiranja()
    {
        DiscriminatorValue("Praktični");

        Map(x => x.PreporuceniProgramskiJezik, "PREPORUCENI_PROGRAMSKI_JEZIK");
        Map(x => x.KratakOpis, "KRATAK_OPIS");
        Map(x => x.BrojIzvestaja, "BROJ_IZVESTAJA");

        HasMany(x => x.Izvestaji).KeyColumn("ID_PROJEKTA").LazyLoad().Cascade.All().Inverse();
        HasMany(x => x.Stranice).KeyColumn("ID_PROJEKTA").LazyLoad().Cascade.All().Inverse();
    }
}