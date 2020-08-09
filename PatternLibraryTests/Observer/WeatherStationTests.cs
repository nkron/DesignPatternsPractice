using System;
using Xunit;
using PatternLibrary.Observer;

namespace PatternLibraryTests.Observer
{
    public class WeatherStationTests
    {
        [Fact]
        public void Add_AddsObserver()
        {
            WeatherStation s = new WeatherStation();

            s.Add(new TestObserver());

            Assert.Single(s.observers);
        }
        [Fact]
        public void Remove_RemovesObserver()
        {
            WeatherStation s = new WeatherStation();

            var observer = new TestObserver();
            s.Add(observer);
            s.Remove(observer);

            Assert.Empty(s.observers);
        }
        [Fact]
        public void ChangeWeather_GivesIntBetween70_100()
        {
            WeatherStation s = new WeatherStation();

            s.ChangeWeather();

            Assert.InRange(s.temp,70,100);
        }

        [Fact]
        public void Notify_Notifies()
        {
            WeatherStation s = new WeatherStation();
            var observer = new TestObserver();
            var observer2 = new TestObserver();     
            s.Add(observer);
            s.Add(observer2);
            s.ChangeWeather();

            s.Notify();

            Assert.True(observer.wasNotified);
            Assert.True(observer2.wasNotified);
        }
    }
    internal class TestObserver : IObserver
    {
        internal bool wasNotified = false;
        public void Update()
        {
            wasNotified = true;
        }
    }
}
