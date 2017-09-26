using System;

namespace ÜberschreibenUndVerbergen
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Grafik();
            g.Farbe = "Blau";
            g.Zeichnen();

            var l = new Linie();
            l.Farbe = "Rot";
            l.Länge = 7;
            int x = l.Zeichnen();

            var k = new Kreis();
            k.Farbe = "Grün";
            k.Radius = 2.12;
            k.Zeichnen();

            Console.WriteLine("\n\n");
            VerwendeEineGrafik(g);
            VerwendeEineGrafik(l);      // Zeichnen verborgen
            VerwendeEineGrafik(k);      // Zeichnen überschrieben

            Console.WriteLine(k);

            Console.ReadKey();
        }

        private static void VerwendeEineGrafik(Grafik g)
        {
            g.Zeichnen();
        }
    }
}
