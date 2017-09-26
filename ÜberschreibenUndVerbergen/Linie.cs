using System;

namespace ÜberschreibenUndVerbergen
{
    public class Linie : Grafik
    {
        public int Länge { get; set; }

        public new int Zeichnen()       // Verbergen der Zeichnen Methode
        {
            Console.WriteLine($"Zeichne Linie in der Farbe {Farbe} mit einer Länge von {Länge}cm.");
            return 7;
        }
    }
}
