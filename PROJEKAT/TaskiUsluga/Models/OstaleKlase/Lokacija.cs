using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskiUsluga.Models.OstaleKlase
{
    public class Lokacija
    {
        private int id;
        private double x;
        private double y;

        private Adresa adresa;

        public Lokacija()
        {
            Adresa = new Adresa();
        }

        public Lokacija(int i, double x, double y, Adresa a)
        {

            Id = i;
            X = x;
            Y = y;
            Adresa = a;
        }

        public int Id { get => id; set => id = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Adresa Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return "Koordinate: " + X + ", " + Y + ".\n Adresa: " + Adresa.ToString();
        }
    }
}