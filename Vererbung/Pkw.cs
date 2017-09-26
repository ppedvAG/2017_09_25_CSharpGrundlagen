namespace Vererbung
{
    internal class Pkw : Fahrzeug
    {

        public Pkw(string farbe) : base(farbe)
        {
        }

        private int sitzplätze;
        public int Sitzplätze
        {
            get { return sitzplätze; }
            set { sitzplätze = value; }
        }
    }
}
