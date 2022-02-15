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
            ConcreteSubject cs = new ConcreteSubject();
            ConcreteObserver co1 = new ConcreteObserver();
            ConcreteObserver co2 = new ConcreteObserver();
            cs.registerObserver(co1);
            cs.State = "1";
            Console.WriteLine(co1.Count);
            Console.WriteLine(co2.Count);
            cs.registerObserver(co2);
            cs.State = "2";
            Console.WriteLine(co1.Count);
            Console.WriteLine(co2.Count);
            cs.removeObserver(co2);
            cs.State = "3";
            Console.WriteLine(co1.Count);
            Console.WriteLine(co2.Count);
            Console.ReadKey();
        }
    }
}
