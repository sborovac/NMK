using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Karton : IAnamneza
    {
        private string zakljucak;
        private string terapija;
        private List<string> anamneza = new List<string>();
        private Pacijent p;
        private List<Pregled> pr = new List<Pregled>();

        public Karton() { }

        public Karton(string zakljucak, string terapija, List<string> anamneza, Pacijent p, List<Pregled> pre)
        {
            Anamneza = anamneza;
            Terapija = terapija;
            Zakljucak = zakljucak;
            Pacient = p;
            Exam = pre;
        }

        public List<string> Anamneza { get => anamneza; set => anamneza = value; }

        public string Terapija { get => terapija; set => terapija = value; }

        public string Zakljucak { get => zakljucak; set => zakljucak = value; }

        public Pacijent Pacient { get => p; set => p = value; }

        public List<Pregled> Exam { get => pr; set => pr = value; }

        public void DodajAnamnezu(string ana)
        {
            Anamneza.Add(ana);
        }
        public string IspisiKarton() 
        {
            string ispis = "";
            ispis +="Karton od "+ p.Ime+" "+p.Prezime + '\n';
            ispis += "Pacijent " + p.Ime+" "+p.Prezime + "boluje od " + '\n';
            //Console.WriteLine("Karton od {0}: ", p.imeIPrezime);
            //Console.WriteLine("Pacijent {0} boluje od ", p.imeIPrezime);
            foreach (string w in Anamneza)
            {
                ispis += w + '\n';
                //Console.WriteLine("{0}", w);
            }
            if (String.IsNullOrEmpty(Terapija) && String.IsNullOrEmpty(Zakljucak)) return ispis;
            ispis += "Preporučenja terapija je " + Terapija+'\n';
            ispis += "Zaključak doktora " + Zakljucak + '\n';

            //Console.WriteLine("Preporucena terapija {0}", Terapija);
            //Console.WriteLine("Zakljucak doktora {0}", Zakljucak);
            return ispis;
        }
        public void DodajPacijenta(Pacijent pac)
        {
            Pacient = pac;
        }

        public void DodajPregled(Pregled pr)
        {
            Exam.Add(pr);
        }
        public string IspisiAnamnezu() //samo anamnezu ispisujemo, pri svakom pregledu ispisati ce se anamneza pacijenta
        {
            string anamneza = "Anamneza pacijenta: "+'\n';
            foreach (string w in Anamneza)
            {
                anamneza += w + '\n';

            }
            return anamneza;
        }
    }
}
