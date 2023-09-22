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
    public partial class TimeForm : Form
    {
        /// <summary>
        /// Svojstvo koje prikazuje jesu li podaci uspješno učitani
        /// </summary>
        public bool Done;


        public TimeForm()
        {
            InitializeComponent();
            Done = true;
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            DateTime d = datePicker.Value;
            int pocH = int.Parse(numHPoc.Value.ToString());
            int pocMin = int.Parse(numMinPoc.Value.ToString());
            int krajH = int.Parse(numHKraj.Value.ToString());
            int krajMin = int.Parse(numMinKraj.Value.ToString());

            string pocetakStr = String.Format("{0}-{1}-{2} {3}:{4}:{5}",
                d.Year, d.Month, d.Day, pocH, pocMin, 0);
            DateTime pocetak = DateTime.Parse(pocetakStr);

            string krajStr = String.Format("{0}-{1}-{2} {3}:{4}:{5}",
                d.Year, d.Month, d.Day, krajH, krajMin, 0);
            DateTime kraj = DateTime.Parse(krajStr);

            if (pocetak.CompareTo(kraj) >= 0)
            {
                MessageBox.Show("Kraj ne može biti prije početka");
                return;
            }

            Stol.DostupniStolovi = Project.DataHandler.DostupniStolovi(pocetak, kraj);

            if (Stol.DostupniStolovi.Count == 0)
            {
                MessageBox.Show("U tom terminu nema dostupnih stolova!");
                return;
            }


            (DateTime, DateTime) pocKraj = (pocetak, kraj);
            Project.RInputForm = new ReservationInputForm(pocKraj);
            Project.RInputForm.ShowDialog();
            Done = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
