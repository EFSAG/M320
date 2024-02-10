using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_implementation_EfeBoraSaglam
{
    internal class Motor
    {
        // Assoziationen
        private Auto auto;
        private Benzinpumpe benzinpumpe;
        private Anlasser anlasser;

        public void SetBenzinpumpe(Benzinpumpe benzinpumpe)
        {
            this.benzinpumpe = benzinpumpe;
        }

        public void SetAuto(Auto auto)
        {
            this.auto = auto;
        }

        public void SetAnlasser(Anlasser anlasser)
        {
            this.anlasser = anlasser;
        }
        // ende Assoziationen
        public Motor()
        {
            benzinpumpe = new Benzinpumpe();
            anlasser = new Anlasser();
        }
        public void Starten()
        {
            Console.WriteLine("Motor starten");
            benzinpumpe.Pumpen();
            anlasser.Starten();
            Regeln();
        }

        public void Regeln()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
            anlasser.Stoppen();
        }
    }
}
