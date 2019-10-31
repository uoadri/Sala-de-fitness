using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paw_proiect
{
    class Rezervari : Aparate
    {
        DateTime dtRevervari;

        public Rezervari(DateTime dt, List<string> denumire, string tip, int repetari, int serii)
            : base(denumire, tip, repetari, serii)
        {
            dtRevervari = dt;
        }

        public DateTime DtRezervari
        {
            get { return dtRevervari; }
            set { dtRevervari = value; }
        }

        public string SalveazaR()
        {
            return dtRevervari.ToString() + "," + base.SalveazaA();
        }

        public override string ToString()
        {
            return dtRevervari.ToString() + base.ToString();
        }
    }
}