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
    public partial class MeniPacient : Form
    {
        public MeniPacient()
        {
            InitializeComponent();
        }

        private void PretragaKartonaPacijenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FKarton fk = new FKarton();
            fk.ShowDialog();
        }

        private void Naplata_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Naplata np = new Naplata();
            np.ShowDialog();          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            NMK nmk = new NMK();
            nmk.ShowDialog();
        }
    }
}
