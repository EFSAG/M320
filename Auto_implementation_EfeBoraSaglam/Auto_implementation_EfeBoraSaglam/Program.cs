namespace Auto_implementation_EfeBoraSaglam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assoziationen
            Motor motorauto = new Motor();
            Motor motorbenzinpumpe = new Motor();
            Motor motoranlasser = new Motor();
            Auto automotor = new Auto();
            Benzinpumpe benzinpumpemotor = new Benzinpumpe();
            Anlasser anlassermotor = new Anlasser();


            motorauto.SetAuto(automotor);
            motoranlasser.SetAnlasser(anlassermotor);
            motorbenzinpumpe.SetBenzinpumpe(benzinpumpemotor);
            automotor.SetMotor(motorauto);
            benzinpumpemotor.SetMotor(motorbenzinpumpe);
            anlassermotor.SetMotor(motoranlasser);

            // Ende Assoziationen


            // Ausgabe
            Auto auto = new Auto();
            auto.Anlassen();
        }
    }
}