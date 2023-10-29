using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe_07
{
    internal class Dreieck:Figuren
    {
        public Dreieck(float x_cordinate, float y_cordinate, string form, float winkel, float laenge, float breite, int idnumber) : base(x_cordinate, y_cordinate, form, winkel, laenge, breite, idnumber)
        {

        }
        public void Threeeck()
        {
            Console.WriteLine("Ich heisse {0} und habe 3 Ecken und habe eine Ecke das 90 Grad ist.", Form);
        }
        public void PrintArea()
        {
            Console.WriteLine("Meine Breite ist {0} und die Laenge ist {1}, also ist meine Flache {2}", Breite, Laenge, Breite * Laenge / 2);
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
