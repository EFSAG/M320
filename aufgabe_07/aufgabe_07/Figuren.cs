using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe_07
{
    internal abstract class Figuren
    {
        public float X_cordinate {get; set;}
        public float Y_cordinate { get; set; }
        public string Form { get; set;}
        public float Winkel { get; set;}
        public float Laenge {  get; set;}
        public float Breite { get; set;}
        protected int IDnumber { get; set;}

        public Figuren(float x_cordinate, float y_cordinate, string form, float winkel, float laenge, float breite, int idnumber)
        {
            X_cordinate = x_cordinate;
            Y_cordinate = y_cordinate;
            Form = form;
            Winkel = winkel;
            Laenge = laenge;
            Breite = breite;
            IDnumber = idnumber;
        }

        public abstract void PrintPosition(); // abstract ist keine Instanz
        public abstract void Addwinkel();
    }
}
