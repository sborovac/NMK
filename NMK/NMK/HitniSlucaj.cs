using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class HitniSlucaj: Pacijent
    {
        private string prvaPomoc;
        private DateTime vrijemePreseljenja;
        private string uzrok;
        private DateTime vrijemeObdukcije;
        private FKarton karton;

        public HitniSlucaj() { }

        public HitniSlucaj(string ime, string prezime, DateTime datumRodjenja, string maticniBroj, string spol, string adresaStanovanja, string bracnoStanje, DateTime datumPrijema, int brojPosjeta, int id) : base(ime,prezime, datumRodjenja, maticniBroj, spol, adresaStanovanja, bracnoStanje, datumPrijema,brojPosjeta,id)
        {
        }
        public HitniSlucaj(string ime, string prezime, DateTime datumRodjenja, string maticniBroj, string spol, string adresaStanovanja, string bracnoStanje, DateTime datumPrijema, int brojPosjeta, int id,string pp) : base(ime, prezime, datumRodjenja, maticniBroj, spol, adresaStanovanja, bracnoStanje, datumPrijema, brojPosjeta, id)
        {
            PrvaPomoc = pp;
        }

        public HitniSlucaj(string ime,string prezime, DateTime datumr, string jmbg, string spol, string adresa, string brak, DateTime datump,int brojp, int id, string pp, DateTime vsmrti, string suzrok, DateTime vobd) : base(ime, prezime, datumr, jmbg, spol, adresa, brak, datump, brojp, id)
        {
            PrvaPomoc = pp;
            VrijemePreseljenja = vsmrti;
            Uzrok = suzrok;
            VrijemeObdukcije = vobd;

        }

        public string PrvaPomoc { get => prvaPomoc; set => prvaPomoc = value; }

        public DateTime VrijemePreseljenja { get => vrijemePreseljenja; set => vrijemePreseljenja = value; }

        public DateTime VrijemeObdukcije { get => vrijemeObdukcije; set => vrijemeObdukcije = value; }

        public string Uzrok { get => uzrok; set => uzrok = value; }

        public FKarton KartonP { get => karton; set => karton = value; }

        /*public void IspisiSmrtovnicu()
        {
            Console.WriteLine("Pacijent {0} je dana {1} preminuo uslijed {2}. Obdukcija će se obaviti {3}", imeIPrezime, VrijemePreseljenja, Uzrok, VrijemeObdukcije);
        }*/
    }
}
