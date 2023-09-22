using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sustav_za_rezervacije.Entities;

namespace sustav_za_rezervacije.Forms
{
    public partial class ReservationInputForm : Form
    {

        private (DateTime, DateTime) vrijemeRezervacije;
        public Rezervacija Rezervacija;
        /// <summary>
        /// Svojstvo koje prikazuje jesu li podaci uspješno učitani
        /// </summary>
        public bool Done;

        /// <summary>
        /// Konstruktor prima raspon vremena u kojem se odvija rezervacija
        /// </summary>
        /// <param name="vrijemeRezervacije"></param>
        public ReservationInputForm((DateTime, DateTime) vrijemeRezervacije)
        {
            InitializeComponent();
            this.vrijemeRezervacije = vrijemeRezervacije;
            Done = false;
        }

        /// <summary>
        /// Postavlja podatke o rezervaciji na formu
        /// </summary>
        /// <param name="r"> predstavlja rezervaciju koju želimo prikazati</param>
        public void PostaviInformacije(Rezervacija r)
        {
            Gost g = r.Gost;
            txtBrojOsobne.Text = g.BrojOsobne.ToString();
            txtIme.Text = g.Ime;
            txtPrezime.Text = g.Prezime;
            txtKontakt.Text = r.Kontakt;

            txtBrojOsobne.SelectAll();
            txtIme.SelectAll();
            txtPrezime.SelectAll();
            txtKontakt.SelectAll();
        }

        /// <summary>
        /// Metoda koja provjerava ispravnost podataka pri unosu u bazu podataka i
        ///  postavlja bool vrijednost svojstva Done na true ukoliko su podaci uspješno učitani
        /// </summary>
        private void NewReservation()
        {
            int brojOsobne = 0;
            string ime, prezime, kontakt;


            if (txtIme.Text == "" || txtPrezime.Text == "" || txtKontakt.Text == "" || txtBrojOsobne.Text == "")
            {
                MessageBox.Show("Polja ne smiju ostati prazna");
                return;
            }

            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            kontakt = txtKontakt.Text;

            if (!int.TryParse(txtBrojOsobne.Text, out brojOsobne))
            {
                MessageBox.Show("Format broja osobne nije valjan");
                return;
            }

            if (!Gost.TocanFormatOsobne(brojOsobne))
            {
                MessageBox.Show("Pogrešan broj osobne");
                return;
            }


            if (lstStol.SelectedItem == null)
            {
                MessageBox.Show("Odaberite stol!");
                return;
            }
            string[] parts = lstStol.SelectedItem.ToString().Split('\t');
            int broj = int.Parse(parts[0]);
            Stol stol = Stol.Trazi(broj);


            Gost g = new Gost(brojOsobne, ime, prezime);
            Rezervacija rez = null;

            if (Gost.Trazi(g.BrojOsobne) == null)
            {
                DialogResult d = MessageBox.Show(
                    "Gost ne postoji, želite li ga unijeti?", "Upozorenje", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    Project.DataHandler.DodajGosta(g);
                    MessageBox.Show("Gost je dodan");
                }
                else
                {
                    MessageBox.Show("Odustali ste od rezervacije!");
                    return;
                }
            }
            else
            {

                if (g.UTerminu(vrijemeRezervacije.Item1, vrijemeRezervacije.Item2))
                {
                    MessageBox.Show("Gost sa traženim identitetom već ima rezervaciju u danom terminu!");
                    rez = Rezervacija.Trazi(g, vrijemeRezervacije.Item1, vrijemeRezervacije.Item2);

                    PostaviInformacije(rez);
                    Done = false;
                    return;
                }
            }


            Rezervacija r = new Rezervacija(Project.Counter, g, stol, vrijemeRezervacije.Item1, vrijemeRezervacije.Item2, kontakt);
            Rezervacija = r;
            Done = true;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            NewReservation();

            if (Done)
            {
                Close();
                Project.TimeForm.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReservationInputForm_Load(object sender, EventArgs e)
        {
            lstStol.Items.Clear();
            foreach (Stol s in Stol.DostupniStolovi)
            {
                lstStol.Items.Add(s.Broj + "\t" + s.Klasa + "\t" + s.Pozicija);
            }
        }
    }
}
