using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    
    /// <summary>
    /// Factory class
    /// </summary>
    
    public class WeatherStation
    {
        private readonly IWeatherDataSubject dataSubject;
        /// <summary>
        /// Initialization of a new instances of the WeatherStation class
        /// </summary>
        /// <param name="dataSubject">The weather data subject to observe</param>

        public WeatherStation(IWeatherDataSubject dataSubject)
        {
            this.dataSubject=dataSubject;
        }

        /// <summary>
        /// Creation of a display for current weather 
        /// </summary>
        /// <returns></returns>
        public IDisplay CreateCurrentConditionsDisplay()
        {
            return new CurrentConditionsDisplay(dataSubject);
        }
        /// <summary>
        /// Creation of a display for weather statistics
        /// </summary>
        /// <returns></returns>
        public IDisplay CreateStatisticsDisplay()
        {
            return new StatisticsDisplay(dataSubject);
        }
        /// <summary>
        /// Creation of a display for forecast
        /// </summary>
        /// <returns></returns>
        public IDisplay CreateForecastDisplay()
        {
            return new ForecastDisplay(dataSubject);
        }
    }

}
