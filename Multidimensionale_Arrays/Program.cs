using System;

namespace Multidimensionale_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[,] excel = new int[9,5];

            for (int n = 1; n <= 9; n++)
            {
                Console.Write($"\t{n}");
            }
            Console.WriteLine();
            for (int i=1; i <= 5; i++)
            {
                
                Console.WriteLine($"{i}\t{i}\t{i*i}\t{i*i*i}\t{i*i*i*i}\t{i*i*i*i*i*i}\t{i*i*i*i*i*i*i}\t{i*i*i*i*i*i*i}\t{i*i*i*i*i*i*i*i}\t{i*i*i*i*i*i*i*i*i}");

            }


        }
    }
}
