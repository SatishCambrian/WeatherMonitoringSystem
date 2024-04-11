using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    public class StatisticsDisplay : IDisplay
    {
        private readonly IWeatherDataSubject weatherData;
        //for Statistics
        // variable for list of temperature 
        private List<double> temperatures;
        public StatisticsDisplay(IWeatherDataSubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            temperatures = new List<double>();
        }

        /// <summary>
        /// Changes to display with new temperature data
        /// </summary>
        
        
        public void update(double temperature,double humidity, double pressure) 
        { 
            temperatures.Add(temperature);
            Display();
        }
        /// <summary>
        /// Displays the statistics
        /// </summary>
        public void Display()
        {
            double maxTemperature = temperatures.Count > 0 ? temperatures.Max() : 0;
            double minTemperature = temperatures.Count > 0 ? temperatures.Min() : 0;
            double avgTemperature = temperatures.Count > 0 ? temperatures.Average() : 0;
            Console.WriteLine($"Maximum Temperature - {maxTemperature} Minimum Temperature - {minTemperature} Average Temperature - {avgTemperature}");
        }
    }
}
