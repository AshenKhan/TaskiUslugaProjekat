using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using TaskiUsluga.Models.Enumi;
using TaskiUsluga.Models.Korisnici;
using TaskiUsluga.Models.OstaleKlase;

namespace TaskiUsluga.Models
{
    public class BazaPodataka
    {
        public List<Musterija> listaMusterija = new List<Musterija>();
        public List<Vozac> listaVozaca = new List<Vozac>();
        public List<Dispecer> listaDispecera = new List<Dispecer>();
        public List<Voznja> listaVoznje = new List<Voznja>();
        public List<Automobil> listaAutomobila = new List<Automobil>();

        public void UcitajKorisnikauBazu(Musterija k)
        {
            string path = @"..\App_Data\BazaKorisnika.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append(k.Id).Append(";").Append(k.KorisnickoIme).Append(k.Lozinka).Append(";").Append(";").Append(k.Ime).Append(";").Append(k.Prezime).Append(";").Append(k.PolKorisnika).Append(";").Append(k.Jmbg).Append(";").Append(k.KontaktTelefon).Append(";").Append(k.Email).Append(";").Append(k.UlogaKorisnika).Append(";\n");

            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public void UcitajVozacauBazu(Vozac k)
        {
            string path = @"..\App_Data\BazaVozaca.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append(k.Id).Append(";").Append(k.KorisnickoIme).Append(k.Lozinka).Append(";").Append(";").Append(k.Ime).Append(";").Append(k.Prezime).Append(";").Append(k.PolKorisnika).Append(";").Append(k.Jmbg).Append(";").Append(k.KontaktTelefon).Append(";").Append(k.Email).Append(";").Append(k.UlogaKorisnika).Append(";").Append(k.Lokacija).Append(";").Append(k.Auto).Append(";\n");
            
            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public void UcitajKorisnikauBazu(Dispecer k)
        {
            string path = @"..\App_Data\BazaDispecera.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append(k.Id).Append(";").Append(k.KorisnickoIme).Append(k.Lozinka).Append(";").Append(";").Append(k.Ime).Append(";").Append(k.Prezime).Append(";").Append(k.PolKorisnika).Append(";").Append(k.Jmbg).Append(";").Append(k.KontaktTelefon).Append(";").Append(k.Email).Append(";").Append(k.UlogaKorisnika).Append(";\n");

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
            string path = @"..\App_Data\BazaVoznje.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append(v.Id).Append(";").Append(v.VremePorudzbine);
            sb.Append(";").Append(v.MestoDolaska).Append(";").Append(v.TipAuta).Append(";");
            sb.Append(v.Musterija).Append(";").Append(v.Odrediste).Append(";");
            sb.Append(v.Dispecer).Append(";").Append(v.Vozac).Append(";").Append(v.Iznos).Append(";");
            sb.Append(v.Komentar).Append(";").Append(v.Status).Append(";\n");

            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public void UcitajAutomobiluBazu(Automobil k)
        {
            string path = @"..\App_Data\BazaAutomobila.txt";
            StringBuilder sb = new StringBuilder();

            sb.Append(k.Id).Append(";").Append(k.Vozac).Append(";").Append(k.Godiste).Append(";").Append(k.Registracija).Append(";").Append(k.BrojVozila).Append(";").Append(k.TipAutomobila).Append(";");

            // Add text to the file.
            if (!File.Exists(path))
                File.WriteAllText(path, sb.ToString());
            else
                File.AppendAllText(path, sb.ToString());

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public List<Musterija> IzcitajMusterijaIzBaze()
        {
            string path = @"..\App_Data\BazaKorisnika.txt";
            List<Musterija> izcitan = new List<Musterija>();
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split(';');
                Enum.TryParse(tokens[5], out Pol pol);
                Enum.TryParse(tokens[9], out Uloga uloga);

                if(uloga == Uloga.musterija)
                {
                    Musterija m = new Musterija(Int32.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], tokens[4], pol, tokens[6], tokens[7], tokens[8]);
                    listaMusterija.Add(m);
                    izcitan.Add(m);
                }
                
            }
            sr.Close();
            stream.Close();

            return izcitan;
        }

        public List<Vozac> IzcitajVozaceIzBaze()
        {
            string path = @"..\App_Data\BazaVozaca.txt";
            List<Vozac> izcitan = new List<Vozac>();
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split(';');
                Enum.TryParse(tokens[5], out Pol pol);
                Enum.TryParse(tokens[9], out Uloga uloga);

                if (uloga == Uloga.vozac)
                {
                    Enum.TryParse(tokens[23], out Tip_Auta tipAuto);
                    Adresa a = new Adresa(tokens[13], Int32.Parse(tokens[14]), tokens[15], tokens[16]);
                    Lokacija l = new Lokacija(Int32.Parse(tokens[10]), double.Parse(tokens[11]), double.Parse(tokens[12]), a);
                    Automobil auto = new Automobil(Int32.Parse(tokens[17]), tokens[18], tokens[19], tokens[20], tokens[21], tipAuto);
                    Vozac v = new Vozac(Int32.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], tokens[4], pol, tokens[6], tokens[7], tokens[8], l, auto);
                    listaVozaca.Add(v);
                    izcitan.Add(v);
                }

            }
            sr.Close();
            stream.Close();

            return izcitan;
        }

