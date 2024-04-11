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
    

    //Singleton Class
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


        public void UpdateWeatherConditions()
        {
            temperature = GenerateRandomDouble(0, 99);
            humidity = GenerateRandomDouble(0, 100);
            pressure = GenerateRandomDouble(900, 1000);
            NotifyObservers();
        }

        private double GenerateRandomDouble(double min, double max)
        {
            return rand.NextDouble() * (max - min) + min;
        }

        public double GetTemperature()
        {
            return temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetPressure()
        {
            return pressure;
        }
    }
}
