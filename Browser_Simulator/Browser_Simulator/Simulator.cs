using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class Simulator
    {
        private StringStack urlStack = new StringStack(10);

        public void Run()
        {
            while (true)
            {
                Console.Write("Enter a URL (type 'e' to exit): ");
                string input = Console.ReadLine();

                if (input == "e")
                {
                    break;
                }

                urlStack.Push(input);
                Console.WriteLine($"Current Stack: {urlStack.ToString()}");

                BrowseURL(input);
            }
        }

        public void BrowseURL(string url)
        {
            Console.WriteLine($"Loading {url}");
            // Add code to simulate browsing the URL
        }
    }

}
