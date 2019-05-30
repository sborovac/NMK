using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class NormalniPacijent: Pacijent
    {
        private Karton karton;

        public NormalniPacijent() { }

        public NormalniPacijent(string ime,string prezime, DateTime datumr, string jmbg, string spol, string adresa, string brak, DateTime datump,Karton k, int bp)
        {
            Ime = ime;
            Prezime = prezime;
            Datum = datumr;
            JMBG = jmbg;
            Spol = spol;
            Adresa = adresa;
            Brak = brak;
            DPrijem = datump;           
            Karton = k;       
            BrojPosjeta = bp;

        }

        public NormalniPacijent(string ime,string prezime, DateTime datumRodjenja, string maticniBroj, string spol, string adresaStanovanja, string bracnoStanje, DateTime datumPrijema,int brojPosjeta, int id) : base(ime, prezime, datumRodjenja, maticniBroj, spol, adresaStanovanja, bracnoStanje, datumPrijema,brojPosjeta,id)
        {

        }

        public Karton Karton { get => karton; set => karton = value; }

        public void DodajKarton(Karton k)
        {
            Karton = k;
        }
    }
}
