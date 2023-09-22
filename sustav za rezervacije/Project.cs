using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sustav_za_rezervacije.Forms;

namespace sustav_za_rezervacije
{
    public class Project
    {
        private static DataHandler handler = new DataHandler();
        public static DataHandler DataHandler { get { return handler; } }

        public static ReservationInputForm RInputForm;
        public static TimeForm TimeForm;
        public static ReservationMainForm MainForm;

        public static int Counter
        {
            get
            {
                return DataHandler.TablicaGosti.Count;
            }
        }
    }
}
