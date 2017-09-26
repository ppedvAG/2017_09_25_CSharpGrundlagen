using System;

namespace AbstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new Linie(ConsoleColor.Red);
            var k = new Kreis(ConsoleColor.Green);

            VerwendeGrafik(l);
            VerwendeGrafik(k);

            Console.ReadKey();
        }

        private static void VerwendeGrafik(Grafik g)
        {
            g.Zeichnen();
        }
    }
}
