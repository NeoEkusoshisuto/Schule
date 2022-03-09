using System;

namespace Multidimensionale_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,summe = 1;
            int[,] excel = new int[10,6];

            for (int n = 1; n <= 9; n++)
            {
                Console.Write($"\t{n}");
            }
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                summe = i;
                Console.Write($"{summe}");
                Console.Write($"\t{summe}");
                for (int n = 1; n < 9; n++)
                {

                    summe = summe * i;
                    Console.Write($"\t{summe}");
                    excel[n, i] = summe;

                }
                Console.WriteLine();
            }
        }
    }
}
