using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    public class CurrentConditionsDisplay: DisplayElement, Observer
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public void update(float temp, float humid, float press)
        {
            temperature = temp;
            humidity = humid;
            pressure = press;
        }
        public string Display()
        {
            return "Текущие сведения: \n" + temperature + " °C градусов \n" + humidity + " % влажности\n" + pressure + " мм рт.ст. ";
        }
    }
}
