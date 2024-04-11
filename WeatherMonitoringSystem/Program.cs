using System;
using System.Collections.Generic;
using WeatherMonitoringSystemLibrary;
using WeatherMonitoringSystemLibrary.Interfaces;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Start of Applicaiton
    /// </summary>
    class Program
    {

        /// <summary>
        /// Program Class 
        /// </summary>
        /// <param name="args">Command line arguments through Console.Readline</param>
        static void Main(string[] args)
        {
            WeatherData weatherData = WeatherData.GetInstance();
            WeatherStation weatherStation = new WeatherStation(weatherData);

            IDisplay currentConditionsDisplay = weatherStation.CreateCurrentConditionsDisplay();
            IDisplay statisticsDisplay = weatherStation.CreateStatisticsDisplay();
            IDisplay forecastDisplay = weatherStation.CreateForecastDisplay();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Display of current conditions");
                Console.WriteLine("2. Display of statistics");
                Console.WriteLine("3. Display of forecast");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your preference: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        currentConditionsDisplay.Display();
                        break;
                    case "2":
                        statisticsDisplay.Display();
                        break;
                    case "3":
                        forecastDisplay.Display();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }


}
