using System;

namespace ObserverUndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var heizung = new Heizung();
            var heizung1 = new Heizung();
            var heizung2 = new Heizung();
            var heizung3 = new Heizung();
            var kühlung = new Kühlung();

            //var sensor = new Sensor(heizung, kühlung);
            var sensor = new Sensor();
            //sensor.Subscribe(heizung);
            //sensor.Subscribe(heizung1);
            //sensor.Subscribe(heizung2);
            //sensor.Subscribe(heizung3);
            ////sensor.Subscribe(kühlung);
            sensor.TemperaturGeändert += new Action<int>(heizung.NeueTemperatur);
            sensor.TemperaturGeändert += kühlung.NeueTemperatur;
            sensor.TemperaturGeändert += Display;
            Action<int> dis = t => Console.WriteLine($"{t}°C");
            sensor.TemperaturGeändert += dis;
            sensor.TemperaturGeändert += Console.WriteLine;

            sensor.MesseTemeratur(40);
            //sensor.Unsubscribe(kühlung);
            Console.WriteLine("Es wurden 40° gemessen!");
            sensor.TemperaturGeändert += Display;



            // einige Zeit später
            Console.WriteLine();

            sensor.MesseTemeratur(10);

            // einige Zeit später
            Console.WriteLine();

            sensor.MesseTemeratur(21);

            Console.ReadKey();
        }

        private static void Display(int i)
        {
            Console.WriteLine($"Display sagt: {i}°C");
        }
    }
}
