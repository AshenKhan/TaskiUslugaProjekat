using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskiUsluga.Models.Enumi;

namespace TaskiUsluga.Models.OstaleKlase
{
    public class Komentar
    {
        private int id;
        private string opis;
        private DateTime datumObjave;
        private string voznja;
        private Ocena ocenaVoznje;

        public Komentar() { OcenaVoznje = 0; }

        public Komentar(int id, string o, DateTime d, string v, int ov)
        {
            Id = id;
            Opis = o;
            DatumObjave = d;
            Voznja = v;
            OcenaVoznje = (Ocena)ov;
        }

        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Voznja { get; set; }
        public Ocena OcenaVoznje { get; set; }

        public override string ToString()
        {
            return Id.ToString() + ";" + Opis.ToString() + ";" + DatumObjave.ToString() + ";" + Voznja.ToString() + ";" + OcenaVoznje.ToString() + ";";
        }
    }
}