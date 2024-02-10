using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_implementation_EfeBoraSaglam
{
    internal class Auto
    {
        // Assoziationen
        private Motor motor;
        
        public void SetMotor(Motor motor)
        {
            this.motor = motor;
        }
        // ende Assoziationen
        public Auto()
        {
            motor = new Motor();
        }
        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten();
        }
    }
}
