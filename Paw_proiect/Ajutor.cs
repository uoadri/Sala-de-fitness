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
    public partial class Ajutor : Form
    {
        public Ajutor()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Ajutor.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                tbAjutor.Text += linie + Environment.NewLine;
            }
            sr.Close();
        }
    }
}
