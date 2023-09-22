using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sustav_za_rezervacije.Entities
{
    /// <summary>
    /// Klasa stol sadrži podatke o instancama stolova i podatke vezano uz stolove
    /// </summary>
    public class Stol
    {
        private int broj;
        private string klasa;
        private string pozicija;

        public static List<Stol> DostupniStolovi;

        public Stol(int broj, string klasa, string pozicija)
        {
            this.broj = broj;
            this.klasa = klasa;
            this.pozicija = pozicija;
        }

        public int Broj { get => broj; set => broj = value; }
        public string Klasa { get => klasa; set => klasa = value; }
        public string Pozicija { get => pozicija; set => pozicija = value; }

        public static Stol Trazi(int broj)
        {
            foreach (Stol s in DostupniStolovi)
            {
                if (s.broj == broj)
                {
                    return s;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"{this.Broj} - {this.Pozicija} - {this.Klasa}";
        }

        /// <summary>
        /// Ova metoda testira nalazi li se bilo koji od dva broja unutar intervala,
        ///  metoda je važna za kasniju konstrukciju upita vezanih za slobodne stolove u zadanom terminu
        /// </summary>
        /// <param name="num1"> prvi broj</param>
        /// <param name="num2"> drugi broj</param>
        /// <param name="g1"> gornja granica intervala</param>
        /// <param name="g2"> donja granica intervala</param>
        /// <returns></returns>
        public static bool InIntervalTestMethod(int num1, int num2, int g1, int g2)
        {
            return !((num1 < g1 && num2 < g1) || (num1 > g2 && num2 > g2)) || (num1 >= g1 && num2 <= g2);
        }
    }
}
