namespace aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            float x_cordinate = 100; // Standardwerte
            float y_cordinate = 100;

            Console.WriteLine("Möchten Sie Koordinaten eingeben? (ja/nein):");
            string antwort = Console.ReadLine().ToLower();

            if (antwort == "ja")
            {
                Console.WriteLine("Bitte geben Sie den x-Koordinatenwert ein:");
                x_cordinate = float.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie den y-Koordinatenwert ein:");
                y_cordinate = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bitte geben Sie den Winkelwert ein:");
            float winkel = float.Parse(Console.ReadLine());


            Console.WriteLine("Bitte geben Sie den Längenwert ein:");
            float laenge = float.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den Breitenwert ein:");
            float breite = float.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den ID-Nummerwert ein:");
            int idnumber = int.Parse(Console.ReadLine()); */
            string[] namen = { "Viereck", "Quadrat", "Dreieck", "Kreis" };


            float[] x_coordinate = new float[namen.Length];

            for (int i = 0; i < x_coordinate.Length; i++)
            {
                Console.WriteLine($"Möchten Sie X-Koordinaten für den Form {namen[i]} eingeben? (ja/nein):");
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "ja")
                {
                    Console.WriteLine($"Bitte geben sie den x-Koordinatenwert für die Form {namen[i]}");
                    x_coordinate[i] = float.Parse(Console.ReadLine());
                }
                else
                {
                    x_coordinate[i] = 100; 
                }
            }
            float[] y_coordinate = new float[namen.Length];

            for (int i = 0; i < y_coordinate.Length; i++)
            {
                Console.WriteLine($"Möchten Sie Y-Koordinaten für den Form {namen[i]} eingeben? (ja/nein):");
                string antwort = Console.ReadLine().ToLower();
                if (antwort == "ja")
                {
                    Console.WriteLine($"Bitte geben sie den y-Koordinatenwert für die Form {namen[i]}");
                y_coordinate[i] = float.Parse(Console.ReadLine());
                }
                else
                {
                    y_coordinate[i] = 100;
                }
            }

            float[] winkel = new float[namen.Length];

            for (int i = 0; i < winkel.Length; i++)
            {
                Console.WriteLine($"Bitte geben sie den winkel für die Form {namen[i]}");
                winkel[i] = float.Parse(Console.ReadLine());
            }

            float[] laenge = new float[namen.Length];

            for (int i = 0; i < laenge.Length; i++)
            {
                Console.WriteLine($"Bitte geben sie die laenge für die Form {namen[i]}");
                laenge[i] = float.Parse(Console.ReadLine());
            }


            float[] breite = new float[namen.Length];

            for (int i = 0; i < breite.Length; i++)
            {
                Console.WriteLine($"Bitte geben sie die Breite für die Form {namen[i]}");
                breite[i] = float.Parse(Console.ReadLine());
            }

            int[]  idnumber= new int[namen.Length];

            for (int i = 0; i < idnumber.Length; i++)
            {
                Console.WriteLine($"Bitte geben sie den ID für die Form {namen[i]}");
                idnumber[i] = int.Parse(Console.ReadLine());
            }

            Viereck viereck1 = new Viereck(x_coordinate[0], y_coordinate[0], namen[0], winkel[0], laenge[0], breite[0], idnumber[0]);
            Kreis kreis1 = new Kreis(x_coordinate[3], y_coordinate[3], namen[3], winkel[3], laenge[3], breite[3], idnumber[3]);
            Dreieck dreieck1 = new Dreieck(x_coordinate[1], y_coordinate[1], namen[1], winkel[1], laenge[1], breite[1], idnumber[1]);
            Quadrat quadrat1 = new Quadrat(x_coordinate[2], y_coordinate[2], namen[2], winkel[2], laenge[2], breite[2], idnumber[2]);
            viereck1.foureck();
            viereck1.PrintArea();
            viereck1.Addwinkel();


            dreieck1.Threeeck();
            dreieck1.PrintArea();
            dreieck1.Addwinkel();
            dreieck1.PrintPosition();
            kreis1.PrintPosition();

            quadrat1.foursameeck();
            quadrat1.Area();
            quadrat1.Addwinkel();
            quadrat1.PrintPosition();


            kreis1.noeck();
            kreis1.Area();
            kreis1.Addwinkel();
            viereck1.PrintPosition();
        }
    }
}