using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
   public class ConcreteObserver : Observer
    {
        int count = 0;
        public int Count { get { return count; } }
        public void update(Subject sb)
        {
            count++;
        }
    }
}
