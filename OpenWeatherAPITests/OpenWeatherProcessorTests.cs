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
            ApiHelper.InitializeClient();

            Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;
            ApiHelper.InitializeClient();

            Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetCurrentWeatherAsync);
        }

        [Fact]
        public void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;
        }
    }
}
