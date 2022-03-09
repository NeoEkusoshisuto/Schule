using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int schüler;
            double notensumme = 0;

            Console.WriteLine("Wie viele Schüler sind in ihrer Klasse?");
            schüler = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[] namen = new string[schüler];

            int[] noten = new int[schüler];

            for (int i = 0; i < schüler; i++)
            {
                Console.WriteLine("Bitte geben sie den Namen des Schülers ein:");
                namen[i] = Console.ReadLine();

                Console.WriteLine($"Bitte geben sie die Note von {namen[i]} ein:");
                noten[i] = Convert.ToInt32(Console.ReadLine());

                notensumme = notensumme + noten[i];

                Console.Clear();
            }

            for (int i = 0; i < schüler; i++)
            {
                Console.WriteLine(namen[i] + ":" + noten[i]); 
            }

            Console.WriteLine($"\nDer Notendurchschnitt ist: {notensumme / schüler:F2}");
            Console.WriteLine($"Der Notendurchschnitt stellt sich zusammen aus den Noten von {namen.Length} Schülern");
        }
    }
}
