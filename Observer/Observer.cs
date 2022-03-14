using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    public interface Observer
    {
        void update (float temperature, float humidity, float pressure);
    }
}
