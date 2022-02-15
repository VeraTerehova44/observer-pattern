using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_station
{
    public class ConcreteSubject : Subject
    {
        private List<Observer> observer = new List<Observer>();
        public void registerObserver(Observer obr)
        {
            this.observer.Add(obr);
        }
        public void removeObserver(Observer obr)
        {
             this.observer.Remove(obr);
        }
        public void notifyObserver()
        {
            foreach (var obr in observer)
            {
                obr.update(this);
            }
        }
        string state;
        public string State
        {
            get { return state; }
            set { state = value; notifyObserver(); }
        }
    }
}
