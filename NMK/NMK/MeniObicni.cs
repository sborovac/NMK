using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    public partial class MeniObicni : Form
    {
        public MeniObicni()
        {
            InitializeComponent();
        }

        private void registrujPacijenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija r = new Registracija();
            r.ShowDialog();
        }

        private void kreirajKarton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija r = new Registracija();
            r.ShowDialog();
        }

        private void naplata_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naplata n = new Naplata();
            n.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            NMK nmk = new NMK();
            nmk.ShowDialog();

        }

        private void MeniObicni_Load(object sender, EventArgs e)
        {

        }
    }
}
