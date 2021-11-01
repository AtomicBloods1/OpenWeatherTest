using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Configuration;

namespace WeatherApp
{
    public static class AppConfiguration
    {
        private static IConfiguration configuration;

        public static string GetValue(string str)
        {
            if(configuration == null)
            {
                InitConfig();
            }
            return configuration[str];
        }

        private static void InitConfig()
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json",
            optional: true,
            reloadOnChange: true);

            builder.AddUserSecrets<MainWindow>();

            configuration = builder.Build();
        }
    }
}
