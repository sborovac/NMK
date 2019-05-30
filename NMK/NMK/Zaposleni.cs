using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Zaposleni
    {
        private string ime;
        private string prezime;
        private string username;
        private MD5 password;
        private string zaposljenje;

        public Zaposleni(string ime, string prezime,string zaposljenje)
        {
            Ime = ime;
            Prezime = prezime;
            username = zaposljenje[0]+ime[0]+prezime;
            this.Kriptovanje(username);
            Zaposljenje = zaposljenje;
        }

       

        public string Zaposljenje { get => zaposljenje; set => zaposljenje = value; }

        public string Ime { get => ime; set => ime = value; }

        public string Prezime { get => prezime; set => prezime = value; }

        private void Kriptovanje(string pass)
        {
            MD5 kod = MD5.Create(pass);
            password = kod;
        }
    }
}
