using OpenWeatherAPI;
using System;
using Xunit;


namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        [Fact]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;


            Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }
    }
}
