using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLibrary.Observer
{
    public class TvDisplay : IObserver
    {
        public WeatherStation station;

        public TvDisplay(WeatherStation station)
        {
            this.station = station;
        }

        public void Update()
        {
            Console.WriteLine(station.temp);
        }
    }
}
