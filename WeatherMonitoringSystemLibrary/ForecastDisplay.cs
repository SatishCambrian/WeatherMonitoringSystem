using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    public class ForecastDisplay: IDisplay
    {
        private readonly IWeatherDataSubject _weatherDataSubject;
        public ForecastDisplay(IWeatherDataSubject weatherDataSubject)
        {
            this._weatherDataSubject = weatherDataSubject;
            weatherDataSubject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Weather is Rainy.")
        }
    }
}
