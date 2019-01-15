using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskiUsluga.Models.Enumi;
using TaskiUsluga.Models.OstaleKlase;

namespace TaskiUsluga.Models.Korisnici
{
    public class Dispecer : IKorisnik
    {
        private int id;
        private string korisnickoIme;
        private string lozinka;
        private string ime;
        private string prezime;
        private Pol polKorisnika;
        private string jmbg;
        private string kontaktTelefon;
        private string email;
        private Uloga ulogaKorisnika = Uloga.dispecer;
        private List<Voznja> voznje;

        public Dispecer() { }
        public Dispecer(int id, string ki, string l, string i, string pr, Pol pol, string j, string kt, string e)
        {
            Id = id;
            KorisnickoIme = ki;
            Lozinka = l;
            Ime = i;
            Prezime = pr;
            PolKorisnika = pol;
            Jmbg = j;
            KontaktTelefon = kt;
            Email = e;
            Voznje = new List<Voznja>();
            UlogaKorisnika = Uloga.dispecer;
            Voznje = new List<Voznja>();
        }

        public int Id { get { return id; } set { id = value; } }

        public string KorisnickoIme { get { return korisnickoIme; } set { korisnickoIme = value; } }

        public string Lozinka { get { return lozinka; } set { lozinka = value; } }

        public string Ime { get { return ime; } set { ime = value; } }

        public string Prezime { get { return prezime; } set { prezime = value; } }

        public Pol PolKorisnika { get { return polKorisnika; } set { polKorisnika = value; } }

        public string Jmbg { get { return jmbg; } set { jmbg = value; } }

        public string KontaktTelefon { get { return kontaktTelefon; } set { kontaktTelefon = value; } }

        public string Email { get { return email; } set { email = value; } }

        public Uloga UlogaKorisnika { get { return ulogaKorisnika; } set { ulogaKorisnika = value; } }

        public List<Voznja> Voznje { get { return voznje; } set { voznje = value; } }
    }
}