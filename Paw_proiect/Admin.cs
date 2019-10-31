using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paw_proiect
{
    public partial class Admin : Form
    {

        List<Clienti> listaClienti = new List<Clienti>();
        List<string> fileName = new List<string>();
        List<int> vectNote = new List<int>();
        List<string> stringNote = new List<string>();

        public Admin()
        {
            InitializeComponent();
            Incarca();
            Sortare();
            Afiseaza();
        }

        private void Afiseaza()
        {
            tbAfisare.Clear();
            foreach (Clienti c in listaClienti)
            {

                if (DateTime.Compare(c.DtRezervari, DateTime.Now) < 0)
                    tbAfisare.Text += "Rezervare expirata: " + c.ToString() + Environment.NewLine;
                else
                    tbAfisare.Text += c.ToString() + Environment.NewLine;

            }
        }

        private void Incarca()
        {
            StreamReader sr = new StreamReader("date.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    string nume = linie.Split(',')[0];
                    string prenume = linie.Split(',')[1];
                    DateTime dtRez = Convert.ToDateTime(linie.Split(',')[2]);
                    string tipExercitiu = linie.Split(',')[3];
                    int nrSerii = Convert.ToInt32(linie.Split(',')[4]);
                    int nrRepetari = Convert.ToInt32(linie.Split(',')[5]);
                    List<string> denumireAparat = new List<string>();
                    int i = 6;
                    while (linie.Split(',')[i] != "END")
                    {
                        denumireAparat.Add(linie.Split(',')[i]);
                        i++;
                    }
                    Clienti cl = new Clienti(nume, prenume, dtRez, denumireAparat, tipExercitiu, nrRepetari, nrSerii);
                    if (cbNume.FindString(nume) == -1)
                        cbNume.Items.Add(nume);
                    listaClienti.Add(cl);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
        }

        private void Sortare()
        {
            listaClienti.Sort(delegate (Clienti x, Clienti y)
            {
                return x.DtRezervari.CompareTo(y.DtRezervari);
            });
        }

        private void cbNume_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrenume.Items.Clear();
            cbRezervare.Items.Clear();
            cbAntrenament.Items.Clear();
            clbExercitii.Visible = false;
            lExercitii.Visible = false;
            buttonSterge.Visible = false;
            lSerii.Visible = false;
            tbSerii.Visible = false;
            lRepetari.Visible = false;
            tbRepetari.Visible = false;
            lDurata.Visible = false;
            tbDurataAntrenament.Visible = false;
            lminute.Visible = false;
            bDurata.Visible = false;
            foreach (Clienti cl in listaClienti)
                if (cbNume.Text == cl.Nume && cbPrenume.FindString(cl.Prenume) == -1)
                    cbPrenume.Items.Add(cl.Prenume);
        }

        private void cbPrenume_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRezervare.Items.Clear();
            cbAntrenament.Items.Clear();
            clbExercitii.Visible = false;
            lExercitii.Visible = false;
            buttonSterge.Visible = false;
            lSerii.Visible = false;
            tbSerii.Visible = false;
            lRepetari.Visible = false;
            tbRepetari.Visible = false;
            lDurata.Visible = false;
            tbDurataAntrenament.Visible = false;
            lminute.Visible = false;
            bDurata.Visible = false;
            foreach (Clienti cl in listaClienti)
                if (cbNume.Text == cl.Nume && cbPrenume.Text == cl.Prenume)
                    cbRezervare.Items.Add(cl.DtRezervari.ToString());
        }

        private void cbRezervare_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAntrenament.Items.Clear();
            clbExercitii.Visible = false;
            lExercitii.Visible = false;
            buttonSterge.Visible = false;
            lSerii.Visible = false;
            tbSerii.Visible = false;
            lRepetari.Visible = false;
            tbRepetari.Visible = false;
            lDurata.Visible = false;
            tbDurataAntrenament.Visible = false;
            lminute.Visible = false;
            bDurata.Visible = false;
            foreach (Clienti cl in listaClienti)
                if (cbNume.Text == cl.Nume && cbPrenume.Text == cl.Prenume 
                    && cbRezervare.Text == cl.DtRezervari.ToString())
                    cbAntrenament.Items.Add(cl.TipExercitiu);
        }

        private void cbAntrenament_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = clbExercitii.Items.Count;

            for (int i = 0; i < n; i++)
            {
                clbExercitii.Items.RemoveAt(0);
            }

            if (cbAntrenament.Text != "")
            {
                clbExercitii.Visible = true;
                lExercitii.Visible = true;
                buttonSterge.Visible = true;
            }

            foreach (Clienti cl in listaClienti)
                if (cbNume.Text == cl.Nume && cbPrenume.Text == cl.Prenume
                    && cbRezervare.Text == cl.DtRezervari.ToString()
                    && cbAntrenament.Text == cl.TipExercitiu)
                {
                    tbSerii.Text = Convert.ToString(cl.Nrserii);
                    tbRepetari.Text = Convert.ToString(cl.NrRepetari); 
                }

                    switch (cbAntrenament.Text)
            {
                case "Piept":
                    {
                        clbExercitii.Items.Add("Impins din culcat cu bara", CheckState.Unchecked);
                        clbExercitii.Items.Add("Impins din inclinat cu bara", CheckState.Unchecked);
                        clbExercitii.Items.Add("Pec-deck", CheckState.Unchecked);
                        clbExercitii.Items.Add("Impins din culcat cu gantere", CheckState.Unchecked);
                        clbExercitii.Items.Add("Impins din inclinat cu gantere", CheckState.Unchecked);
                        clbExercitii.Items.Add("Fluturari cu gantere", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flotari la paralele", CheckState.Unchecked);
                        clbExercitii.Items.Add("Impins la aparatul pentru piept", CheckState.Unchecked);
                        clbExercitii.Items.Add("Fluturari la scripete", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flotari", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("piept0.bmp");
                        break;
                    }
                case "Spate":
                    {
                        clbExercitii.Items.Add("Tractiuni la bara", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ramat cu haltera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ramat cu bara T", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ramat cu gantere", CheckState.Unchecked);
                        clbExercitii.Items.Add("Pull-over cu gantera/bara", CheckState.Unchecked);
                        clbExercitii.Items.Add("Tractiuni cu manerul V", CheckState.Unchecked);
                        clbExercitii.Items.Add("Indreptari cu haltera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Indreptari cu gantere", CheckState.Unchecked);
                        clbExercitii.Items.Add("Extensia spatelui la banca", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ridicari ale umerilor cu gantere", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("spate0.bmp");
                        break;
                    }
                case "Biceps":
                    {
                        clbExercitii.Items.Add("Flexii cu bara Z", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii Zottman", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii la scripete cu funia/bara dreapta", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii înclinate cu gantera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii hammer", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii la banca Scott", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii duble la scripeti", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii cu haltera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii de concentrare/Arnold", CheckState.Unchecked);
                        clbExercitii.Items.Add("Tractiunile la bara cu priza scurta", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("biceps0.bmp");
                        break;
                    }
                case "Triceps":
                    {
                        clbExercitii.Items.Add("Flotarile la paralele", CheckState.Unchecked);
                        clbExercitii.Items.Add("Impins din culcat cu haltera cu priza apropiata", CheckState.Unchecked);
                        clbExercitii.Items.Add("Extensii la scripete cu funia", CheckState.Unchecked);
                        clbExercitii.Items.Add("Extensii la scripete cu funia dupa ceafa", CheckState.Unchecked);
                        clbExercitii.Items.Add("Extensii pentru triceps sau Skull Crushers", CheckState.Unchecked);
                        clbExercitii.Items.Add("Extensii triceps cu gantera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa cu gantera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Kickbacks", CheckState.Unchecked);
                        clbExercitii.Items.Add("Body-up", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flotari diamant", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("triceps0.bmp");
                        break;
                    }
                case "Umeri":
                    {
                        clbExercitii.Items.Add("Presa cu bara dreapta", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa militara din picioare", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ramat cu ganterele din inclinat", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa cu ganterele din sezut", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa cu haltera din sezut", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ramat vertical cu bara dreapta/bara Z", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa Arnold", CheckState.Unchecked);
                        clbExercitii.Items.Add("Fluturari din aplecat", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ridicari laterale cu gantera", CheckState.Unchecked);
                        clbExercitii.Items.Add("Ridicari frontale cu gantera/kettlebell/discul", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("umeri0.bmp");
                        break;
                    }
                case "Picioare":
                    {
                        clbExercitii.Items.Add("Genuflexiuni cu Bara pe Spate", CheckState.Unchecked);
                        clbExercitii.Items.Add("Genuflexiuni Frontale", CheckState.Unchecked);
                        clbExercitii.Items.Add("Genuflexiuni Bulgare Impartite", CheckState.Unchecked);
                        clbExercitii.Items.Add("Fandari din Mers", CheckState.Unchecked);
                        clbExercitii.Items.Add("Presa pentru Picioare", CheckState.Unchecked);
                        clbExercitii.Items.Add("Flexii pentru Picioare", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("picioare0.bmp");
                        break;
                    }
                case "Abdomen":
                    {
                        clbExercitii.Items.Add("Ridicari de picioare sau genunchi din atarnat", CheckState.Unchecked);
                        clbExercitii.Items.Add("Crunch la aparat", CheckState.Unchecked);
                        clbExercitii.Items.Add("Crunch la scripete", CheckState.Unchecked);
                        clbExercitii.Items.Add("Roll-out cu roata", CheckState.Unchecked);
                        clbExercitii.Items.Add("Pozitia plank", CheckState.Unchecked);
                        clbExercitii.Items.Add("Genuflexiunile", CheckState.Unchecked);
                        fileName.Clear();
                        fileName.Add("abdomen0.bmp");
                        break;
                    }
            }
            foreach (Clienti cl in listaClienti)
                if (cbNume.Text == cl.Nume && cbPrenume.Text == cl.Prenume && cbAntrenament.Text == cl.TipExercitiu)
                {
                    for (int i = 0; i < clbExercitii.Items.Count; i++)
                        foreach (string s in cl.DenumireAparat)
                            if (s == (string)clbExercitii.Items[i])
                                clbExercitii.SetItemCheckState(i, CheckState.Checked);
                }

            if (clbExercitii.CheckedItems.Count > 0)
            {
                lSerii.Visible = true;
                tbSerii.Visible = true;
                lRepetari.Visible = true;
                tbRepetari.Visible = true;
                lDurata.Visible = true;
                tbDurataAntrenament.Visible = true;
                lminute.Visible = true;
                bDurata.Visible = true;
            }
            else
            {
                lSerii.Visible = false;
                tbSerii.Visible = false;
                lRepetari.Visible = false;
                tbRepetari.Visible = false;
                lDurata.Visible = false;
                tbDurataAntrenament.Visible = false;
                lminute.Visible = false;
                bDurata.Visible = false;
            }
        }

        private void buttonRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                string nume;
                string prenume;
                List<string> denumireAparat = new List<string>();
                string tipExercitiu;
                int nrRepetari;
                int nrSerii;

                DateTime dtRez , dtRezVechi;
                nume = cbNume.Text;
                prenume = cbPrenume.Text;
                tipExercitiu = cbAntrenament.Text;
                nrRepetari = Convert.ToInt32(tbRepetari.Text);
                nrSerii = Convert.ToInt32(tbSerii.Text);
                dtRez = dtpRezervare.Value;
                dtRezVechi = Convert.ToDateTime(cbRezervare.Text);
                for (int i = 0; i < clbExercitii.Items.Count; i++)
                {
                    if (clbExercitii.GetItemChecked(i))
                    {
                        denumireAparat.Add((string)clbExercitii.Items[i]);
                    }
                }
                if (listaClienti.Count > 0)
                {
                    foreach (Clienti c in listaClienti)
                    {
                        if (c.DtRezervari.CompareTo(dtRez) == 0)
                        {
                            if (c.DenumireAparat.All(denumireAparat.Contains) == true && c.TipExercitiu == cbAntrenament.Text)
                            {
                                TimeSpan s = new TimeSpan(dtRez.Hour, dtRez.Minute, dtRez.Second);
                                dtRez = dtRez.Date + s.Add(TimeSpan.FromMinutes(c.Durata() + 1));
                                MessageBox.Show("Rezervare existenta, incercati de la: " + dtRez.ToString());
                                dtpRezervare.Text = dtRez.ToString();
                                dtRez = dtpRezervare.Value;
                                return;
                            }
                        }
                    }
                }
                Clienti clv = new Clienti(nume, prenume, dtRezVechi, denumireAparat, tipExercitiu, nrRepetari, nrSerii);
                Clienti cln = new Clienti(nume, prenume, dtRez, denumireAparat, tipExercitiu, nrRepetari, nrSerii);
                for(int i = 0; i < listaClienti.Count; i++ )
                    if (listaClienti[i].CompareTo(clv))
                        listaClienti[i] = cln.Clone();
                Sortare();
                Afiseaza();
                MessageBox.Show("Modificare realizata cu succes! " + Environment.NewLine + cln.ToString());
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelRezervare.Visible = true;
            dtpRezervare.Visible = true;
            buttonRezervare.Visible = true;
            try
            {
                int k = 0;
                for (int i = 0; i < clbExercitii.CheckedItems.Count; i++)
                    k++;
                tbDurataAntrenament.Text = Convert.ToString(k * Convert.ToInt32(tbSerii.Text) * 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clbExercitii_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("date.txt");
            foreach (Clienti cl in listaClienti)
                sw.Write(cl.Salveaza() + Environment.NewLine);
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Clienti cl in listaClienti)
                    if (cbNume.Text == cl.Nume && cbPrenume.Text == cl.Prenume
                    && cbRezervare.Text == cl.DtRezervari.ToString()
                    && cbAntrenament.Text == cl.TipExercitiu)
                    {
                        listaClienti.Remove(cl);
                        MessageBox.Show("Stergere realizata cu succes! " + Environment.NewLine + cl.ToString());
                        break;
                     }
                Sortare();
                Afiseaza();
                cbNume.Items.Clear();
                clbExercitii.Visible = false;
                lExercitii.Visible = false;
                foreach (Clienti cl in listaClienti)
                    if (cbNume.FindString(cl.Nume) == -1)
                        cbNume.Items.Add(cl.Nume);
                cbNume_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
