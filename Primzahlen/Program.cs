using System;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben sie die untere Grenze ein: ");
            var untereGrenze = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben sie die obere Grenze ein: ");
            var obereGrenze = int.Parse(Console.ReadLine());

            while (untereGrenze <= obereGrenze)
            {
                if (IsPrime(untereGrenze))
                    Console.WriteLine(untereGrenze);

                untereGrenze++;
            }

            Console.ReadKey();
        }

        private static bool IsPrime(int value)
        {
            if (value < 2)
                return false;

            if (value == 2)
                return true;

            for (int i = 2; i <= (value / 2) + 1; i++)
                if (value % i == 0)
                    return false;

            return true;
        }
    }
}
