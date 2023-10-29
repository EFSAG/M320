using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wasserfass_EfeBoraSaglam
{
    internal class Wasserfass
    {
        private float MinimalePegelinLiter = 0;
        private float MaximalePegelinLiter = 500;
        public float FüllstandinLiter = 222;
        public float KapazitatinLiter = 505;
        public string Bauform = "Wurfel";
        public string Farbe = "Weiss";
        public string Baumaterial = "Plastik";
        public string Standort = "St.Gallen";

        public void befullen()
        {

            double menge;
            Console.Write("Geben sie den Liter betrag den sie ins Wasserfass befüllen möchten ein: ");
            menge = float.Parse(Console.ReadLine());
            if (menge > 278)
            {
                Console.WriteLine("Im Wasserfass gibt es leider nicht so viel Platz.");
            }
            else
            {
                Console.WriteLine("Dein Füllstand ist jetzt: {0}", menge + FüllstandinLiter);
            }
        }

        public void entnehmen()
        {
            double menge;
            Console.Write("Geben sie den Liter betrag den sie ins Wasserfass entehmen möchten ein: ");
            menge = float.Parse(Console.ReadLine());
            if (menge > 222)
            {
                Console.WriteLine("Im Wasserfass gibt es nicht so viel Water");
            }
            else
            {
                Console.WriteLine("Dein Füllstand ist jetzt: {0}", menge + FüllstandinLiter);
            }
        }
        public void entleeren()
        {
            Console.WriteLine("Du hast jetzt {0} Liter Wasser in Wasserfass", FüllstandinLiter - FüllstandinLiter);
        }
        public void infos()
        {
            Console.WriteLine("Bauform: {0}\n\nFarbe: {1}\n\nBaumaterial: {2}\n\nStandort: {3}\n\n", Bauform, Farbe, Baumaterial, Standort);
        }
        public void first()
        {
            Console.WriteLine("{0} ist dein minimale Pegel.\n {1} ist dein max Pegel.\n Dein Füllstand ist {2} Liter\n\n", MinimalePegelinLiter, MaximalePegelinLiter, FüllstandinLiter);
        }
    }
}
