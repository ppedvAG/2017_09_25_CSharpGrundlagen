using System;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //var eingabe = int.Parse(Console.ReadLine());

            #region IF ElseIf Else
            //if (eingabe > 10)
            //    Console.WriteLine("Die Eingabe war größer als 10.");
            //else if (eingabe > 5)
            //    Console.WriteLine("Die Eingabe war größer als 5.");
            //else
            //    Console.WriteLine("Die Eingabe war nicht größer als 5.");
            #endregion

            #region Switch

            //switch (eingabe)
            //{
            //    case 17:
            //        Console.WriteLine("Der Wert war 17.");
            //        break;

            //    case 20:
            //        Console.WriteLine("jetzt 20");
            //        break;

            //    case 1:
            //    case 2:     // Fallthrough
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Der Wert war 1, 2, 3 oder 4");
            //        break;

            //    default:
            //        Console.WriteLine("Kein vorheriger Case ist eingetreten.");
            //        break;
            //}

            #endregion

            #region While Schleife
            //while (eingabe < 100)
            //{
            //    eingabe++;

            //    if (eingabe == 50)
            //        break;

            //    if (eingabe == 45)
            //        continue;

            //    Console.WriteLine(eingabe);
            //}
            #endregion

            #region Do While Schleife
            //do
            //{
            //    Console.WriteLine(eingabe++);
            //}
            //while (eingabe < 100);
            #endregion

            for(int i = 100; i > 0; i--)
            {
                Console.WriteLine($"mein Text {i} anderer Text");   // string Interpolation -> ab 2015
            }
            // for  
            // forr


            Console.ReadKey();
        }
    }
}
