using System;

namespace HalloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt.");

            string text;
            text = "Mein Text";
            string text1 = "Anderer Text";

            char textZeichen = 'X';

            byte einByte = 255;
            short kleinereZahlen = 13000;
            int zahl = 0;
            ulong großeZahl = 9;
            
            float gleitkomma = 5.8f;
            double gleitkomma2 = 7.9;
            decimal metric = 10.4m;

            bool bedingung = true; // false

            var meinText = "Mein wichtiger Text";


            // Mathematische Opereratoren
            zahl = 8 + 9;
            zahl = 8 - 9;
            zahl = 8 * 9;
            zahl = 13 / 5;  // = 2
            zahl = 14 % 5;  // 4

            zahl = zahl + 6;
            zahl += 6;

            // Vergleichsoperatoren
            bedingung = 7 < 9;
            bedingung = 7 <= 9;
            bedingung = 7 > 9;
            bedingung = 7 >= 9;
            bedingung = 7 == 9;
            bedingung = 7 != 9;
            bedingung = !bedingung;

            // Verknüpfungsoperatoren
            bedingung = 7 < 9 & 7 > 8;
            bedingung = 7 < 9 | 7 > 8;

            bedingung = 7 < 9 && 7 > 8;
            bedingung = 7 < 9 || 7 > 8;

            bedingung = 7 < 9 ^ 7 > 8;

            string input = Console.ReadLine();

            //zahl = Convert.ToInt32(input);
            zahl = int.Parse(input);

            Console.WriteLine(zahl + 9);

            Console.ReadKey();
        }
    }
}
