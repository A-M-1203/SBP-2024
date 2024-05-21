﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2.Entiteti;

public class Projekat
{
    public virtual int Id { get; protected set; }
    public virtual required string Naziv { get; set; }
    public virtual required string SkolskaGodina { get; set; }
    public virtual required string Grupni { get; set; }
    public virtual DateTime? RokZaZavrsetak { get; set; }
    public virtual int MaksimalanBrojStrana { get; set; }
    public virtual string? PreporuceniProgramskiJezik { get; set; }
    public virtual string? KratakOpis { get; set; }
    public virtual int BrojIzvestaja { get; set; }
    public virtual required Predmet IdPredmeta { get; set; }
    public virtual required string TipProjekta { get; set; }
    public virtual IList<Izvestaj> Izvestaji { get; set; }
    public virtual IList<Grupa> Grupe { get; set; }
    public virtual IList<Student> Studenti { get; set; }
    public virtual IList<Knjiga> Knjige { get; set; }
    public virtual IList<Clanak> Clanci { get; set; }
    public virtual IList<Rad> Radovi { get; set; }
    public virtual IList<PreporuceneStranice> Stranice { get; set; }




    public Projekat()
    {
        Izvestaji = new List<Izvestaj>();
        Grupe = new List<Grupa>();
        Studenti = new List<Student>();
        Knjige = new List<Knjiga>();
        Clanci = new List<Clanak>();
        Radovi = new List<Rad>();
        Stranice = new List<PreporuceneStranice>();
    }
}