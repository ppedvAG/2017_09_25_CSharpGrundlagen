using System;

namespace Vererbung
{
    internal class Fahrzeug
    {
        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
        }
        public Fahrzeug(int geschwindigkeit)
        {
            Geschwindigkeit = geschwindigkeit;
        }
        public Fahrzeug(string farbe, int geschwindigkeit)
            : this(farbe)
        {
            Geschwindigkeit = geschwindigkeit;
        }
        public Fahrzeug(string farbe, int geschwindigkeit, int baujahr)
            : this(farbe, geschwindigkeit)
        {
            Baujahr = baujahr;
        }

        private int geschwindigkeit;
        public int Geschwindigkeit
        {
            get
            {
                return geschwindigkeit;
            }
            set
            {
                if (value > 200)
                    value = 200;

                geschwindigkeit = value;
            }
        }

        private string farbe;
        public string Farbe
        {
            get { return farbe; }
            set
            {
                farbe = value;
            }
        }

        private int baujahr;
        public int Baujahr
        {
            get { return baujahr; }
            set
            {
                if (value >= 1886 && value < DateTime.Now.Year)
                    baujahr = value;
            }
        }

        public void Bremsen(int dV)
        {
            Geschwindigkeit -= dV;
        }

        public void Beschleunigen(int dV)
        {
            Geschwindigkeit += dV;
        }

        /// <summary>
        /// Beschleunigt das Fahrzeug um den übergenen Faktor.
        /// </summary>
        /// <param name="faktor">Die Geschwindigkeitsänderung.</param>
        public void Beschleunigen(double faktor)
        {
            Geschwindigkeit = (int)(Geschwindigkeit * faktor);
        }

        private Motor motor;
        public Motor Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        ~Fahrzeug()
        {
            Console.WriteLine("Das Fahrzeug wurde zerstört.");
        }
    }
}
