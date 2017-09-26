namespace Vererbung
{
    internal class Lkw : Fahrzeug
    {
        public Lkw(string farbe) : base(farbe)
        { }

        private int maxLadung;
        public int MaxLadung
        {
            get { return maxLadung; }
            set { maxLadung = value; }
        }
    }
}
