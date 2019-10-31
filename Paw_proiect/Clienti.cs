using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paw_proiect
{
    class Clienti : Rezervari, ICloneable
    {
        private string nume;
        private string prenume;

        public Clienti(string nume, string prenume, DateTime dtRez,
            List<string> denumire, string tip, int repetari, int serii)
            : base(dtRez, denumire, tip, repetari, serii)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public bool CompareTo(object obj)
        {
            Clienti c = (Clienti)obj;
            return (string.Compare(this.nume, c.nume) == 0) 
                && (string.Compare(this.nume, c.nume) == 0) 
                && (DateTime.Compare(this.DtRezervari,c.DtRezervari) == 0) 
                && (string.Compare(this.TipExercitiu, c.TipExercitiu) == 0);           
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Clienti Clone()
        {
            return (Clienti)((ICloneable)this).Clone();
        }

        public string Salveaza()
        {
            return nume + "," + prenume + "," + base.SalveazaR();
        }

        public override string ToString()
        {
            return "Clientul: " + nume + " " + prenume + ", are rezervare: " + base.ToString();
        }
    }
}

