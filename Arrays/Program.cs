using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int note, schüler;
            double notensumme = 0;
            string name;

            Console.WriteLine("Wie viele Schüler sind in ihrer Klasse?");
            schüler = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[] namen = new string[schüler];

            int[] noten = new int[schüler];

            for (int i = 0; i < schüler; i++)
            {
                Console.WriteLine("Bitte geben sie den Namen des Schülers ein:");
                name = Console.ReadLine();

                namen[i] = name;

                Console.WriteLine($"Bitte geben sie die Note von {name} ein:");
                note = Convert.ToInt32(Console.ReadLine());

                noten[i] = note;

                notensumme = notensumme + note;

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
