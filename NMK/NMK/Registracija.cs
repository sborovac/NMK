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
    public partial class Registracija : Form
    {
        string slika;
        public Registracija()
        {
            InitializeComponent();
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabNormalni_Click(object sender, EventArgs e)
        {

        }

        private void NIformation_Enter(object sender, EventArgs e)
        {
          
           
        }



        private void registrujN_Click(object sender, EventArgs e)
        {
            bool ima = false;
            foreach (Pacijent a in Klinika.ListaPacijenata)
            {
                if (jmbgN.Text == a.maticniBroj)
                {
                    ima = true;
                    a.brojPosjeta++;
                    MessageBox.Show("Vas Id broj je " + a.IdPacijenta);

                }
            }
            if (ima == false)
            {
                Klinika.ListaPacijenata.TrimExcess();
                int ind = Klinika.ListaPacijenata.Count;
                string malefemale;
                if (maleN.Checked) malefemale = "male";
                else malefemale = "female";
                Pacijent p = new NormalniPacijent(imeN.Text,prezimeN.Text, datumRodjenjaN.Value, jmbgN.Text, malefemale, adresaN.Text, brakN.Text, datumPrijemaN.Value, 1, ind + 1);
                Klinika.DodajPacijenta(p);
                Karton k = new Karton();
                k.DodajAnamnezu(anamnezaN.Text);
                Klinika.DodajKarton(k);
                Klinika.ListaPacijenata.TrimExcess();
                ind = Klinika.ListaPacijenata.Count;
                Klinika.ListaKartona[ind - 1].Pacient = Klinika.ListaPacijenata[ind - 1];
                MessageBox.Show("Vas Id broj je  " + p.IdPacijenta);
            }
            Klinika.ListaPacijenata.TrimExcess();
            int vel = Klinika.ListaPacijenata.Count;
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox chb = c as CheckBox;
                if (!chb.Checked)  continue; 
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
            Klinika.ListaPacijenata[vel - 1].Slika = slika;
            this.Hide();
            MeniObicni mb = new MeniObicni();
            mb.ShowDialog();
        }

            
        
        private void groupBox1_Enter(object sender, EventArgs e)
        { 
           // Klinika.ListaPacijenata.TrimExcess();
            int index = Klinika.ListaPacijenata.Capacity - 1;
        
        }

        private void pregledi_Enter(object sender, EventArgs e)
        {
           
        }
        
    

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            bool ima = false;
            foreach (Pacijent a in Klinika.ListaPacijenata)
            {
                if (jmbgN.Text == a.maticniBroj)
                {
                    ima = true;
                    a.brojPosjeta++;
                    MessageBox.Show("Vas Id broj je " + a.IdPacijenta);

                }
            }
            if (ima == false)
            {
                Klinika.ListaPacijenata.TrimExcess();
                int ind = Klinika.ListaPacijenata.Count;
                string malefemale;
                if (male.Checked) malefemale = "male";
                else malefemale = "female";
                Pacijent p = new HitniSlucaj(imeN.Text, prezimeN.Text, datumRodjenjaN.Value, jmbgN.Text, malefemale, adresaN.Text, brakN.Text, datumPrijemaN.Value, 0, ind + 1, prvaPomoc.Text, vrijemeSmrti.Value, uzrokSmrti.Text, vrijemeObdukcije.Value);
                Klinika.DodajPacijenta(p);
                Karton k = new Karton();
                k.DodajAnamnezu(anamnezaN.Text);
                Klinika.DodajKarton(k);
                Klinika.ListaPacijenata.TrimExcess();
                ind = Klinika.ListaPacijenata.Count;
                Klinika.ListaKartona[ind - 1].Pacient = Klinika.ListaPacijenata[ind - 1];
                MessageBox.Show("Vas Id broj je  " + p.IdPacijenta);
            }
            Klinika.ListaPacijenata.TrimExcess();
            int vel = Klinika.ListaPacijenata.Count;
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
            Klinika.ListaPacijenata[vel - 1].Slika = slika;
            this.Hide();
            MeniObicni mb = new MeniObicni();
            mb.ShowDialog();
        }

        private void imeN_Validating(object sender, CancelEventArgs e)
        {

        }

        private void jmbgN_Validating(object sender, CancelEventArgs e)
        {
            string porukaGreske;
            if (!ValidMaticniBroj(jmbgN.Text, out porukaGreske))
                e.Cancel = true;
            this.errorProvider1.SetError(jmbgN, porukaGreske);
        }
        private void textBox2_Validated(object sender, EventArgs e)
        {

        }
        private bool ValidMaticniBroj(string maticni, out string poruka)
        {
            if (maticni.Length != 13)
            {
                poruka = "Potrebno je unijeti 13 karaktera.";
                return false;
            }
            poruka = "";
            return true;

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {       
                string porukaGreske;
                if (!ValidMaticniBroj(jmbgN.Text, out porukaGreske))
                    e.Cancel = true;
               this.errorProvider2.SetError(jmbgN, porukaGreske);
            
        }

        private void ucitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog slikaPacijenta = new OpenFileDialog();
            if (slikaPacijenta.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    slikaPacienta.ImageLocation = slikaPacijenta.FileName;
                    slika = slikaPacijenta.FileName;
                    slikaPacienta.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception) { slika = ""; }
            }
        }

        private void ucitajNSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog slikaPacijenta = new OpenFileDialog();
            if (slikaPacijenta.ShowDialog() == DialogResult.OK)
           {
               try
                {
                    slika = slikaPacijenta.FileName;
                    slikaNPacijenta.ImageLocation = slikaPacijenta.FileName;
                    slikaNPacijenta.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception) { slika = ""; }
            }
        }

        private void anamnezaN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
