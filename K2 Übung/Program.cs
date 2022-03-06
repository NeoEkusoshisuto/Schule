using System;

namespace K2_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 0, p = 0,j = 0,b = 0,kz = 0;
             

            Console.Write("Geben sie bitte ihr Kapital ein:\n");
            k = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben sie bitte den Prozentsatz ein:\n");
            p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Über was für einen Zeitraum soll der Zinsrechner laufen:\n");
            j = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0,3} {1,10} {2,8} {3,10} {4,8}", "Jahr", "Guthaben", "Zinsen", "K.Zinsen", "Bilanz");

            for (int i = 0; i <= 43; i++)
            {

                Console.Write("-");

            }

            Console.WriteLine("");

            for (int Jahr = 0; Jahr <= j;Jahr++)
            {
                kz = kz + k * (p / 100);
                b = b + k;
                if (Jahr == j)
                {
                    for (int i = 0; i <= 43; i++)
                    {

                        Console.Write("-");

                    }

                    Console.WriteLine("");

                }
                Console.WriteLine("{0,3}| {1,9:F2,C}| {2,6:F2,C}| {3,8:F2,C}| {4,6:F2,C}", Jahr, k, k * (p/100), kz,b);
                k = k + (k * (p / 100));
            }
        }
        
    }
}
