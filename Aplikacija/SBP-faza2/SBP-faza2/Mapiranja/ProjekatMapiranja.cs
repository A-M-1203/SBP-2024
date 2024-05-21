using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class ProjekaMapiranja : ClassMap<Projekat>
{
    public ProjekaMapiranja()
    {
        Table("PROJEKAT");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        Map(x => x.Naziv, "NAZIV");
        Map(x => x.SkolskaGodina, "SKOLSKA_GODINA");
        Map(x => x.Grupni, "GRUPNI");
        Map(x => x.RokZaZavrsetak, "ROK_ZA_ZAVRSETAK");
        Map(x => x.MaksimalanBrojStrana, "MAKSIMALAN_BROJ_STRANA");
        Map(x => x.PreporuceniProgramskiJezik, "PREPORUCENI_PROGRAMSKI_JEZIK");
        Map(x => x.KratakOpis, "KRATAK_OPIS");
        Map(x => x.BrojIzvestaja, "BROJ_IZVESTAJA");
        Map(x => x.TipProjekta, "TIP_PROJEKTA");
        References(x => x.IdPredmeta);
        HasMany(x => x.Izvestaji).Inverse().Cascade.All();
        HasMany(x => x.Grupe).Inverse().Cascade.All();
        HasManyToMany(x => x.Studenti);
        HasManyToMany(x => x.Knjige);
        HasManyToMany(x => x.Radovi);
        HasManyToMany(x => x.Clanci);
        HasMany(x => x.Stranice).Inverse().Cascade.All();






    }
}
