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
    public partial class ReservationMainForm : Form
    {
        public ReservationMainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Metoda koja ispisuje podatke o rezervacijama u list box
        /// </summary>
        /// <param name="list"></param>
        private void IspisRezervacija(List<Rezervacija> list)
        {
            lstRezervacije.Items.Clear();
            foreach (Rezervacija r in list)
            {
                string ispis = String.Format("{0}\t {1} - {2} \t {3} {4} {5} \t Stol {6} {7} {8}",
                    r.Broj, r.Pocetak.TimeOfDay, r.Kraj.TimeOfDay, r.Gost.Ime, r.Gost.Prezime,
                    r.Kontakt, r.Stol.Broj, r.Stol.Pozicija, r.Stol.Klasa);
                lstRezervacije.Items.Add(ispis);
            }
        }

        private void ReservationMainForm_Load(object sender, EventArgs e)
        {
            Project.DataHandler.UcitajPodatke();
            MessageBox.Show("Učitano!");

            DateTime t = datePicker.Value;
            string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

            DateTime pocetak = DateTime.Parse(date);
            DateTime kraj = pocetak.AddHours(24);

            List<Rezervacija> rezervacije = Project.DataHandler.DohvatiRezervacije(pocetak, kraj);
            IspisRezervacija(rezervacije);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Project.TimeForm = new TimeForm();
            Project.TimeForm.ShowDialog();

            if (Project.TimeForm.Done != true)
            {
                return;
            }

            if (Project.RInputForm == null)
            {
                return;
            }

            if (Project.RInputForm != null && Project.RInputForm.Done != true)
            {
                return;
            }

            

            Project.DataHandler.DodajRezervaciju(Project.RInputForm.Rezervacija);
            MessageBox.Show("Rezervacija je uspješno spremljena", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Project.DataHandler.AzurirajPodatke();

            DateTime t = datePicker.Value;
            string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

            DateTime pocetak = DateTime.Parse(date);
            DateTime kraj = pocetak.AddHours(24);
            IspisRezervacija(Project.DataHandler.DohvatiRezervacije(pocetak, kraj));
        }

        private void btnStolovi_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Stol s in Project.DataHandler.TablicaStolova.Values)
            {
                msg += s.ToString() + "\n";
            }
            MessageBox.Show(msg);
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lstRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Rezervacija nije odabrana!");
                return;
            }

            string[] parts = lstRezervacije.SelectedItem.ToString().Split('\t');
            int brojRez = int.Parse(parts[0]);

            Project.DataHandler.ObrisiRezervaciju(brojRez);
            Project.DataHandler.PovecajBroj();
            Project.DataHandler.AzurirajPodatke();
            
            DateTime t = datePicker.Value;
            string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

            DateTime pocetak = DateTime.Parse(date);
            DateTime kraj = pocetak.AddHours(24);
            List<Rezervacija> rezervacije = Project.DataHandler.DohvatiRezervacije(pocetak, kraj);
            IspisRezervacija(rezervacije);
        }
    }
}
