using System;

namespace TestResultat
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Übung 1

            //Console.Write("Bitte geben Sie ein Testergebnis ein: ");
            //var eingabe = int.Parse(Console.ReadLine());

            //if(eingabe >= 7)
            //    Console.WriteLine("Der Test wurde bestanden.");
            //else
            //    Console.WriteLine("Der Test wurde leider nicht bestanden.");

            //Console.ReadKey();
            #endregion

            #region Übung 2

            //while (true)
            //{
            //    Console.Write("Bitte geben Sie ein Testergebnis ein (Beenden -1): ");
            //    var eingabe = int.Parse(Console.ReadLine());

            //    if (eingabe == -1)
            //        break;

            //    if (eingabe >= 7 && eingabe <= 10)
            //        Console.WriteLine("Der Test wurde bestanden.");
            //    else if (eingabe <= 6 && eingabe >= 0)
            //        Console.WriteLine("Der Test wurde leider nicht bestanden.");
            //    else
            //        Console.WriteLine("Ungültige Eingbe.");

            //    Console.WriteLine();
            //}
            #endregion

            #region Übung 3

            while (true)
            {
                Console.Write("Bitte geben Sie ein Testergebnis ein (Beenden -1): ");
                var eingabe = Console.ReadLine();

                switch (eingabe)
                {
                    case "-1": return;

                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                        Console.WriteLine("Der Test wurde leider nicht bestanden.");
                        break;

                    case "7":
                        Console.WriteLine("Genügend");
                        break;

                    case "8":
                        Console.WriteLine("Befriedigend");
                        break;

                    case "9":
                        Console.WriteLine("Gut");
                        break;

                    case "10":
                        Console.WriteLine("Sehr Gut");
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
            }

            #endregion
        }
    }
}
