namespace wasserfass_EfeBoraSaglam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserfass wasserfass1 = new Wasserfass();
            do
            {
                wasserfass1.first();
                Console.WriteLine("____________________________________________________________________________________________________\n\n");
                wasserfass1.infos();
                Console.WriteLine("Was möchtest du machen?\n\n befüllen\t entnehmen\t entleeren");
                switch (Console.ReadLine())
                {
                    case "befüllen":
                        wasserfass1.befullen();
                            break;
                    case "entnehmen":
                        wasserfass1.entnehmen();
                            break;
                    case "entleeren":
                        wasserfass1.entleeren();
                        break;
                    default:
                        Console.WriteLine("Gib was richtiges ein");
                        break;
                }
                Console.WriteLine("Wollen Sie weiter machen?\n dann schreibe JA");
            } while (Console.ReadLine().ToUpper() == "JA");
            Console.WriteLine("Tschüss");




        }
    }
}