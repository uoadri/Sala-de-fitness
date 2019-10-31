using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Xml;

namespace Paw_proiect
{
    public partial class Form1 : Form
    {
        List<Clienti> listaClienti = new List<Clienti>();
        List<string> fileName = new List<string>();
        List<int> vectNote = new List<int>();
        List<string> stringNote = new List<string>();
        Font font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
        Color culoare = Color.DarkRed;
        const int marg = 10;
        bool vb = false;
        int page;
        int nrElem = 0;
        public Form1()
        {
            InitializeComponent();
            intializareToolTip();
            Incarca();
            panelLogo.Location = new Point(217, 10);
            this.Width = 400;
            groupBox1.Width = 360;
            groupBox2.Width = 347;
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
                    listaClienti.Add(cl);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message); 
                }
            }
            sr.Close();
        }

        private void intializareToolTip()
        {
            StreamReader sr = new StreamReader("help.xml");
            string str = sr.ReadToEnd();
            sr.Close();

            XmlReader reader = XmlReader.Create(new StringReader(str));

            while (reader.Read())
            {
                if (reader.Name == "Field")
                {
                    string camp = reader["id"];

                    switch (camp)
                    {
                        case "tbNume":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(tbNume, campText.ToString());
                                break;
                            }
                        case "tbPrenume":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(tbPrenume, campText.ToString());
                                break;
                            }
                        case "dtpRezervare":
                            {
                                reader.Read();
                                string campText = reader.Value;                               
                                toolTip1.SetToolTip(dtpRezervare, campText.ToString());
                                break;
                            }
                        case "cbAntrenament":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(cbAntrenament, campText.ToString());
                                break;
                            }
                        case "clbExercitii":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(clbExercitii, campText.ToString());
                                break;
                            }
                        case "tbSerii":
                            {
                                reader.Read();
                                string campText = reader.Value;                               
                                toolTip1.SetToolTip(tbSerii, campText.ToString());
                                break;
                            }
                        case "tbRepetari":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(tbRepetari, campText.ToString());
                                break;
                            }
                        case "tbDurataAntrenament":
                            {
                                reader.Read();
                                string campText = reader.Value;                             
                                toolTip1.SetToolTip(tbDurataAntrenament, campText.ToString());
                                break;
                            }
                        case "bDurata":
                            {
                                reader.Read();
                                string campText = reader.Value;                               
                                toolTip1.SetToolTip(bDurata, campText.ToString());
                                break;
                            }
                        case "bExercitii":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(bExercitii, campText.ToString());
                                break;
                            }
                        case "buttonRezervare":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(buttonRezervare, campText.ToString());
                                break;
                            }
                        case "panelGrafic":
                            {
                                reader.Read();
                                string campText = reader.Value;                              
                                toolTip1.SetToolTip(panelGrafic, campText.ToString());
                                break;
                            }
                        case "panelImages":
                            {
                                reader.Read();
                                string campText = reader.Value;                                
                                toolTip1.SetToolTip(panelImages, campText.ToString());
                                break;
                            }
                    }
                }
            }
        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false; 
            else
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSerii.Clear();
            tbRepetari.Clear();
            tbDurataAntrenament.Clear();
            panelGrafic.Visible = false;
            panelImages.Visible = false;
            labelRezervare.Visible = false;
            dtpRezervare.Visible = false;
            buttonRezervare.Visible = false;
            panelLogo.Location = new Point(217, 10);
            this.Width = 400;
            groupBox1.Width = 360;
            groupBox2.Width = 347;
            int n = clbExercitii.Items.Count;

            for (int i = 0; i < n; i++)
            {
                clbExercitii.Items.RemoveAt(0);
            }

            if (cbAntrenament.Text != "")
            {
                clbExercitii.Visible = true;
                lExercitii.Visible = true;
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
        }

        private void clbExercitii_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                bExercitii.Visible = true;
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
                bExercitii.Visible = false;
            }
        }

        private void tbSerii_TextChanged(object sender, EventArgs e)
        {
            tbDurataAntrenament.Clear();
            labelRezervare.Visible = false;
            dtpRezervare.Visible = false;
            buttonRezervare.Visible = false;
        }

        private void tbRepetari_TextChanged(object sender, EventArgs e)
        {
            tbDurataAntrenament.Clear();
            labelRezervare.Visible = false;
            dtpRezervare.Visible = false;
            buttonRezervare.Visible = false;
        }

        private void tbSerii_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void bDurata_Click(object sender, EventArgs e)
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

        private void panelImages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bExercitii_Click(object sender, EventArgs e)
        {
            panelLogo.Location = new Point(565, 10);
            this.Width = 741;
            groupBox1.Width = 701;
            groupBox2.Width = 688;
            string aux = fileName[0];
            panelImages.Visible = true;
            panelGrafic.Visible = true;
            fileName.Clear();
            fileName.Add(aux);
            panelImages.Controls.Clear();
            vectNote.Clear();
            stringNote.Clear();
            
            for (int i = 0; i < clbExercitii.Items.Count; i++)
            {
                if (clbExercitii.GetItemChecked(i))
                {
                    string str = (string)clbExercitii.Items[i];
                    switch (str)
                    {
                        //Piept
                        case "Impins din culcat cu bara":
                            {
                                fileName.Add("piept1.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Impins din inclinat cu bara":
                            {
                                fileName.Add("piept2.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Pec-deck":
                            {
                                fileName.Add("piept3.bmp");
                                vectNote.Add(6);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Impins din culcat cu gantere":
                            {
                                fileName.Add("piept4.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Impins din inclinat cu gantere":
                            {
                                fileName.Add("piept5.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Fluturari cu gantere":
                            {
                                fileName.Add("piept6.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex6");
                                break;
                            }
                        case "Flotari la paralele":
                            {
                                fileName.Add("piept7.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Impins la aparatul pentru piept":
                            {
                                fileName.Add("piept8.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Fluturari la scripete":
                            {
                                fileName.Add("piept9.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Flotari":
                            {
                                fileName.Add("piept10.bmp");
                                vectNote.Add(6);
                                stringNote.Add("ex10");
                                break;
                            }
                        //Spate
                        case "Tractiuni la bara":
                            {
                                fileName.Add("spate1.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Ramat cu haltera":
                            {
                                fileName.Add("spate2.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Ramat cu bara T":
                            {
                                fileName.Add("spate3.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Ramat cu gantere":
                            {
                                fileName.Add("spate4.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Pull-over cu gantera/bara":
                            {
                                fileName.Add("spate5.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Tractiuni cu manerul V":
                            {
                                fileName.Add("spate6.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex6");
                                break;
                            }
                        case "Indreptari cu haltera":
                            {
                                fileName.Add("spate7.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Indreptari cu gantere":
                            {
                                fileName.Add("spate8.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Extensia spatelui la banca":
                            {
                                fileName.Add("spate9.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Ridicari ale umerilor cu gantere":
                            {
                                fileName.Add("spate10.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex10");
                                break;
                            }
                        //biceps
                        case "Flexii cu bara Z":
                            {
                                fileName.Add("biceps1.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Flexii Zottman":
                            {
                                fileName.Add("biceps2.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Flexii la scripete cu funia/bara dreapta":
                            {
                                fileName.Add("biceps3.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Flexii înclinate cu gantera":
                            {
                                fileName.Add("biceps4.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Flexii hammer":
                            {
                                fileName.Add("biceps5.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Flexii la banca Scott":
                            {
                                fileName.Add("biceps6.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex6");
                                break;
                            }
                        case "Flexii duble la scripeti":
                            {
                                fileName.Add("biceps7.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Flexii cu haltera":
                            {
                                fileName.Add("biceps8.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Flexii de concentrare/Arnold":
                            {
                                fileName.Add("biceps9.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Tractiunile la bara cu priza scurta":
                            {
                                fileName.Add("biceps10.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex10");
                                break;
                            }
                        //triceps
                        case "Flotarile la paralele":
                            {
                                fileName.Add("triceps1.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Impins din culcat cu haltera cu priza apropiata":
                            {
                                fileName.Add("triceps2.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Extensii la scripete cu funia":
                            {
                                fileName.Add("triceps3.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Extensii la scripete cu funia dupa ceafa":
                            {
                                fileName.Add("triceps4.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Extensii pentru triceps sau Skull Crushers":
                            {
                                fileName.Add("triceps5.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Extensii triceps cu gantera":
                            {
                                fileName.Add("triceps6.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex6");
                                break;
                            }
                        case "Presa cu gantera":
                            {
                                fileName.Add("triceps7.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Kickbacks":
                            {
                                fileName.Add("triceps8.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Body-up":
                            {
                                fileName.Add("triceps9.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Flotari diamant":
                            {
                                fileName.Add("triceps10.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex10");
                                break;
                            }
                        //umeri
                        case "Presa cu bara dreapta":
                            {
                                fileName.Add("umeri1.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Presa militara din picioare":
                            {
                                fileName.Add("umeri2.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Ramat cu ganterele din inclinat":
                            {
                                fileName.Add("umeri3.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Presa cu ganterele din sezut":
                            {
                                fileName.Add("umeri4.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Presa cu haltera din sezut":
                            {
                                fileName.Add("umeri5.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Ramat vertical cu bara dreapta/bara Z":
                            {
                                fileName.Add("umeri6.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex6");
                                break;
                            }
                        case "Presa Arnold":
                            {
                                fileName.Add("umeri7.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Fluturari din aplecat":
                            {
                                fileName.Add("umeri8.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Ridicari laterale cu gantera":
                            {
                                fileName.Add("umeri9.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Ridicari frontale cu gantera/kettlebell/discul":
                            {
                                fileName.Add("umeri10.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex10");
                                break;
                            }
                        //picioare
                        case "Genuflexiuni cu Bara pe Spate":
                            {
                                fileName.Add("picioare1.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex1");
                                break;
                            }
                        case "Genuflexiuni Frontale":
                            {
                                fileName.Add("picioare2.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex2");
                                break;
                            }
                        case "Genuflexiuni Bulgare Impartite":
                            {
                                fileName.Add("picioare3.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex3");
                                break;
                            }
                        case "Fandari din Mers":
                            {
                                fileName.Add("picioare4.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex4");
                                break;
                            }
                        case "Presa pentru Picioare":
                            {
                                fileName.Add("picioare5.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex5");
                                break;
                            }
                        case "Flexii pentru Picioare":
                            {
                                fileName.Add("picioare6.bmp");
                                vectNote.Add(7);
                                stringNote.Add("ex6");
                                break;
                            }
                        //abdomen
                        case "Ridicari de picioare sau genunchi din atarnat":
                            {
                                fileName.Add("abdomen1.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex7");
                                break;
                            }
                        case "Crunch la aparat":
                            {
                                fileName.Add("abdomen2.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex8");

                                break;
                            }
                        case "Crunch la scripete":
                            {
                                fileName.Add("abdomen3.bmp");
                                vectNote.Add(8);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Roll-out cu roata":
                            {
                                fileName.Add("abdomen4.bmp");
                                vectNote.Add(10);
                                stringNote.Add("ex10");
                                break;
                            }
                        case "Pozitia plank":
                            {
                                fileName.Add("abdomen5.bmp");
                                vectNote.Add(9);
                                stringNote.Add("ex9");
                                break;
                            }
                        case "Genuflexiunile":
                            {
                                fileName.Add("abdomen6.bmp");
                                vectNote.Add(6);
                                stringNote.Add("ex10");
                                break;
                            }
                    }
                }
            }
            try
            {
                int y = 1;
                foreach (string img in fileName)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(1, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 370;
                    pic.Height = 500;
                    y += pic.Height + 20;
                    panelImages.Controls.Add(pic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            vb = true;
            panelGrafic.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Introduceti numele");
            }
            else
            if (tbPrenume.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbPrenume, "Introduceti prenumele");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume;
                    string prenume;
                    List<string> denumireAparat = new List<string>();
                    string tipExercitiu;
                    int nrRepetari;
                    int nrSerii;
                    DateTime dtRez;

                    nume = tbNume.Text;
                    prenume = tbPrenume.Text;
                    tipExercitiu = cbAntrenament.Text;
                    nrRepetari = Convert.ToInt32(tbRepetari.Text);
                    nrSerii = Convert.ToInt32(tbSerii.Text);
                    dtRez = dtpRezervare.Value;
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
                    Clienti cl = new Clienti(nume, prenume, dtRez, denumireAparat, tipExercitiu, nrRepetari, nrSerii);
                    listaClienti.Add(cl);
                    MessageBox.Show("Rezervare adaugata cu succes! " + Environment.NewLine + cl.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                nrElem = vectNote.Count;
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 3);
                Rectangle rec = new Rectangle(0 + marg,
                                              0 + marg,
                                              panelGrafic.Width - 2 * marg,
                                              panelGrafic.Height - 3 * marg);
                g.DrawRectangle(pen, rec);

                Rectangle[] recs = new Rectangle[nrElem];
                double latime = rec.Width / nrElem / 2;
                double distanta = (rec.Width - latime * nrElem) / (nrElem + 1);
                double vMax = vectNote.Max();
                Brush br = new SolidBrush(culoare);
                
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Left + (i + 1) * distanta + i * latime),
                                            (int)(rec.Bottom - vectNote[i] / vMax * rec.Height),
                                            (int)latime,
                                            (int)(vectNote[i] / vMax * rec.Height));
                    g.DrawString(stringNote[i].ToString(), font, br,
                                (int)(rec.Left + (i+1) * distanta + i * latime),
                                (int)(rec.Bottom));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                            recs[i + 1].Location.Y));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void salveazaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("date.txt");
            foreach (Clienti cl in listaClienti)
                sw.Write(cl.Salveaza() + Environment.NewLine);
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void afiseazaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
       
        void pd_print(object sender, PrintPageEventArgs e)
        {
           
            if (vb == true)
            {
                Graphics g = e.Graphics;
                nrElem = vectNote.Count;
                Pen pen = new Pen(Color.Black, 3);
                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                                              e.PageBounds.Y + marg+10,
                                              e.PageBounds.Width - 2 * marg,
                                              e.PageBounds.Height - 5 * marg);
                g.DrawRectangle(pen, rec);

                Rectangle[] recs = new Rectangle[nrElem];
                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - latime * nrElem) / (nrElem + 1);
                double vMax = vectNote.Max();
                Brush br = new SolidBrush(culoare);

                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Left + (i + 1) * distanta + i * latime),
                                            (int)(rec.Bottom - vectNote[i] / vMax * rec.Height),
                                            (int)latime,
                                            (int)(vectNote[i] / vMax * rec.Height));
                    g.DrawString(stringNote[i].ToString(), font, br,
                                (int)(rec.Left + (i + 1) * distanta + i * latime),
                                (int)(rec.Bottom));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                            recs[i + 1].Location.Y));
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        void img_print(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Image pic = System.Drawing.Image.FromFile(fileName[page].ToString());
            e.Graphics.DrawImage(pic, new Rectangle(200, 200, pic.Width, pic.Height));
            e.HasMorePages = ++page < this.fileName.Count();
            e.Graphics.Dispose();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            page = 0;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(img_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void salveazaDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listaClienti.Sort(delegate (Clienti x, Clienti y)
            {
                return x.DtRezervari.CompareTo(y.DtRezervari);
            });
            ArrayList SortedList = new ArrayList(listaClienti.ToList());
            Form2 frm = new Form2(SortedList);
            frm.ShowDialog();
        }

        private void dtpRezervare_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void contextMenuStripImages_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajutor frm = new Ajutor();
            frm.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tbDurataAntrenament_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrenume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
