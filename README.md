Assignment: Weather Monitoring System

Objective: Create a weather monitoring system where weather data is collected and multiple displays are updated when the weather changes.

Details:

WeatherData (Singleton): This is the subject of the Observer pattern and also a Singleton. It collects weather data from a weather station (for simplicity, you can simulate this by randomly generating data). When the data changes, it notifies all observers.

IDisplay (Interface): This is the interface for all display elements. It includes a single method Display() that shows the current weather data on the display.

CurrentConditionsDisplay (Observer and Decorator): This is one of the observers. It displays the current weather conditions. It’s also a decorator that can add additional information (like date and time) to the display.

StatisticsDisplay (Observer): This is another observer. It displays weather statistics (like average, max, and min temperatures).

ForecastDisplay (Observer): This is yet another observer. It displays a weather forecast based on the current weather data.

WeatherStation (Factory): This is a factory for creating different types of displays.


Create a singleton
The WeatherData object should be a Singleton.
Maximum score10
Create a Factory
Use the Factory pattern to create display objects in the WeatherStation class
Maximum score20
Call the Observer
Use the Observer pattern to update all displays when the weather data changes
Maximum score20
Use a decorator
Use the Decorator pattern to add additional information to the CurrentConditionsDisplay
Maximum score20
Keep the library and application seperate
The project is split into a class library and a console application
Maximum score10
Keep the interfaces separate from the concrete implementations
Interfaces are separate from concrete classes.
Maximum score10
Document your classes
Use the triple slash comments to provide information about the classes, methods, properties, parameters, and return types.
Maximum score10
