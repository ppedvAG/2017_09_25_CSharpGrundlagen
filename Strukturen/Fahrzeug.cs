using System;

namespace Strukturen
{
    internal struct Fahrzeug : IDisposable
    {
        public Fahrzeug(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
        }

        private int geschwindigkeit;
        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set { geschwindigkeit = value; }
        }

        public void Beschleunigen(int dV) => Geschwindigkeit += dV;

        public void Dispose()
        { /* Das Fahrzeug zerstören. */ }

        public override string ToString()
        {
            return "Ein Fahrzeug.";
        }
    }
}
