using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Ordinacije
    {
        private string nazivOrdinacije;
        private bool zauzeta;
        private Doktor doktor;
        private int idOrdinacije;
        public int brojCekanja = 0;

        public Ordinacije(string naziv, bool da, Doktor doc, int id)
        {
            NazivOrdinacije = naziv;
            Zauzeta = da;
            DoktorOrdinacije = new Doktor(doc.Ime, doc.Prezime, doc.Ordinacija);
            idOrdinacije = id;
        }
        public string NazivOrdinacije { get => nazivOrdinacije; set => nazivOrdinacije = value; }
        public bool Zauzeta { get => zauzeta; set => zauzeta = value; }
        public Doktor DoktorOrdinacije { get => doktor; set => doktor = value; }

        public void Oslobodi_Ordinaciju()
        {
            this.Zauzeta = false;
        }

      
    }
}
