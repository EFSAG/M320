using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe_07
{
    internal class Kreis : Figuren
    {
        public double Pi = 3.14;
        public double Radius {  get; set; }
        public Kreis(float x_cordinate, float y_cordinate, string form, float winkel, float laenge, float breite, int idnumber) : base(x_cordinate, y_cordinate, form, winkel, laenge, breite, idnumber)
        {

        }

        public void noeck()
        {
            Console.WriteLine("Ich heisse {0} und habe keine Ecken", Form);
        }
        public void Area()
        {
            Console.WriteLine("Bitte geben Sie den Radius Wert ein:");
            float radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Das ist mein Radius: {0}, also meine Flaeche ist {1}", radius, radius * radius * Pi);
        }
        public override void PrintPosition()
        {
            Console.WriteLine("Das sind meine Koordinaten ({0}/{1}) für die Form: {2}\n\n\n", X_cordinate, Y_cordinate, Form);
        }
        public override void Addwinkel()
        {
            
        }

    }
}
