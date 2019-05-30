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
    public partial class RegistracijaPregleda : Form
    {
        public RegistracijaPregleda()
        {
            InitializeComponent();
        }

        private void PotvrdiPregled_Click(object sender, EventArgs e)
        {
            int vel = Convert.ToInt32(ind.Text);
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox chb = c as CheckBox;
                if (!chb.Checked) continue;
                else
                {
                    if (chb.Text == "Ortopedski Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Ortopedski Pregled", Klinika.ListaOrdinacija[0], Klinika.ListaDoktora[0], DateTime.Now, 100));
                        Klinika.ListaPacijenata[vel - 1].racun += 100;
                        break;
                    }
                    else if (chb.Text == "Kardiološki Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Kardiološki Pregled", Klinika.ListaOrdinacija[1], Klinika.ListaDoktora[1], DateTime.Now, 50));
                        Klinika.ListaPacijenata[vel - 1].racun += 50;
                        break;
                    }
                    else if (chb.Text == "Dermatološki Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Dermatološki Pregled", Klinika.ListaOrdinacija[2], Klinika.ListaDoktora[2], DateTime.Now, 250));
                        Klinika.ListaPacijenata[vel - 1].racun += 250;
                        break;
                    }
                    else if (chb.Text == "Internistički Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Internistički Pregled", Klinika.ListaOrdinacija[3], Klinika.ListaDoktora[3], DateTime.Now, 150));
                        Klinika.ListaPacijenata[vel - 1].racun += 150;
                        break;
                    }
                    else if (chb.Text == "ORL Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("ORL Pregled", Klinika.ListaOrdinacija[4], Klinika.ListaDoktora[4], DateTime.Now, 50));
                        Klinika.ListaPacijenata[vel - 1].racun += 50;
                        break;
                    }
                    else if (chb.Text == "Oftamološki Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Oftamološki Pregled", Klinika.ListaOrdinacija[5], Klinika.ListaDoktora[5], DateTime.Now, 350));
                        Klinika.ListaPacijenata[vel - 1].racun += 350;
                        break;
                    }
                    else if (chb.Text == "Laboratorijski Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Laboratorija", Klinika.ListaOrdinacija[6], Klinika.ListaDoktora[6], DateTime.Now, 150));
                        Klinika.ListaPacijenata[vel - 1].racun += 150;
                        break;
                    }
                    else if (chb.Text == "Stomatološki Pregled")
                    {
                        Klinika.ListaKartona[vel - 1].DodajPregled(new Pregled("Stomatološki Pregled", Klinika.ListaOrdinacija[7], Klinika.ListaDoktora[7], DateTime.Now, 60));
                        Klinika.ListaPacijenata[vel - 1].racun += 60;
                        break;
                    }
                }
            }
            foreach (Pregled p in Klinika.ListaKartona[vel - 1].Exam)
                MessageBox.Show(p.InfoPregled());
            this.Hide();
            MeniDoc md = new MeniDoc();
            md.ShowDialog();
        }
        

        private void RegistracijaPregleda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniDoc md = new MeniDoc();
            md.ShowDialog();
        }
    }
}
