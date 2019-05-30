using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Doktor: Zaposleni
    {
       
        private string ordinacija;

       

        public Doktor(string ime,string prezime, string ordinacija): base(ime,prezime,"Doktor")
        {          
            
            Ordinacija = ordinacija;           
        }       

        public string Ordinacija { get => ordinacija; set => ordinacija = value; }        

        public string ImeIPrezime()
        {
            return Ime + " " + Prezime;
        }

    }
}
