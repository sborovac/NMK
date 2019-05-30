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
    public partial class GPlacanje : Form
    {
        public GPlacanje()
        {
            InitializeComponent();
        }

        private void Gotovina_Load(object sender, EventArgs e)
        {

        }

        private void Potvrdi_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox1.Text);
            foreach (Pregled p in Klinika.ListaKartona[index - 1].Exam)
            {
                pregledi.AppendText(p.IspisiPregled());
            }
            if (Klinika.ListaPacijenata[index - 1].brojPosjeta > 3)
            {
                double bill, rata;
                bill = Klinika.ListaPacijenata[index - 1].racun - Klinika.ListaPacijenata[index - 1].racun * 0.15;
                Klinika.ListaPacijenata[index - 1].racun = bill;
                IznosUplate.AppendText(Convert.ToString(bill));//   Console.WriteLine("Vas racun {0} iznosi {1} ", ListaPacijenata[index - 1].imeIPrezime, bill);
                rata = Convert.ToDouble(IznosUplate.Text);
                textBox3.AppendText(Convert.ToString(bill - rata)); // Console.WriteLine("Preostalo vam je još {0} da uplatite", bill - rata);
            }
            else
            {

                double uplata;
                IznosUplate.AppendText(Convert.ToString(Klinika.ListaPacijenata[Convert.ToInt32(textBox1.Text) - 1].racun));  //Console.WriteLine("Vas racun {0} iznosi {1} ", ListaPacijenata[index - 1].imeIPrezime, ListaPacijenata[index - 1].racun);
                textBox3.AppendText(Convert.ToString(0));
                // Console.WriteLine("Molim vas uplatite {0}", ListaPacijenata[index - 1].racun);
                uplata = Convert.ToDouble(IznosUplate.Text);
                //textBox2.AppendText(Convert.ToString(uplata));
                Klinika.ListaPacijenata[Convert.ToInt32(textBox1.Text) - 1].racun -= uplata;
            }
        }

        private void IznosUplate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pregledi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transakcija izvršenja");
            this.Hide();
            MeniObicni mo = new MeniObicni();
            mo.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Naplata n = new Naplata();
            n.ShowDialog();
        }
    }
}
