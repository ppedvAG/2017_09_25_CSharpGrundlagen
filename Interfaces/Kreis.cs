namespace Interfaces
{
    public class Kreis : Grafik
    {
        public double Radius { get; set; }

        public override void Zeichnen()
        {
            System.Console.WriteLine("O");
        }
    }
}
