using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Pregled
    {
        private string vrstaPregleda;
        private Ordinacije ordinacija;
        private Doktor doktor;
        private DateTime vrijemePregleda;
        private int cijenaPregleda;
        // private string _anamneza;

        public Pregled() { }
        public Pregled(string vrsta, Ordinacije o, Doktor d, DateTime vrijeme, int cijena)
        {
            VrstaPregleda = vrsta;
            Ordinacija = o;
            Doc = d;
            VrijemePregleda = vrijeme;
            CijenaPregleda = cijena;
        }

        public int CijenaPregleda { get => cijenaPregleda; set => cijenaPregleda = value; }

        public string VrstaPregleda { get => vrstaPregleda; set => vrstaPregleda = value; }

        public Ordinacije Ordinacija { get => ordinacija; set => ordinacija = value; }

        public Doktor Doc { get => doktor; set => doktor = value; }

        public DateTime VrijemePregleda { get => vrijemePregleda; set => vrijemePregleda = value; }



        public string InfoPregled()
        {
            string ispis = "";
            ispis += VrstaPregleda + " se održava u ordinaciji " + Ordinacija.NazivOrdinacije + " kod doktora " + Doc.ImeIPrezime() + " u " + VrstaPregleda;
            return ispis; //Console.WriteLine("{0} se odrzava u  ordinaciji {1} kod doktora {2} u {3}", VrstaPregleda, Ordinacija.NazivOrdinacije, Doc.ImeIPrezime, VrijemePregleda);
        }

        public string IspisiPregled()
        {
            string ispis = "";
            ispis = VrstaPregleda + " " + CijenaPregleda+'\n';
            return ispis;      
        }
    }
}
