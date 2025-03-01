using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : ISubject
    {
        public int temperature {get; private set;}
        public int pressure {get; private set;}
        public int windSpeed {get; private set;}
        private List<IObserver> observers;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void removeObserver(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void addObserver(IObserver ob)
        {
            observers.Add(ob);
        }

        private void notifyObservers()
        {
            if(observers != null && observers.Count > 0)
            {
                foreach(var observer in observers)
                {
                    observer.update();
                }
            }
        }

        private void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(int temperature, int pressure, int windSpeed)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            this.windSpeed = windSpeed;
            this.measurementsChanged();
        }
    }
}