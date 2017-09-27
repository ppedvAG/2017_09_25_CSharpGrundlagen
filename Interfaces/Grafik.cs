namespace Interfaces
{
    public abstract class Grafik : ILackierbar
    {
        public string Farbe { get; set; }

        public abstract void Zeichnen();
    }
}