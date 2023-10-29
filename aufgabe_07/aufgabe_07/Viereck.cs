using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe_07
{

    internal class Viereck:Figuren
    {
        public Viereck(float x_cordinate, float y_cordinate, string form, float winkel, float laenge, float breite, int idnumber) : base(x_cordinate, y_cordinate, form, winkel, laenge, breite, idnumber)
        {

        }
        public void foureck()
        {
            Console.WriteLine("Ich heisse {0} und habe 4 Ecken.", Form);
        }
        public void PrintArea()
        {
            Console.WriteLine("Meine Breite ist {0} und die Laenge ist {1}, also ist meine Flache {2}", Breite, Laenge, Breite * Laenge);
        }
        public override void Addwinkel()
        {
            Console.WriteLine("{0} ist mein Form und der Winkel war {1}, und jetzt ist es {2}.\n\n\n\n", Form, Winkel, Winkel + 90);
        }
        public override void PrintPosition()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\tDas sind meine Koordinaten für {2} ({0}/{1})", X_cordinate, Y_cordinate, Form);
        }
    }
}