using System;

namespace ObserverUndEvents
{
    internal class Kühlung : IBeobachter
    {
        private bool istEingeschalten;

        public void NeueTemperatur(int temperatur)
        {
            if (temperatur > 30)
                Einschalten();

            else if (temperatur < 23)
                Ausschalten();
        }

        private void Ausschalten()
        {
            if(istEingeschalten)
            {
                istEingeschalten = false;
                Console.WriteLine("Schalte Kühlung aus.");
            }
        }

        private void Einschalten()
        {
            if (!istEingeschalten)
            {
                istEingeschalten = true;
                Console.WriteLine("Schalte Kühlung ein.");
            }
        }
    }
}
