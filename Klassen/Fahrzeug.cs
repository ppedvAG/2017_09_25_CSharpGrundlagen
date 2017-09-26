using System;

namespace Klassen
{
    internal class Fahrzeug
    {
        private int geschwindigkeit;     // Feld
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

        #region Java Version von Datenkapselung
        //public int GetGeschwindigkeit()
        //{
        //    return geschwindigkeit;
        //}
        //public void SetGeschwindigkeit(int v)
        //{
        //    if (v > 200)
        //        v = 200;

        //    geschwindigkeit = v;
        //}
        #endregion

        private string farbe;
        public string Farbe
        {
            get { return farbe; }
            set
            {
                switch (value)
                {
                    case "Rot":
                    case "Blau":
                    case "Grün":
                    case "Gelb":
                        farbe = value;
                        break;
                    default:
                        farbe = "Ungültig";
                        break;
                }
            }
        }

        private int baujahr;
        public int Baujahr
        {
            get { return baujahr; }
            set
            {
                if(value >= 1886 && value < DateTime.Now.Year)
                baujahr = value;
            }
        }

    }
}
