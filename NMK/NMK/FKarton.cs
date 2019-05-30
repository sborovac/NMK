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
    public partial class FKarton : Form
    {
        public FKarton()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kreiraj_Click(object sender, EventArgs e)
        {
                   
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FKarton_Load(object sender, EventArgs e)
        {

        }

        private void Potvrdi_Click(object sender, EventArgs e)
        {
            kreiraj.Visible = false;
            int index = Convert.ToInt32(idPacijenta.Text);
            Karton p = Klinika.ListaKartona[index - 1];
            imeIPrezime.Text = Klinika.ListaKartona[index - 1].Pacient.ImeIPrezime();//Pacient.Ime + " " + Klinika.ListaPacijenata[index - 1].Prezime;
            datumRodjenja.Text = Convert.ToString(Klinika.ListaKartona[index - 1].Pacient.Datum);
            jmbg.Text = Klinika.ListaKartona[index - 1].Pacient.JMBG;
            spol.Text = Klinika.ListaKartona[index - 1].Pacient.Spol;
            lol.Text = Klinika.ListaKartona[index - 1].Pacient.adresaStanovanja;
            bracnoStanje.Text = Klinika.ListaKartona[index - 1].Pacient.Brak;
            datumPrijema.Text = Convert.ToString(Klinika.ListaKartona[index - 1].Pacient.DPrijem);
            anamneza.AppendText(Klinika.ListaKartona[index - 1].IspisiAnamnezu());
            slikaPacijenta.ImageLocation = Klinika.ListaKartona[index - 1].Pacient.Slika;
            slikaPacijenta.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Klinika.ListaKartona[index - 1].Pacient is HitniSlucaj)
            {
                DodatneInfo.Visible = true;
                FirstAid.Visible = true;
                tipPacijenta.Text = "Hitni";
                
            }
            else if (Klinika.ListaKartona[index - 1].Pacient is NormalniPacijent)
            {
                DodatneInfo.Visible = false;
                FirstAid.Visible = false;
                tipPacijenta.Text = "Normalni";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeniObicni mO = new MeniObicni();
            mO.ShowDialog();
        }

        private void newAnamneza_Click(object sender, EventArgs e)
        {
            anamneza.Text = " ";
            anamneza.Visible = false;
            novaAnamneza.Visible = true;
            dodaj.Visible = true;
            newAnamneza.Visible = false;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(idPacijenta.Text);
            Klinika.ListaKartona[index - 1].DodajAnamnezu(novaAnamneza.Text);
            novaAnamneza.Visible = false;
            anamneza.Visible = true;
            anamneza.AppendText(Klinika.ListaKartona[index - 1].IspisiAnamnezu());
            dodaj.Visible = false;
            newAnamneza.Visible = true;

        }
    }
}
