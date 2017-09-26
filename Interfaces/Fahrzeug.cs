using System;
using System.Collections;

namespace Interfaces
{
    public class Fahrzeug : ILackierbar, ICloneable
    {
        public string Farbe { get; set; }
        public int Geschwindigkeit { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
