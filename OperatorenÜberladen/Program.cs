using System;

namespace OperatorenÜberladen
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Bruchzahl(zähler: 3, nenner: 5);
            var b2 = new Bruchzahl(zähler: 7, nenner: 9);

            var ergebnis = b1 * 3;

            Console.Write($"{b1} * {b2} = ");
            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }
    }
}
