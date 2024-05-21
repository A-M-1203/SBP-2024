using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class StudentProjekatMapiranja : ClassMap<StudentProjekat>
{
    public StudentProjekatMapiranja()
    {
        Table("STUDENT_PROJEKAT");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdStudenta);
        References(x => x.IdProjekta);
        Map(x => x.ProgramskiJezik, "PROGRAMSKI_JEZIK");
        HasMany(x => x.IdPreporuceneLiterature).Inverse().Cascade.All();
        Map(x => x.DatumPocetka, "DATUM_POCETKA");
        Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");






    }
}