using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskiUsluga.Models;
using TaskiUsluga.Models.Korisnici;

namespace TaskiUsluga.Controllers
{
    public class LogInController : Controller
    {

        BazaPodataka bz = new BazaPodataka();
        // GET: LogIn
        public ActionResult Index()
        {
            try
            {
                List<IKorisnik> SviKorisnici = new List<IKorisnik>();

                if (Session["KorisnikData"] != null)
                {
                    bz = _KorisnikRepository.GetKorisnik(Session["KorisnikData"].ToString());
                    vozac = _VozacRepository.GetVozac(Session["KorisnikData"].ToString());
                    TempData["KorisnickoIme"] = korisnik.KorisnickoIme;
                    TempData["Lozinka"] = korisnik.Lozinka;
                    TempData["Uloga"] = korisnik.Uloga;
                    TempData["Ime"] = korisnik.Ime;
                    TempData["Prezime"] = korisnik.Prezime;
                    TempData["Pol"] = korisnik.Pol;
                    TempData["JMBG"] = korisnik.JMBG;
                    TempData["KontaktTelefon"] = korisnik.KontaktTelefon;
                    if (vozac != null)
                        TempData["Lokacija"] = vozac.Lokacija;
                    TempData["Email"] = korisnik.Email;

                    if (korisnik.Uloga.ToString() == "VOZAC")
                    {
                        return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Vozac == korisnik.KorisnickoIme).ToList());
                    }
                    else if (korisnik.Uloga.ToString() == "MUSTERIJA")
                    {
                        return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Musterija == korisnik.KorisnickoIme).ToList());
                    }
                    else
                    {
                        return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Dispecer == korisnik.KorisnickoIme).ToList());
                    }

                }


                if (TempData["mySesstion0"] != null)
                {
                    korisnickoIme = TempData["mySesstion0"].ToString();
                    lozinka = TempData["mySesstion1"].ToString();
                }


                if (korisnickoIme != null && lozinka != null)
                {
                    SviKorisnici = _KorisnikRepository.UzmiKorisnike().Where(s => s.KorisnickoIme == korisnickoIme && s.Lozinka == lozinka).ToList();

                    korisnik = _KorisnikRepository.GetKorisnik(korisnickoIme, lozinka);
                    vozac = _VozacRepository.GetVozac(korisnickoIme, lozinka);
                    //if (SviKorisnici.Count != 0)
                    if (korisnik != null)
                    {
                        Session["KorisnikData"] = korisnik.KorisnickoIme;
                        TempData["KorisnickoIme"] = korisnik.KorisnickoIme;
                        TempData["Lozinka"] = korisnik.Lozinka;
                        TempData["Uloga"] = korisnik.Uloga;
                        TempData["Ime"] = korisnik.Ime;
                        TempData["Prezime"] = korisnik.Prezime;
                        TempData["Pol"] = korisnik.Pol;
                        TempData["JMBG"] = korisnik.JMBG;
                        TempData["KontaktTelefon"] = korisnik.KontaktTelefon;
                        if (vozac != null)
                            TempData["Lokacija"] = vozac.Lokacija;
                        TempData["Email"] = korisnik.Email;

                        if (korisnik.Uloga.ToString() == "VOZAC")
                        {
                            return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Vozac == korisnik.KorisnickoIme).ToList());
                        }
                        else if (korisnik.Uloga.ToString() == "MUSTERIJA")
                        {
                            return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Musterija == korisnik.KorisnickoIme).ToList());
                        }
                        else
                        {
                            return View(_VoznjeRepository.UzmiVoznje().Where(s => s.Dispecer == korisnik.KorisnickoIme).ToList());
                        }
                    }
                    else
                    {
                        TempData["ErrorLogin"] = "Korisnicko ime i/ili lozinka nisu ispravni...";
                        return View("../Home/LoginPage");
                    }
                }
                else
                {
                    return View("../Home/LoginPage");
                }
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}