using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystemLibrary
{
    public class CurrentConditionDisplay : IWeatherDataSubject,IDisplay
    {
        private readonly IWeatherDataSubject dataSubject;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditionDisplay"/> class.
        /// </summary>
        /// <param name="dataSubject">The subject providing weather data.</param>

        public CurrentConditionDisplay(IWeatherDataSubject dataSubject)
        {
            this.dataSubject = dataSubject;
            dataSubject.RegisterObserver(this);
        }

        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Current conditions: {dataSubject.GetTemperature()}C degrees and {dataSubject.GetHumidity()}% humidity");

        }


        /// <summary>
        /// Notifies observers of changes in weather data (not implemented).
        /// </summary>
        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Registers an observer (not implemented).
        /// </summary>
        /// <param name="_observer">The observer to register.</param>
        public void RegisterObserver(IDisplay _observer)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Removes an observer (not implemented).
        /// </summary>
        /// <param name="_observer">The observer to remove.</param>
        public void RemoveObserver(IDisplay _observer)
        {
            throw new NotImplementedException();
        }
    }
}
