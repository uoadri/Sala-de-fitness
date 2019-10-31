using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paw_proiect
{
    public partial class Form2 : Form
    {
        
        public Form2(ArrayList lista)
        {
            InitializeComponent();
            foreach (Clienti cl in lista)
            {  
                if (DateTime.Compare(cl.DtRezervari, DateTime.Now) < 0)
                    tbAfisare.Text += "Rezervare expirata: " + cl.ToString() + Environment.NewLine;
                else
                    tbAfisare.Text += cl.ToString() + Environment.NewLine;
            }
        }

        private void tbAfisare_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
