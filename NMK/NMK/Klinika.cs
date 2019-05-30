using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public static class Klinika
    {
        private static List<Pacijent> lpacijenata = new List<Pacijent>();
        private static List<Doktor> ldoktora = new List<Doktor>();
        private static List<Karton> lkartona = new List<Karton>();
        private static List<Ordinacije> lordinacija = new List<Ordinacije>();
        private static List<Zaposleni> lzaposlenih = new List<Zaposleni>();
        //dotati klasu zaposleni , i listu zaposlenih

        public static List<Pacijent> ListaPacijenata { get => lpacijenata; set => lpacijenata = value; }
        public static List<Karton> ListaKartona { get => lkartona; set => lkartona = value; }
        public static List<Ordinacije> ListaOrdinacija { get => lordinacija; set => lordinacija = value; }
        public static List<Doktor> ListaDoktora { get => ldoktora; set => ldoktora = value; }
        public static List<Zaposleni> Lzaposlenih { get => lzaposlenih; set => lzaposlenih = value; }


        public static void DodajZaposlenog(Zaposleni zaposleni)
        {
            Lzaposlenih.Add(zaposleni);
        }

        public static void DodajPacijenta(Pacijent p)
        {
            ListaPacijenata.Add(p);
        }
        public static void DodajKarton(Karton k)
        {
            ListaKartona.Add(k);
        }
        public static void DodajDoktora(Doktor d)
        {
            ListaDoktora.Add(d);
        }
        public static void DodajOrdinacije(Ordinacije o)
        {
            ListaOrdinacija.Add(o);
        }
    }
}
