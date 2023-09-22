using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sustav_za_rezervacije.Entities;
using System.IO;

namespace sustav_za_rezervacije
{
    public class DataHandler
    {
        public static string DataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\StoredData\\data";
   
        public Dictionary<int, Gost> TablicaGosti;
        public Dictionary<int, string> TablicaKlasa;
        public Dictionary<int, string> TablicaPozicija;
        public Dictionary<int, Rezervacija> TablicaRezervacija;
        public Dictionary<(int, int), string> TablicaRezervacijaGost;
        public Dictionary<int, Stol> TablicaStolova;

        public DataHandler()
        {
            this.TablicaGosti = new Dictionary<int, Gost>();
            this.TablicaKlasa = new Dictionary<int, string>();
            this.TablicaPozicija = new Dictionary<int, string>();
            this.TablicaRezervacija = new Dictionary<int, Rezervacija>();
            this.TablicaRezervacijaGost = new Dictionary<(int, int), string>();
            this.TablicaStolova = new Dictionary<int, Stol>();
        }

        public bool UcitajPodatke()
        {
            // Klasa
            if (!File.Exists($"{DataPath}/klasa.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/klasa.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int id = int.Parse(dijelovi[0]);
                    string naziv = dijelovi[1];

                    this.TablicaKlasa.Add(id, naziv);
                }
            }

            // Pozicije
            if (!File.Exists($"{DataPath}/pozicija.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/klasa.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int id = int.Parse(dijelovi[0]);
                    string naziv = dijelovi[1];

                    this.TablicaPozicija.Add(id, naziv);
                }
            }

            // Rezervacija - Gost
            if (!File.Exists($"{DataPath}/rezervacija-gost.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/rezervacija-gost.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int idRez = int.Parse(dijelovi[0]);
                    int idGost = int.Parse(dijelovi[1]);
                    string kontakt = dijelovi[2];

                    this.TablicaRezervacijaGost.Add((idRez, idGost), kontakt);
                }
            }

            // Gost
            if (!File.Exists($"{DataPath}/gost.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/gost.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int id = int.Parse(dijelovi[0]);
                    string ime = dijelovi[1];
                    string prezime = dijelovi[2];

                    Gost g = new Gost(id, ime, prezime);
                    this.TablicaGosti.Add(id, g);
                }
            }

            // Stol
            if (!File.Exists($"{DataPath}/stol.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/stol.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int id = int.Parse(dijelovi[0]);
                    int klasaId = int.Parse(dijelovi[1]);
                    int pozicijaId = int.Parse(dijelovi[2]);

                    string klasa = this.TablicaKlasa[klasaId];
                    string pozicija = this.TablicaPozicija[pozicijaId];
                    Stol s = new Stol(id, klasa, pozicija);
                    this.TablicaStolova.Add(id, s);
                }
            }

            // Rezervacije
            if (!File.Exists($"{DataPath}/rezervacija.txt"))
            {
                return false;
            }
            using (StreamReader sr = File.OpenText($"{DataPath}/rezervacija.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(';');

                    int id = int.Parse(dijelovi[0]);
                    int brojOsobne = int.Parse(dijelovi[1]);
                    int idStol = int.Parse(dijelovi[2]);
                    DateTime pocetak = DateTime.Parse(dijelovi[3]);
                    DateTime kraj = DateTime.Parse(dijelovi[4]);

                    Gost g = this.TablicaGosti[brojOsobne];
                    Stol s = this.TablicaStolova[idStol];
                    Rezervacija r = new Rezervacija(id, g, s, pocetak, kraj, "");

                    this.TablicaRezervacija.Add(id, r);
                }
            }

            return true;
        }
    }
}
