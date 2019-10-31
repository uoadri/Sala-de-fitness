using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            userControl11.ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = login.accdb";
            userControl11.Tabela = "utilizatori";
            userControl11.nume = new Admin();
            userControl11.nume2 = new Form1();
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizator: user" + Environment.NewLine + "Parola: 1111" + Environment.NewLine +
                            "Utilizator: admin" + Environment.NewLine + "Parola: 0000" + Environment.NewLine +
                            "Drepturi:" + Environment.NewLine + "-user adauga rezervari" + Environment.NewLine +
                            "-admin modifica rezervari");
        }

        private void resetareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login NewForm = new Login();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
