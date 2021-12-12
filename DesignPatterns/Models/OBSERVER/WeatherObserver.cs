using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.OBSERVER
{
   public class WeatherObserver : Observer
    {
        private double Celsius { get; set; }
        private double Fahrenheit { get; set; }

        private static int IdTracker = 0;

        private Subject weatherSubject;
        private int observerId;

        public WeatherObserver(Subject newWeatherSubject)
        {
            weatherSubject = newWeatherSubject;

            observerId = ++IdTracker;
            Console.WriteLine($"New Observer As Been Created {observerId}");
            weatherSubject.Register(this);
        }
        public void Update(double newCelsius, double newFahrenheit)
        {
            Celsius = newCelsius;
            Fahrenheit = newFahrenheit;
            ShowWeather();
        }
        public void ShowWeather()
        {
            Console.WriteLine($" Observer id:{observerId} Weather In Fahrenheit Is {Fahrenheit}");
            Console.WriteLine($" Observer id:{observerId} Weather In Celsius Is {Celsius}");
        }
    }
}
