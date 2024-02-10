using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_implementation_EfeBoraSaglam
{
    internal class Benzinpumpe
    {
        // Assoziationen
        private Motor motor;

        public void SetMotor(Motor motor)
        {

            this.motor = motor;
        }
        // ende Assoziationen
        public void Pumpen()
        {
            Console.WriteLine("Pumpen");
        }
    }
}
