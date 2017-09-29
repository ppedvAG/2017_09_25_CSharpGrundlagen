using System;
using System.Collections.Generic;

namespace ObserverUndEvents
{
    internal class Sensor
    {
        //private Heizung heizung;
        //private Kühlung kühlung;

        //public Sensor(Heizung heizung, Kühlung kühlung)
        //{
        //    this.heizung = heizung;
        //    this.kühlung = kühlung;
        //}

        private ICollection<IBeobachter> geräte = new HashSet<IBeobachter>();

        private int letzteTemperatur;
        public event Action<int> TemperaturGeändert
        {
            add
            {
                value?.Invoke(letzteTemperatur);
                _temperaturGeändert += value;
            }
            remove { _temperaturGeändert -= value; }
        }
        private event Action<int> _temperaturGeändert;

        public void MesseTemeratur(int temperatur)
        {
            // Komplexe Logik um die Temperatur zu messen.
            // 0 = 0

            //heizung.NeueTemperatur(temperatur);
            //kühlung.NeueTemperatur(temperatur);


            //var temperaturGeändert = TemperaturGeändert;
            //if (temperaturGeändert != null)
            //    temperaturGeändert(temperatur);
            _temperaturGeändert?.Invoke(temperatur);
            letzteTemperatur = temperatur;

            foreach (var gerät in geräte)
                gerät.NeueTemperatur(temperatur);
        }

        public void Subscribe(IBeobachter gerät) => geräte.Add(gerät);
        public void Unsubscribe(IBeobachter gerät) => geräte.Remove(gerät);
    }
}
