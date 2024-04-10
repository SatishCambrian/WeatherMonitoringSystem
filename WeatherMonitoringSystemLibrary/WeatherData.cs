using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    /// <summary>
    /// Singletion class that collects Weather Data. Then Notifies Observers
    /// </summary>

    public class WeatherData : IWeatherDataSubject
    {
        private static WeatherData instance;
        private List<IDisplay> observers;
        private Random rand;
        private double temperature, humidity, pressure;

        private WeatherData() {
            observers = new List<IDisplay>();
            rand = new Random(); //randomly generating data
        }
         public static WeatherData GetInstance()
        {
            if( instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);

        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

       // public void
    }
}
