using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_faza2;

public class StudentBasic
{
    public required string LicnoIme { get; set; }
    public required string ImeRoditelja { get; set; }
    public required string Prezime { get; set; }
    public required string BrojIndeksa { get; set; }
    public required string Smer { get; set; }

    public StudentBasic(string licnoIme, string imeRoditelja, string prezime, string brojIndeksa, string smer) 
    {
        LicnoIme = licnoIme;
        ImeRoditelja = imeRoditelja;
        Prezime = prezime;
        BrojIndeksa = brojIndeksa;
        Smer = smer;
    }

    public StudentBasic()
    {
        
    }
}