using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData sub = new WeatherData();

            CurrentConditionsDisplay cd = new CurrentConditionsDisplay();
            StatisticsDisplay sd = new StatisticsDisplay();
            ForecastDisplay fd = new ForecastDisplay();

            sub.registerObserver(cd);
            sub.registerObserver(sd);
            sub.registerObserver(fd);

            sub.SetTemperature(20);
            sub.SetPressure(760);
            sub.SetHumidity(40);

            Console.WriteLine(cd.Display());
            Console.WriteLine();
            Console.WriteLine(sd.Display());
            Console.WriteLine();
            Console.WriteLine(fd.Display());
            Console.WriteLine();

            sub.SetTemperature(12);
            sub.SetPressure(780);
            sub.SetHumidity(80);

            Console.WriteLine(cd.Display());
            Console.WriteLine();
            Console.WriteLine(sd.Display());
            Console.WriteLine();
            Console.WriteLine(fd.Display());

            sub.removeObserver(fd);

            Console.ReadKey();
        }
    }
}
