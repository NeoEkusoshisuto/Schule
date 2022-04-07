using System;

namespace Methoden___Hotel_Check_In_App
{
    class Program
    {
        public class array
        {
            public static int[] index = new int[] { 0, 1, 2, 3 };
            public static int[] roomNo = new int[] { 45, 23, 3, 32 };
            public static string[] surname = new string[] { "John", "Paul", "George", "Ringo" };
            public static string[] name = new string[] { "Lennon", "MCCartney", "Harrison", "Starr" };
            public static int[] nights = new int[] { 1, 4, 12, 3 };

        }

        static void Main()
        {
            double kosten = 82.46;
            int zn = 0; string znn = null;
            int choose = 0;
            

            Console.WriteLine("Möchten sie nach (1) Nachnamen oder (2) Zimmernummer suchen?");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Geben sie bitte den Nachnamen ein");
                    znn = Console.ReadLine();
                    choose = 1;
                    break;

                case 2:
                    Console.WriteLine("Geben sie bitte die Zimmernummer ein");
                    zn = Convert.ToInt16(Console.ReadLine());
                    choose = 2;
                    break;

                default:

                    break;

            }

            
            
            var data = GetData(zn, znn,choose);
            
            Console.WriteLine($"{"Index",7} |{"Zimmernummer",13} |{"Vorname",9} |{"Nachname",10} |{"Übernachtungen",16} |{"Rechnungsbetrag",17}");
            Console.WriteLine($"{data.Item2,7} |{data.Item3,13} |{data.Item4,9} |{data.Item5,10} |{data.Item6,16} |{kosten * data.Item6,17}");
            Console.WriteLine();



        }

        public static (bool,int,int,string,string,int ) GetData(int zn, string znn,int choose)
        {
            int value = 0;
           
            if (choose == 1)
            { value = Array.IndexOf(array.name, znn); }
            else if (choose == 2)
            { value = Array.IndexOf(array.roomNo, zn); }
            
            
            return (true,array.index[value],array.roomNo[value],array.surname[value],array.name[value],array.nights[value]);
        }
        





            
    }

}
