using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paw_proiect
{
    class Aparate
    {
        private List<string> denumireAparat;
        private string tipExercitiu;
        private int nrRepetari;
        private int nrSerii;

        public Aparate(List<string> denumire, string tip, int repetari, int serii)

        {
            denumireAparat = denumire;
            tipExercitiu = tip;
            nrRepetari = repetari;
            nrSerii = serii;
        }

        public List<string> DenumireAparat
        {
            get { return denumireAparat; }
            set { denumireAparat = value; }
        }

        public string TipExercitiu
        {
            get { return tipExercitiu; }
            set { tipExercitiu = value; }
        }

        public int NrRepetari
        {
            get { return nrRepetari; }
            set { nrRepetari = value; }
        }

        public int Nrserii
        {
            get { return nrSerii; }
            set { nrSerii = value; }
        }

        public int Durata()
        {
            return nrSerii * denumireAparat.Count * 2;
        }

        public string SalveazaA()
        {
            string rezultat = null;
            rezultat += tipExercitiu + "," + nrSerii + "," + nrRepetari;
            foreach (string d in denumireAparat)
                rezultat += "," + d.ToString();
            rezultat += ",END" + Environment.NewLine;
            return rezultat;
        }

        public override string ToString()
        {
            string rezultat = null;
            rezultat += " antrenament pentru: " + tipExercitiu + ", cu exercitiile: " + Environment.NewLine;
            foreach (string d in denumireAparat)
                rezultat += d.ToString() + Environment.NewLine;
            return rezultat;
        }
    }
}

