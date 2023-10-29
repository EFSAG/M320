using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe_07
{
    internal class Quadrat: Figuren
    {
        public float Seite {  get; set; }
        public Quadrat(float x_cordinate, float y_cordinate, string form, float winkel, float laenge, float breite, int idnumber) : base(x_cordinate, y_cordinate, form, winkel, laenge, breite, idnumber)
        {

        }
        public void foursameeck()
        {
            Console.WriteLine("Ich heisse {0} und habe 4 Ecken, aber alle sind gleich gross.", Form);
        }
        public void Area()
        {
            Console.WriteLine("Bitte geben Sie die Seitenlänge ein:");
            int seite = int.Parse(Console.ReadLine());
            Console.WriteLine($"Das ist meine Seite{seite} also ist meine Flaeche {seite * seite}");
        }
        public override void Addwinkel()
        {
            Console.WriteLine("{0} ist mein Form und der Winkel war {1}, und jetzt ist es {2}.", Form, Winkel, Winkel + 90);
        }
        public override void PrintPosition()
        {
            Console.WriteLine("Das sind meine Koordinaten ({0}/{1})\n\n\n\n", X_cordinate, Y_cordinate);
        }
    }
}
