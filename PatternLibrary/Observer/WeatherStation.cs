using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLibrary.Observer
{
    public class WeatherStation : IObservable
    {
        public List<IObserver> observers = new List<IObserver>();
        public int temp { get; set; }
        public WeatherStation()
        {

        }
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public string Notify()
        {
            string observersStr = "";
            foreach(IObserver obs in observers)
            {
                obs.Update();
                observersStr += obs.ToString();
            }
            return observersStr;
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void ChangeWeather()
        {
            var rand = new Random();
            temp = rand.Next(70, 100);
        }
    }
}
