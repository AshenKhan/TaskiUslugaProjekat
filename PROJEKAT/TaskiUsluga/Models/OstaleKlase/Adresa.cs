using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskiUsluga.Models.OstaleKlase
{
    public class Adresa
    {
        private string ulica;
        private int broj;
        private string naseljenoMesto;
        private string pozivniBroj;

        public Adresa()
        {
            Ulica = "";
            PozivniBroj = "";
        }

        public Adresa(string u, int b, string nm, string pb)
        {

            Ulica = u;
            Broj = b;
            NaseljenoMesto = nm;
            PozivniBroj = pb;
        }

        public string Ulica { get { return ulica; } set { ulica = value; } }

        public int Broj { get { return broj; } set { broj = value; } }

        public string NaseljenoMesto { get { return naseljenoMesto; } set { naseljenoMesto = value; } }

        public string PozivniBroj { get { return pozivniBroj; } set { pozivniBroj = value; } }

        public override string ToString()
        {
            return ulica.ToString() + ";" + broj.ToString() + ";" + naseljenoMesto.ToString() + ";" + pozivniBroj.ToString() + ";";
        }
    }
}