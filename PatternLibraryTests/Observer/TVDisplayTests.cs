using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PatternLibrary.Observer;

namespace PatternLibraryTests.Observer
{
    public class TVDisplayTests
    {
        [Fact]
        public void TvDisplay_addsStation()
        {
            WeatherStation s = new WeatherStation();

            TvDisplay tv = new TvDisplay(s);

            Assert.NotNull(tv.station);
        }
    }
}
