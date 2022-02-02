﻿using System;
using System.Threading;

namespace SAS_Schleifen
{
    class Program
    {
        #region Main
        static void Main()
        {
            

            Console.WriteLine("SAS Schleifen (Arbeitsaufgabe ausgeteilt am 26.01.2022 13:27 Uhr | zu bearbeiten bis 02.02.2022 12:55 Uhr \n \n \n");

            Console.WriteLine("Welche Aufgabe möchten sie aufrufen? (es gibt 10 Aufgaben)");
            string aufgaben = Console.ReadLine();
            switch (aufgaben)
            {
                case "1":
                    SAS_Schleifen.Program.Aufgabe_1();
                    break;

                case "2":
                    SAS_Schleifen.Program.Aufgabe_2();
                    break;

                case "3":
                    SAS_Schleifen.Program.Aufgabe_3();
                    break;

                case "4":
                    SAS_Schleifen.Program.Aufgabe_4();
                    break;

                case "5":
                    SAS_Schleifen.Program.Aufgabe_5();
                    break;

                case "6":
                    SAS_Schleifen.Program.Aufgabe_6();
                    break;

                case "7":
                    SAS_Schleifen.Program.Aufgabe_7();
                    break;

                case "8":
                    SAS_Schleifen.Program.Aufgabe_8();
                    break;

                case "9":
                    SAS_Schleifen.Program.Aufgabe_9();
                    break;

                case "10":
                    SAS_Schleifen.Program.Aufgabe_10();
                    break;

            }
        }
        #endregion



        #region Aufgabe 1
        static void Aufgabe_1()
        {
            

            for (int i = 50; i >= 0; i--)
            {

                Console.WriteLine(i);
                Thread.Sleep(1000);

            }


            

        }
        #endregion

        #region Aufgabe 2
        static void Aufgabe_2()
        {
        
            for (int i = 0;i <= 50;i++ )
            {

                Console.WriteLine("Ich muss immer meine Hausaufgaben machen ({0})",i);

            }



        }
        #endregion

        #region Aufgabe 3
        static void Aufgabe_3()
        {

            for (int i = 1;i <= 10;i++)
            {

                Console.WriteLine("Das Quadrat von {0} ist {1}", i, i * i);

            }

        }
        #endregion

        #region Aufgabe 4
        static void Aufgabe_4()
        {

            for (int i = 100; i >= 10; i = i-10)
            {

                Console.Write("{0},",i);

            }

        }
        #endregion

        #region Aufgabe 5
        static void Aufgabe_5()
        {
            int i = 0, n = 0;

            Console.WriteLine("Geben sie bitte eine Zahl ein.");
            i = Convert.ToInt32(Console.ReadLine());
            n = i * -1;
            for (; n <= i; n = n + 2)
            {

                Console.Write("{0},",n);

            }

        }
        #endregion

        #region Aufgabe 6
        static void Aufgabe_6()
        {
            int auswahl = 0;
            do
            {
                Console.WriteLine("Wählen sie etwas aus diesem wunderbaren Auswahlmenü \n(1) Auswahlmöglichkeit \n(2) Sehr interessante Auswahlmöglichkeit \n(3) Google \n(4) [Hier könnte ihre Werbung stehen] \n(0) exit");
                auswahl = Convert.ToInt32(Console.ReadLine());
                switch(auswahl)
                {

                    case 1:
                        Console.WriteLine("Hier gibt es nix zu sehen ist nur n Platzhalter");
                        break;
                    case 2:
                        Console.WriteLine("Ich hab keine Idee was ich hier mache");
                        break;
                    case 3:
                        System.Diagnostics.Process.Start("explorer.exe","https://www.google.com");
                        break;
                    case 4:
                        System.Diagnostics.Process.Start("explorer.exe","https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.getshirts.de%2Findex.php%3Fpage%3Dartikel%26id%3D364447&psig=AOvVaw0ygkISoEXQM4OkCWbClber&ust=1643865003322000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCOin6sWg4PUCFQAAAAAdAAAAABAD");
                        break;
                    case 0:
                        Console.WriteLine("Sie haben die Auswahl erfolgreich beendet");
                        break;
                }

            }
            while (auswahl != 0);
        }
        #endregion

        #region Aufgabe 7
        static void Aufgabe_7()
        {
            int n = 0,i = 0,z = 0;

            Console.WriteLine("Geben sie bitte eine Zahl ein");

            for (n = Convert.ToInt32(Console.ReadLine()); n >= i; i++)
            {
                z = z + i;
            }
            Console.WriteLine("Die Summe der Zahlen von 0 bis {0} ist {1}", n, z);
        }
        #endregion

        #region Aufgabe 8
        static void Aufgabe_8()
        {
            int pin = 0, counter = 0;
            do
            {

                Console.WriteLine("Bitte geben sie die PIN ein.");
                pin = Convert.ToInt32(Console.ReadLine());
                counter++;

            }
            while (pin != 1234);

            Console.WriteLine("Sie haben {0} Versuche benötigt um die PIN richtig einzugeben.", counter);
        }
        #endregion

        #region Aufgabe 9
        static void Aufgabe_9()
        {
            int jahre = 0;
            double k = 0, p = 0, s = 0;

            Console.WriteLine("Bitte geben sie das Kapital auf ihrem Konto ein");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie bitte den Zinssatz in Prozent ein");
            p = Convert.ToDouble(Console.ReadLine());
            p = p / 100;

            for (s = 0 + k; s < k*2;)
            {
                s = s + (s * p);
                jahre++;

            }
            Console.WriteLine("Es dauert {0} Jahre bis sich das zurzeit bestehende Kapital auf ihrem Konto verdoppelt hat",jahre);

        }
        #endregion

        #region Aufgabe 10
        static void Aufgabe_10()
        {



        }
        #endregion

    }
}
