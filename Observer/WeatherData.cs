using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    public class WeatherData: Subject
    {
        private List<Observer> observer;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observer = new List<Observer>();
        }
        public void notifyObserver()
        {
            foreach (var obr in observer)
            {
                obr.update(temperature, humidity, pressure);
            }
        }
        public void registerObserver(Observer obr)
        {
            this.observer.Add(obr);
        }
        public void removeObserver(Observer obr)
        {
            this.observer.Remove(obr);
        }
        public void MeasurementsChanged()
        {
            notifyObserver();
        }
        public void SetTemperature(float temp)
        {
            temperature = temp;
            MeasurementsChanged();
        }
        public void SetHumidity(float humid)
        {

            humidity = humid;
            MeasurementsChanged();

        }
        public void SetPressure(float press)
        {
            pressure = press;
            MeasurementsChanged();
        }

    }
}
