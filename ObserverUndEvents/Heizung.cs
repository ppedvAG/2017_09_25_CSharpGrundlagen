using System;

namespace ObserverUndEvents
{
    internal class Heizung : IBeobachter
    {
        private bool istEingeschalten;

        public void NeueTemperatur(int temperatur)
        {
            if (temperatur < 15)
                Einschalten();

            else if (temperatur > 20)
                Ausschalten();
        }

        private void Ausschalten()
        {
            if (istEingeschalten)
            {
                istEingeschalten = false;
                Console.WriteLine("Schalte Heizung aus.");
            }
        }

        private void Einschalten()
        {
            if (!istEingeschalten)
            {
                istEingeschalten = true;
                Console.WriteLine("Schalte Heizung ein.");
            }
        }
    }
}
