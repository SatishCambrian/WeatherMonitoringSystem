using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    public class CurrentConditionDisplay : IDisplay,IWeatherDataSubject
    {
        private readonly IWeatherDataSubject wtherData;

        public CurrentConditionDisplay(IWeatherDataSubject wtherData)
        {
            this.wtherData = wtherData;
            wtherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {wtherData.GetTemperature()}Cdegrees and {wtherData.GetHumidity()}% humidity");

        }
    }
}