        public List<Dispecer> IzcitajDispecereIzBaze()
        {
            string path = @"..\App_Data\BazaDispecera.txt";
            List<Dispecer> izcitan = new List<Dispecer>();
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split(';');
                Enum.TryParse(tokens[5], out Pol pol);
                Enum.TryParse(tokens[9], out Uloga uloga);

                if (uloga == Uloga.dispecer)
                {
                    Dispecer d = new Dispecer(Int32.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], tokens[4], pol, tokens[6], tokens[7], tokens[8]);
                    listaDispecera.Add(d);
                    izcitan.Add(d);
                }

            }
            sr.Close();
            stream.Close();

            return izcitan;
        }

        public List<Voznja> IzcitajVoznjeIzBaze()
        {
            string path = @"..\App_Data\BazaVoznje.txt";
            List<Voznja> izcitan = new List<Voznja>();
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(';');
                Enum.TryParse(data[9], out Tip_Auta auto);
                Enum.TryParse(data[26], out StatusVoznje s);


                Adresa a = new Adresa(data[5], Int32.Parse(data[6]), data[7], data[8]);
                Lokacija l = new Lokacija(Int32.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]), a);

                Adresa a2 = new Adresa(data[14], Int32.Parse(data[15]), data[16], data[17]);
                Lokacija l2 = new Lokacija(Int32.Parse(data[11]), double.Parse(data[12]), double.Parse(data[13]), a2);

                Komentar k = new Komentar(Int32.Parse(data[21]), data[22], DateTime.Parse(data[23]), data[24], Int32.Parse(data[25]));

                Voznja v = new Voznja(Int32.Parse(data[0]), DateTime.Parse(data[1]), l, auto, Int32.Parse(data[10]), l2, Int32.Parse(data[18]), Int32.Parse(data[19]), Int32.Parse(data[20]), k, s);

                listaVoznje.Add(v);

            }
            sr.Close();
            stream.Close();

            return izcitan;

        }

        public List<Automobil> IzcitajAutomobileIzBaze()
        {
            string path = @"..\App_Data\BazaAutomobila.txt";
            List<Automobil> izcitan = new List<Automobil>();
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] tokens = line.Split(';');
                Enum.TryParse(tokens[5], out Tip_Auta ta);

                Automobil m = new Automobil(Int32.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], tokens[4], ta);
                listaAutomobila.Add(m);
                izcitan.Add(m);

            }
            sr.Close();
            stream.Close();

            return izcitan;
        }
    }

    }
