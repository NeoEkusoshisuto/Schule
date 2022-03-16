using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            int temp = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Geben sie bitte die {i + 1 }te Zahl ein.");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }

        }
}
