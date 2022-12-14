using WeatherApp.OpenWeatherMapModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Repositories
{
    public interface IWeatherRepository
    {
        WeatherResponse GetWeather(string city);
    }
}
