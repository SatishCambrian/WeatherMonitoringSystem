using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystemLibrary.Interfaces
{
    public interface IDisplay
    {
        /// <summary>
        /// Interface for all Display Elements
        /// </summary>
        void Display();

    }

    public interface IObserver
    {
        //void update(double temperature, double humidity, double pressure);
    }
}
