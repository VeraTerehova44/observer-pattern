using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
   public interface Subject
    {
        void registerObserver(Observer obr);
        void removeObserver(Observer obr);
        void notifyObserver();


    }
}
