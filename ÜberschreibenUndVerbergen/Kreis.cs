using System;

namespace ÜberschreibenUndVerbergen
{
    public class Kreis : Grafik
    {
        public double Radius { get; set; }

        public override void Zeichnen()     // Überschreiben der Zeichnen Methode
        {
            Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe} mit einem Radius von {Radius}cm.");
        }

        public override string ToString()
        {
            return $"Ein Kreis mit Radius {Radius}";
        }
    }
}
