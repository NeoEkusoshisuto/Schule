using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int note = 0,durchschnitt = 0;
            string name = null;

            string[] namen = new string[20];

            int[] noten = new int[20];

            for (int i = 0; i < 20; i++)
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

            for (int i = 0; i<20;i++)
            {
                Console.Write(namen[i]+":");
                Console.Write(noten[i]);
                Console.WriteLine();
            }

            Console.WriteLine("\nDer Notendurchschnitt ist: {0}", durchschnitt/20);
        }
    }
}
