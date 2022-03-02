using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int note = 0, durchschnitt = 0, schüler = 0;
            string name = null;

            Console.WriteLine("Wie viele Schüler sind in ihrer Klasse?");
            schüler = Convert.ToInt32(Console.ReadLine());

            string[] namen = new string[schüler];

            int[] noten = new int[schüler];

            for (int i = 0; i < schüler; i++)
            {
                Console.WriteLine("Bitte geben sie den Namen des Schülers ein:");
                name = Console.ReadLine();

                namen[i] = name;

                Console.WriteLine("Bitte geben sie die Note des Schülers ein:");
                note = Convert.ToInt32(Console.ReadLine());

                noten[i] = note;

                durchschnitt = durchschnitt + note;

                Console.Clear();
            }

            for (int i = 0; i < schüler; i++)
            {
                Console.Write(namen[i] + ":");
                Console.Write(noten[i]);
                Console.WriteLine();
            }

            Console.WriteLine("\nDer Notendurchschnitt ist: {0}", durchschnitt / schüler);
            Console.WriteLine("Der Notendurchschnitt stellt sich zusammen aus den Noten von {0} Schülern", namen.Length);
        }
    }
}
