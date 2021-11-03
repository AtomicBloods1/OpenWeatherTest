using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp
{
    public class OpenWeatherService : IWindDataService
    {
        private OpenWeatherProcessor owp;
        public WindDataModel LastWindData;
        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }

        public async Task<WindDataModel> GetDataAsync()
        {
            var temp = await owp.GetCurrentWeatherAsync();
            var result = new WindDataModel
            {
                DateTime = DateTime.UnixEpoch.AddSeconds(temp.DateTime),
                Direction = temp.Wind.Deg,
                MetrePerSec = temp.Wind.Speed
            };
            LastWindData = result;
            return LastWindData;
        }
    }
}
