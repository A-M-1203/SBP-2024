using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        HasMany(x => x.Izvestaji).Inverse().Cascade.All();
        HasManyToMany(x => x.Grupe);
        HasManyToMany(x => x.Projekti);



    }
}