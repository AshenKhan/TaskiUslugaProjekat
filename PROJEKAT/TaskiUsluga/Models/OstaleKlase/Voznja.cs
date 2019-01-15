using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskiUsluga.Models.Enumi;
using TaskiUsluga.Models.Korisnici;

namespace TaskiUsluga.Models.OstaleKlase
{
    public class Voznja
    {
        private int id;
        private DateTime vremePorudzbine;
        private Lokacija mestoDolaska;
        private Tip_Auta tipAuta;
        private int musterija;
        private Lokacija odrediste;
        private int dispecer;
        private int vozac;
        private double iznos;
        private Komentar komentar;
        private StatusVoznje status;

        public Voznja() { }

        public Voznja(int id, DateTime d, Lokacija p, Tip_Auta tip, int musterija, Lokacija lok, int dispecer, int vozac, int iz, Komentar kom, StatusVoznje st)
        {
            Id = id;
            VremePorudzbine = d;
            MestoDolaska = p;
            TipAuta = tip;
            Musterija = musterija;
            Odrediste = lok;
            Dispecer = dispecer;
            Vozac = vozac;
            Iznos = iz;
            Komentar = kom;
            Status = st;
        }

        public int Id { get => id; set => id = value; }
        public DateTime VremePorudzbine { get => vremePorudzbine; set => vremePorudzbine = value; }
        public Lokacija MestoDolaska { get => mestoDolaska; set => mestoDolaska = value; }
        public Tip_Auta TipAuta { get => tipAuta; set => tipAuta = value; }
        public int Musterija { get => musterija; set => musterija = value; }
        public Lokacija Odrediste { get => odrediste; set => odrediste = value; }
        public int Dispecer { get => dispecer; set => dispecer = value; }
        public int Vozac { get => vozac; set => vozac = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public Komentar Komentar { get => komentar; set => komentar = value; }
        public StatusVoznje Status { get => status; set => status = value; }
    }
}