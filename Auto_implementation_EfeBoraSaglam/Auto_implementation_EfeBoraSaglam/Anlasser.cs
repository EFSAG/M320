using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_implementation_EfeBoraSaglam
{
    internal class Anlasser
    {
        // Assoziationen
        private Motor motor;

        public void SetMotor(Motor motor)
        {
            this.motor = motor;
        }
        // ende Assoziationen
        public void Starten()
        {
            Console.WriteLine("Anlasser gestartet");
        }

        public void Stoppen()
        {
            Console.WriteLine("Anlasser gestoppt");
        }
    }
}
