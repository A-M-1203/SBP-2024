﻿using FluentNHibernate.Mapping;
using SBP_faza2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Mapiranja;

public class StudentGrupaMapiranja : ClassMap<StudentGrupa>
{
    public StudentGrupaMapiranja()
    {
        Table("STUDENT_GRUPA");
        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
        References(x => x.IdGrupe);
        References(x => x.IdStudenta);
    }
}