using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPI_Restoran.Data.Other
{

    /// <summary>
    /// Klasa Gost sadrži sve potrebne podatke o gostima. Za identifikaciju gosta koristimo broj osobne 
    ///  iskaznice, čime se uvjeravamo da gost koji želi obaviti rezervaciju nije maloljetan.
    /// </summary>
    public class Gost
    {
        private int brojOsobne;
        private string ime;
        private string prezime;
        private List<string> kontakti;
        private static List<Gost> gosti;

        /// <summary>
        /// Zadani konstruktor koji prima tri parametra
        /// </summary>
        /// <param name="brojOsobne"></param>
        /// <param name="ime"></param>
        /// <param name="prezime"></param>
        public Gost(int brojOsobne, string ime, string prezime)
        {
            this.brojOsobne = brojOsobne;
            this.ime = ime;
            this.prezime = prezime;
            kontakti = new List<string>();
        }

        public int BrojOsobne { get => brojOsobne; set => brojOsobne = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public List<string> Kontakti { get => kontakti; set => kontakti = value; }


        /// <summary>
        /// Uz pomoć baze podataka vraca popis svih gostiju
        /// </summary>
        public static List<Gost> Gosti { get => Connection.SQL_Gosti(); }

        /// <summary>
        /// Pretrazuje postoji li gost sa trazenim brojem osobne iskaznice, ako postoji vraća njegovu instancu
        /// </summary>
        /// <param name="brojOs"></param>
        /// <returns></returns>
        public static Gost Trazi(int brojOs)
        {
            foreach(Gost g in Gosti)
            {
                if (g.BrojOsobne == brojOs)
                {
                    return g;
                }
            }
            return null;
        }

        /// <summary>
        /// Vraca bool vrijednost koja ovisi o tome ima li gost rezervaciju u datom terminu
        /// </summary>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        /// <returns></returns>
        public bool UTerminu(DateTime pocetak, DateTime kraj)
        {
            foreach (Rezervacija rez in Connection.ŞQL_Rezervacije(pocetak, kraj))
            {
                if (rez.Gost.BrojOsobne == BrojOsobne)
                {
                    return true;
                }
            }
            return false;
        }
    
        /// <summary>
        /// Vraca bool vrijednost ovisno o tome je li uneseni format osobne iskaznice tocan
        /// </summary>
        /// <param name="broj"></param>
        /// <returns></returns>
        public static bool TocanFormatOsobne(int broj)
        {
            //if (broj == 0) return false;

            int duzina = (int)Math.Log10(broj) + 1;

            bool b = duzina == 8? true: false;
            return b;
        }
    }
}
