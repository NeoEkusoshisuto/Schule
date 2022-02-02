using System;

namespace BFT_Multitool_Features
{
    class Program
    {
        static void Man()
        {


            double leitfähigkeit = 0, volt = 0, strom = 0, länge = 0, querschnitt = 0; string material = null;
            bool retry = false, restart = false;

            do
            {
       
           
            do
            {
                Console.WriteLine("Bitte wählen sie nun das Material \n(1) Kupfer \n(2) Gold \n(3) Aluminium \n(4) Silber \n(4) Zink \n(5) Nickel \n(6) Platin \n(7) Zinn \n(0) Anderes");
                double m_auswahl = Convert.ToDouble(Console.ReadLine());
                switch (m_auswahl)
                {
                    case 1:
                            leitfähigkeit = 56; material = "Kupfer";
                        break;

                    case 2:
                            leitfähigkeit = 45.45; material = "Gold";
                        break;

                    case 3:
                            leitfähigkeit = 36; material = "Aluminium";
                        break;

                    case 4:
                            leitfähigkeit = 16; material = "Silber";
                        break;

                    case 5:
                            leitfähigkeit = 16; material = "Zink";
                        break;

                    case 6:
                            leitfähigkeit = 10.5; material = "Nickel";
                        break;

                    case 7:
                            leitfähigkeit = 10.2; material = "Platin";
                        break;

                    case 8:
                            leitfähigkeit = 8.7; material = "Zinn";
                        break;

                    case 0:
                        Console.WriteLine("Geben sie bitte die Leitfähigkeit des Material in Siemens pro Meter bei 20°C an");
                            leitfähigkeit = Convert.ToDouble(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }
            } while (retry == true);
            retry = false;
            Console.Clear();

            do
            {
                Console.WriteLine("Bitte wählen sie den Strom in Ampere aus! \n(1) 2 A \n(2) 4 A \n(3) 10 A \n(4) 13 A \n(5) 16 A \n(6) 20 A \n(7) 25 A \n(8) 32 A \n(9)35 A \n(10) 50 \n(11) 63 A \n(0) Anderes");
                double s_auswahl = Convert.ToDouble((Console.ReadLine()));
                switch (s_auswahl)
                {
                    case 1:
                        strom = 2;
                        break;

                    case 2:
                        strom = 4;
                        break;

                    case 3:
                        strom = 10;
                        break;

                    case 4:
                        strom = 13;
                        break;

                    case 5:
                        strom = 16;
                        break;

                    case 6:
                        strom = 20;
                        break;

                    case 7:
                        strom = 25;
                        break;

                    case 8:
                        strom = 32;
                        break;

                    case 9:
                        strom = 35;
                        break;

                    case 10:
                        strom = 50;
                        break;

                    case 11:
                        strom = 63;
                        break;

                    case 0:
                        strom = Convert.ToDouble(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }
            } while (retry == true);
            retry = false;
            Console.Clear();

            do
            {
                Console.WriteLine("Bitte wählen sie die Spannung in Volt aus! \n(1) 12 V \n(2) 24 V \n(3) 115 V \n(4) 230 V \n(5) 400 V \n(0) Anderes");
                double v_auswahl = Convert.ToDouble((Console.ReadLine()));
                switch (v_auswahl)
                {
                    case 1:
                        volt = 12;
                        break;

                    case 2:
                        volt = 24;
                        break;

                    case 3:
                        volt = 115;
                        break;

                    case 4:
                        volt = 230;
                        break;

                    case 5:
                        volt = 400;
                        break;

                    case 0:
                        volt = Convert.ToDouble(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }
            } while (retry == true);
            retry = false;
            Console.Clear();

            do
            {
                Console.WriteLine("Bitte wählen sie die Länge in Meter aus! \n(1) 25m \n(2) 50m \n(0) Anderes");
                double l_auswahl = Convert.ToDouble((Console.ReadLine()));
                switch (l_auswahl)
                {
                    case 1:
                        länge = 25;
                        break;

                    case 2:
                        länge = 50;
                        break;

                    case 0:
                        länge = Convert.ToDouble(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }
            } while (retry == true);
            retry = false;
            Console.Clear();

            do
            {
                Console.WriteLine("Bitte wählen sie den Kabel Querschnitt in mm² aus! \n(1) 0.75 mm² \n(2) 1 mm² \n(3) 1.5 mm² \n(4) 2.5 mm² \n(5) 4 mm² \n(6) 6 mm² \n(7) 10 mm² \n(8) 16 mm² \n(9) 25 mm² \n(10) 35 mm² \n(11) 50 mm² \n(12) 70 mm² \n(13) 90 mm² \n(0) Anderes");
                double q_auswahl = Convert.ToDouble((Console.ReadLine()));
                switch (q_auswahl)
                {
                    case 1:
                        querschnitt = 0.75;
                        break;

                    case 2:
                        querschnitt = 1;
                        break;

                    case 3:
                        querschnitt = 1.5;
                        break;

                    case 4:
                        querschnitt = 2.5;
                        break;

                    case 5:
                        querschnitt = 4;
                        break;

                    case 6:
                        querschnitt = 6;
                        break;

                    case 7:
                        querschnitt = 10;
                        break;

                    case 8:
                        querschnitt = 16;
                        break;

                    case 9:
                        querschnitt = 25;
                        break;

                    case 10:
                        querschnitt = 35;
                        break;

                    case 11:
                        querschnitt = 50;
                        break;

                    case 12:
                        querschnitt = 70;
                        break;

                    case 13:
                        querschnitt = 90;
                        break;

                    case 0:
                        querschnitt = Convert.ToDouble(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }
            } while (retry == true);
            retry = false;
                Console.Clear();

            do
            {
                Console.WriteLine("Sie haben ausgewählt: \n {0} mit einer Leitfähigkeit von {1} S/m \n Stromstärke: {2} Ampere \n Spannung : {3} Volt \n Länge : {4} Meter \n Kabel Querschnitt : {5} mm² \n Sind sie mit diesen Eingaben zu frieden? \n (1) Ja (2) Nein", material, leitfähigkeit, strom,volt, länge,querschnitt);
                double auswahl = Convert.ToDouble(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:

                        break;

                    case 2:
                        restart = true;
                        break;

                    default:
                        Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                        retry = true;
                        Console.Read();
                        break;
                }

            } while (retry == true);
            retry = false;
                Console.Clear();
        }while (restart == true);
            restart = false;


            double spannungsfall = (länge / (leitfähigkeit * querschnitt)) * strom;

            Console.WriteLine("Der Spannungsabfall beträgt {0:N2} Volt oder auch {1:N2} % und bei ihnen kommen somit {2:N2} Volt an \n(Der Spannungsfall kann sich leicht ändern bei anderen Temperaturen als 20°C)", spannungsfall, spannungsfall / (volt / 100), volt - spannungsfall);
            Console.ReadKey();
        }
        }
    }

