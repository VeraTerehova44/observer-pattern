using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private double pressure;
        readonly Random rnd = new Random();

        public void update(float temp, float humid, float press)
        {
            temperature = temp * (rnd.Next(2, 10) / 10.0);
            pressure = press * (rnd.Next(9, 12) / 10.0);
            humidity = humid * (rnd.Next(7, 15) / 10.0);
        }
        public string Display()
        {
            return "Текущий прогноз: \n" + temperature + " °C градусов\n" + humidity + " % влажности \n" + pressure + " мм рт.ст.";
        }
    }
}
