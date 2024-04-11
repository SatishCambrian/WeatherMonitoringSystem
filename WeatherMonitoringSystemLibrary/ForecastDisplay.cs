using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{

    /// <summary>
    /// Concrete Observer for displaying weather forecast
    /// </summary>
    public class ForecastDisplay: IDisplay
    {
        private readonly IWeatherDataSubject weatherDataSubject;
        public ForecastDisplay(IWeatherDataSubject weatherDataSubject)
        {
            this.weatherDataSubject = weatherDataSubject;
            weatherDataSubject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Weather is Rainy.");
        }
    }
}
