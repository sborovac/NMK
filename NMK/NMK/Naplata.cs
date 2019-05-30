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
    public partial class Naplata : Form
    {
        public Naplata()
        {
            InitializeComponent();
        }

        private void gotovina_Click(object sender, EventArgs e)
        {
            this.Hide();
            GPlacanje g = new GPlacanje();
            g.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RPlacanje p = new RPlacanje();
            p.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            NMK nmk = new NMK();
            nmk.ShowDialog();
        }

        private void Naplata_Load(object sender, EventArgs e)
        {

        }
    }
}
