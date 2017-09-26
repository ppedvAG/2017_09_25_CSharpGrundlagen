namespace WertUndReferenztypen
{
    internal class Fahrzeug
    {
        private int geschwindigkeit;
        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set { geschwindigkeit = value; }
        }

        public Fahrzeug Copy()
        {
            return new Fahrzeug
            {
                Geschwindigkeit = this.Geschwindigkeit
            };
        }
    }
}
