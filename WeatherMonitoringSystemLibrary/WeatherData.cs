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

        /// <summary>
        /// Private constructor to prevent instantiation from outside the class.
        /// Initializes the list of observers and the random number generator.
        /// </summary>

        private WeatherData() {
            observers = new List<IDisplay>();
            rand = new Random(); //randomly generating data
        }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        /// <returns>The singleton instance of WeatherData.</returns>

        public static WeatherData GetInstance()
        {
            if( instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }


        /// <summary>
        /// Registers an observer to receive notifications.
        /// </summary>
        /// <param name="observer">The observer to register.</param>

        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from receiving notifications.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>

        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);

        }

        /// <summary>
        /// Notifies all registered observers with the latest weather data.
        /// </summary>

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

        /// <summary>
        /// Updates the weather conditions with random values and notifies observers.
        /// </summary>
        public void UpdateWeatherConditions()
        {
            temperature = GenerateRandomDouble(0, 99);
            humidity = GenerateRandomDouble(0, 100);
            pressure = GenerateRandomDouble(900, 1000);
            NotifyObservers();
        }

        /// <summary>
        /// Generates a random double value within the specified range.
        /// </summary>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>A random double value within the specified range.</returns>

        private double GenerateRandomDouble(double min, double max)
        {
            return rand.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// Gets the current temperature.
        /// </summary>
        /// <returns>The current temperature.</returns>

        public double GetTemperature()
        {
            return temperature;
        }

        /// <summary>
        /// Gets the current humidity.
        /// </summary>
        /// <returns>The current humidity.</returns>

        public double GetHumidity()
        {
            return humidity;
        }

        /// <summary>
        /// Gets the current pressure.
        /// </summary>
        /// <returns>The current pressure.</returns>

        public double GetPressure()
        {
            return pressure;
        }
    }
}
