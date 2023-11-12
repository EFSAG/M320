namespace Browser_Simulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RPNCalculator calculator = new RPNCalculator(10);

            Console.WriteLine("Geben Sie einen RPN-Ausdruck ein (zum Beenden 'q' eingeben):");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                calculator.PerformOperation(input);
            }

            calculator.PrintResult();
        }
    }
}