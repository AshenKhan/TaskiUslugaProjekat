using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskiUsluga.Models.Enumi;
using TaskiUsluga.Models.OstaleKlase;

namespace TaskiUsluga.Models.Korisnici
{
    public interface IKorisnik
    {
        int Id { get; }
        string KorisnickoIme { get; }
        string Lozinka { get; }
        string Ime { get; }
        string Prezime { get; }
        Pol PolKorisnika { get; }
        string Jmbg { get; }
        string KontaktTelefon { get; }
        string Email { get; }
        Uloga UlogaKorisnika { get; }
        List<Voznja> Voznje { get; }
        //protected List<Voznja> = IzcitajVoznjeIzBaze();



    }
}