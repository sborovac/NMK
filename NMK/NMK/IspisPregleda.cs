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
    public partial class IspisPregleda : Form
    {
        public IspisPregleda()
        {
            InitializeComponent();
        }

        private void Potvrdi_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(idPacijenta.Text);
            foreach (Pregled p in Klinika.ListaKartona[index - 1].Exam)
                PreglediPacijenta.AppendText(p.InfoPregled());
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniPacient mp = new MeniPacient();
            mp.ShowDialog();
        }
    }
}
