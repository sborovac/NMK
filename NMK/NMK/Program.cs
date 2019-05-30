using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Doktor doc = new Doktor("Barbara","Cox", "Ortopedija");
            Ordinacije o = new Ordinacije("Ortopedija", true, doc, 1);
            Klinika.DodajDoktora(doc);
            Klinika.DodajOrdinacije(o);
            Doktor doc1 = new Doktor("Lisa","Davis", "Kardiolodija");
            Ordinacije o1 = new Ordinacije("Kardiologija", true, doc1, 1);
            Klinika.DodajDoktora(doc1);
            Klinika.DodajOrdinacije(o1);
            Doktor doc2 = new Doktor("Julie","Watson", "Dermatologija");
            Ordinacije o2 = new Ordinacije("Dermatologija", true, doc2, 1);
            Klinika.DodajDoktora(doc2);
            Klinika.DodajOrdinacije(o2);
            Doktor doc3 = new Doktor("Selma","Borovac", "Internisticka");
            Ordinacije o3 = new Ordinacije("Internisticka", true, doc3, 1);
            Klinika.DodajDoktora(doc3);
            Klinika.DodajOrdinacije(o3);
            Doktor doc4 = new Doktor("Victor","Rodriguez", "ORL");
            Ordinacije o4 = new Ordinacije("ORL", true, doc4, 1);
            Klinika.DodajDoktora(doc4);
            Klinika.DodajOrdinacije(o4);
            Doktor doc5 = new Doktor("Stephen","King", "Oftamologija");
            Ordinacije o5 = new Ordinacije("Oftamologija", true, doc5, 1);
            Klinika.DodajDoktora(doc5);
            Klinika.DodajOrdinacije(o5);
            Doktor doc6 = new Doktor("Johnny","Wood", "Laboratorija");
            Ordinacije o6 = new Ordinacije("Laboratorija", true, doc6, 1);
            Klinika.DodajDoktora(doc6);
            Klinika.DodajOrdinacije(o6);
            Doktor doc7 = new Doktor("Sarah","Russell", "Stomatologija");
            Ordinacije o7 = new Ordinacije("Stomatologija", true, doc7, 1);           
            Klinika.DodajDoktora(doc7);
            Klinika.DodajOrdinacije(o7);
            Zaposleni z1 = new Zaposleni("Konj","Krava","OTehnicar");
            Klinika.DodajZaposlenog(z1);
            Pacijent p = new NormalniPacijent("Lol","lol", DateTime.Now, "15477777", "z", "rhjrhj", "UB", DateTime.Now, 0, 1);
          
            Karton k = new Karton();
            k.DodajAnamnezu("dfkdjhfkdjkfjd");
            k.DodajPacijenta(p);
            Klinika.DodajPacijenta(p);
            Klinika.DodajKarton(k);
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NMK());
        }
    }
}
