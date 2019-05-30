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
    public partial class RPlacanje : Form
    {
        public RPlacanje()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void iznosUplate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void idnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pregledi_Enter(object sender,EventArgs e)
        {

        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void RPlacanje_Load(object sender, EventArgs e)
        {

        }

        private void Potvrdi_Click(object sender, EventArgs e)
        {
            int indeks = Convert.ToInt32(idnumber.Text);
            foreach (Pregled p in Klinika.ListaKartona[indeks - 1].Exam)
            {
                checkup.AppendText(p.IspisiPregled());
            }
            //int indeks = Convert.ToInt32(idnumber.Text);
            if (Klinika.ListaPacijenata[indeks - 1].brojPosjeta < 3)
            {

                double uplata;
                IznosUplate.AppendText(Convert.ToString(Klinika.ListaPacijenata[indeks - 1].racun)); //Console.WriteLine("Vas racun {0} iznosi {1} ", ListaPacijenata[index - 1].imeIPrezime, ListaPacijenata[index - 1].racun);
                                                                                                     // Uplata.AppendText(Convert.ToString(0));
                ostatak.AppendText(IznosUplate.Text);// Console.WriteLine("Molim vas uplatite {0}", ListaPacijenata[index - 1].racun);
                uplata = Convert.ToDouble(IznosUplate.Text);
                Klinika.ListaPacijenata[indeks - 1].racun -= uplata;
            }

            else
            {
                double bill, rata;
                bill = Klinika.ListaPacijenata[indeks - 1].racun - Klinika.ListaPacijenata[indeks - 1].racun * 0.15;
                Klinika.ListaPacijenata[indeks - 1].racun = bill;
                IznosUplate.AppendText(Convert.ToString(bill));//   Console.WriteLine("Vas racun {0} iznosi {1} ", ListaPacijenata[index - 1].imeIPrezime, bill);
                rata = Convert.ToDouble(IznosUplate.Text);
                ostatak.AppendText(Convert.ToString(bill - rata));
                Klinika.ListaPacijenata[indeks - 1].racun = bill - rata; // Console.WriteLine("Preostalo vam je još {0} da uplatite", bill - rata);
            }

        }

        private void Potvrda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješna Transakcija");
            this.Hide();
            MeniObicni mo = new MeniObicni();
            mo.ShowDialog();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naplata n = new Naplata();
            n.ShowDialog();
        }
    }
}
