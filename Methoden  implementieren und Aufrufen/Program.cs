using System;

namespace Methoden__implementieren_und_Aufrufen
{
    class Program
    {
        static void Main() 
        { int anzahl;

           anzahl = ausgabeTextMalX();
            
          Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);
          
        }
        
        public static int ausgabeTextMalX()
        {
            

            Console.WriteLine("Welchen Text wollen sie ausgeben lassen?");
            string text = Console.ReadLine();
            
            Console.WriteLine("Wie oft soll der Text ausgegeben werden?");
            int wiederholungen = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<wiederholungen;i++)
            {
                Console.WriteLine(text);
            }

            int buchstaben = text.Length * wiederholungen;

            return buchstaben;
        }
    }
}
