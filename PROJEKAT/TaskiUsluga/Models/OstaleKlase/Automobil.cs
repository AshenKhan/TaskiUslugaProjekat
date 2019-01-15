using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskiUsluga.Models.Enumi;

namespace TaskiUsluga.Models.OstaleKlase
{
    public class Automobil
    {
        private int id;
        private string vozac;
        private string godiste;
        private string brojRegistarskeOznake;
        private string brojVozila;
        private Tip_Auta tipAutomobila;

        public Automobil(int id, string v, string g, string r, string bv, Tip_Auta ta)
        {

            Id = id;
            Vozac = v;
            Godiste = g;
            Registracija = r;
            BrojVozila = bv;
            TipAutomobila = ta;
        }

        public int Id { get; set; }
        public string Vozac { get; set; }
        public string Godiste { get; set; }
        public string Registracija { get; set; }
        public string BrojVozila { get; set; }
        public Tip_Auta TipAutomobila { get; set; }

        public override string ToString()
        {
            return Id.ToString() + ";" + Vozac.ToString() + ";" + Godiste.ToString() + ";" + Registracija.ToString() + ";" + BrojVozila.ToString() + ";" + TipAutomobila.ToString() + ";";
        }
    }
}