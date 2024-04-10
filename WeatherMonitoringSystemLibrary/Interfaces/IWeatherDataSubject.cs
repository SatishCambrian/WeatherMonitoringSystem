using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystemLibrary.Interface;

namespace WeatherMonitoringSystemLibrary.Interfaces
{
    /// <summary>
    /// Observer Pattern's Subject Interface
    /// </summary>

    public interface IWeatherDataSubject
    {
        void RegisterObserver(IDisplay _observer);
        void RemoveObserver(IDisplay _observer);
        void NotifyObservers();
    }
}
