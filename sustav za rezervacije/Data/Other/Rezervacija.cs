using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPI_Restoran.Data.Other
{

    /// <summary>
    /// Klasa rezervacija sadrži podatke o instancama rezervacije i podatke vezano uz rezervacije
    /// </summary>
    public class Rezervacija
    {
        private int broj;
        private Gost gost;
        private Stol stol;
        private DateTime pocetak;
        private DateTime kraj;
        private string kontakt;

        /// <summary>
        /// Konstruktor koji prima 5 parametara, obicno se koristi kod citanja rezervacija
        /// </summary>
        /// <param name="broj"></param>
        /// <param name="gost"></param>
        /// <param name="stol"></param>
        /// <param name="poc"></param>
        /// <param name="kr"></param>
        /// <param name="kontakt"></param>
        public Rezervacija(int broj, Gost gost, Stol stol, DateTime poc, DateTime kr, string kontakt)
        {
            this.broj = broj;
            this.gost = gost;
            this.stol = stol;
            this.pocetak = poc;
            this.kraj = kr;
            this.kontakt = kontakt;
        }

        /// <summary>
        /// Konstruktor koji prima 4 parametra, obicno se koristi kod unosa rezervacija
        /// </summary>
        /// <param name="gost"></param>
        /// <param name="stol"></param>
        /// <param name="poc"></param>
        /// <param name="kr"></param>
        /// <param name="kontakt"></param>
        public Rezervacija(Gost gost, Stol stol, DateTime poc, DateTime kr, string kontakt)
        {
            this.gost = gost;
            this.stol = stol;
            this.pocetak = poc;
            this.kraj = kr;
            this.kontakt = kontakt;
        }


        public int Broj { get => broj; set => broj = value; }
        public Gost Gost { get => gost; set => gost = value; }
        public Stol Stol { get => stol; set => stol = value; }
        public DateTime Pocetak { get => pocetak; set => pocetak = value; }
        public DateTime Kraj { get => kraj; set => kraj = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }

        /// <summary>
        /// Vraca instancu rezervacije prema parametrima koje prima, te null vrijednost
        ///  ako takva rezervacija ne postoji
        /// </summary>
        /// <param name="broj"></param>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        /// <returns></returns>
        public static Rezervacija Trazi(int broj, DateTime pocetak, DateTime kraj)
        {
            foreach (Rezervacija r in Connection.ŞQL_Rezervacije(pocetak, kraj))
            {
                if (r.broj == broj) return r;
            }
            return null;
        }

        /// <summary>
        /// /// Vraca instancu rezervacije prema parametrima koje prima, te null vrijednost
        ///  ako takva rezervacija ne postoji
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        /// <returns></returns>
        public static Rezervacija Trazi(Gost g, DateTime pocetak, DateTime kraj)
        {
            foreach (Rezervacija r in Connection.ŞQL_Rezervacije(pocetak, kraj))
            {
                if (r.Gost.BrojOsobne == g.BrojOsobne) return r;
            }
            return null;
        }

        /// <summary>
        /// Vraca string koji ispisuje instancu klase rezervacija
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string br = "Broj: " + Broj;

            string gost = String.Format("Gost: {0} {1}\nBroj dokumenta:{2}",
                Gost.Ime, Gost.Prezime, Gost.BrojOsobne);

            string stol = String.Format("Stol {0} {1} {2}", Stol.Broj, Stol.Pozicija, Stol.Klasa);

            string datumi = "Pocetak: " + Pocetak.ToString() + "\nKraj: " + Kraj.ToString();

            return br + "\n" + gost + "\n" + stol + "\n" + datumi;
        }
    }
}
