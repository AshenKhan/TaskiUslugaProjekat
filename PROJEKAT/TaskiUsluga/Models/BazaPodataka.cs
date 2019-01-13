using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using TaskiUsluga.Models.Korisnici;
using TaskiUsluga.Models.OstaleKlase;

namespace TaskiUsluga.Models
{
    public class BazaPodataka
    {
        public List<IKorisnik> lista = new List<IKorisnik>();
        public List<Voznja> voznje = new List<Voznja>();

        public void UcitajKorisnikauBazu(IKorisnik k)
        {
            string path = @"..\BazaKorisnika.txt";
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Username:").Append("\t\t").Append(k.KorisnickoIme).Append("\n");
            sb.Append("Password:").Append("\t\t").Append(k.Lozinka).Append("\n");
            sb.Append("First Name:").Append("\t\t").Append(k.Ime).Append("\n");
            sb.Append("Last Name:").Append("\t\t").Append(k.Prezime).Append("\n");
            sb.Append("Pol:").Append("\t\t").Append(k.PolKorisnika).Append("\n");
            sb.Append("JMBG:").Append("\t\t").Append(k.Jmbg).Append("\n");
            sb.Append("Kontakt:").Append("\t\t").Append(k.KontaktTelefon).Append("\n");
            sb.Append("Email:").Append("\t\t").Append(k.Email).Append("\n");
            sb.Append("Uloga:").Append("\t\t").Append(k.UlogaKorisnika).Append("\n");
            /*if(k.GetType == "Vozac")
            {
                sb.Append("Lokacija Vozaca:").Append("\t\t").Append(k.).Append("\n");
                sb.Append("Automobil Vozaca:").Append("\t\t").Append(k.UlogaKorisnika).Append("\n");
            }*/
            sb.Append("********************************************");
            sb.Append("\n");

            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public void UcitajVoznjuuBazu(Voznja v)
        {
            string path = @"..\BazaVoznji.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append("Datum i Vreme Porudzbine:").Append("\t\t").Append(v.VremePorudzbine).Append("\n");
            sb.Append("Lokacija Dolaska:").Append("\t\t").Append(v.MestoDolaska.X).Append(", ").Append(v.MestoDolaska.Y).Append(", ").Append(v.MestoDolaska.Adresa).Append("\n");
            sb.Append("Zeljeni tip Autoa:").Append("\t\t").Append(v.TipAuta).Append("\n");
            sb.Append("Musterija:").Append("\t\t").Append(v.Musterija).Append("\n");
            sb.Append("Odrediste:").Append("\t\t").Append(v.Odrediste.X).Append(", ").Append(v.Odrediste.Y).Append(", ").Append(v.Odrediste.Adresa).Append("\n");
            sb.Append("Dispecer:").Append("\t\t").Append(v.Dispecer).Append("\n");
            sb.Append("Vozac:").Append("\t\t").Append(v.Dispecer).Append("\n");
            sb.Append("Iznos:").Append("\t\t").Append(v.Iznos).Append("\n");
            sb.Append("Komentar:").Append("\t\t").Append(v.Komentar).Append("\n");
            sb.Append("Status Voznje:").Append("\t\t").Append(v.Status).Append("\n");
            sb.Append("********************************************");
            sb.Append("\n");

            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public List<IKorisnik> IzcitajKorisnikaIzBaze()
        {
            string path = @"..\BazaKorisnika.txt";
           // lista.
        }

        public List<Voznja> IzcitajVoznjeIzBaze()
        {
            string path = @"..\BazaVoznji.txt";
            if (File.Exists(path))
            {
                using (TextReader textReader = new StreamReader("BazaVoznji.txt"))
                {

                    object obj = textReader.ReadToEnd();
                    List<Voznja> v = (List<Voznja>)obj;

                    return v;

                }
            }
            else
            {
                return null;
            }

        }
    }

    }
