using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.OBSERVER
{
   public class WheaterSubject : Subject
    {
        List<Observer> observers;

        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }

        public WheaterSubject()
        {
            observers = new List<Observer>();
        }
        public void NotifyObserver()
        {
            foreach(Observer o in observers)
            {
                o.Update(Celsius, Fahrenheit);
            }
        }

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
           Console.WriteLine($"Observer Id: {observers.Count} was added");
        }

        public void Unregister(Observer observerToRemove)
        {
            bool removed = false;
            for(int i = 0; i < observers.Count; i++)
            {
                if(observers[i] == observerToRemove)
                {
                    observers.Remove(observerToRemove);
                    Console.WriteLine($"Observer was removed");
                    removed = true;
                }
            }
            if(!removed) Console.WriteLine($"Observer was not found");

        }
        public void SetCelsius(double newCelsius)
        {
            Celsius = newCelsius;
            Fahrenheit = (newCelsius * 9 / 5) + 32;
            NotifyObserver();
        }
        public void SetFahrenheit(double newFahrenheit)
        {
            Fahrenheit = newFahrenheit;
            Celsius = (Fahrenheit - 32) * 5/9;
            NotifyObserver();
        }
    }
}
