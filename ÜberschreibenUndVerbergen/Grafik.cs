using System;

namespace ÜberschreibenUndVerbergen
{
    public class Grafik
    {
        public string Farbe { get; set; }

        public virtual void Zeichnen()      // virtual -> darf überschrieben werden
        {
            Console.WriteLine($"Zeichne Grafik in der Farbe {Farbe}.");
        }
    }
}
