using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class PredmetMapiranja : ClassMap<Predmet>
{
    public PredmetMapiranja()
    {
        Table("PREDMET");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Sifra, "SIFRA_PREDMETA");
        Map(x => x.Naziv, "NAZIV_PREDMETA");
        Map(x => x.Katedra, "KATEDRA");
        Map(x => x.Semestar, "SEMESTAR");

        HasMany(x => x.Projekti).Inverse().Cascade.All();//ovo nisam bas siguran da li treba

    }
}