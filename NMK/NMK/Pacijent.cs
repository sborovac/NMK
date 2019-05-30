using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public abstract class Pacijent
    {
        private string ime;
        private string prezime;
        public DateTime datumRodjenja;
        public string maticniBroj;
        public string spol;
        public string adresaStanovanja;
        public string bracnoStanje;
        public DateTime datumPrijema;
        public int brojPosjeta;
        public double racun;
        private int idPacijenta;
        private string username;
        private MD5 password; // pri unosu password je isti ko i username
        private string slika;

        public Pacijent() { }

        public Pacijent(string ime,string prezime, DateTime datumRodjenja, string maticniBroj, string spol, string adresaStanovanja, string bracnoStanje, DateTime datumPrijema,int brojPosjeta, int ind)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.maticniBroj = maticniBroj;
            this.spol = spol;
            this.adresaStanovanja = adresaStanovanja;
            this.bracnoStanje = bracnoStanje;
            this.datumPrijema = datumPrijema;
            this.brojPosjeta = brojPosjeta;
            this.IdPacijenta = ind;
            this.username = "P"+ime[0] + prezime;
            this.Kriptovanje(username);

        }

        public int BrojPosjeta { get => brojPosjeta; set => brojPosjeta = value; }

        public DateTime Datum { get => datumRodjenja; set => datumRodjenja = value; }

        public string JMBG { get => maticniBroj; set => maticniBroj = value; }

        public string Spol { get => spol; set => spol = value; }

        public string Adresa { get => adresaStanovanja; set => adresaStanovanja = value; }

        public string Brak { get => bracnoStanje; set => bracnoStanje = value; }

        public DateTime DPrijem { get => datumPrijema; set => datumPrijema = value; }

        public double Racun { get => racun; set => racun = value; }

        public int IdPacijenta { get => idPacijenta; set => idPacijenta = value; }

        public string Ime { get => ime; set => ime = value; }

        public string Prezime { get => prezime; set => prezime = value; }

        public string Slika { get => slika; set => slika = value; }

        private void Kriptovanje(string pass)
        {
            MD5 kod = MD5.Create(pass);
            password = kod;
        }

        public string ImeIPrezime()
        {
            return ime + " " + prezime;
        }
    }
}
