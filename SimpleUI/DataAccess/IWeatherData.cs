using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SimpleUI.Models;

namespace SimpleUI.DataAccess
{
    public interface IWeatherData
    {
        [Get("/WeatherForecast")]
        Task<List<WeatherModel>> GetWeather();
        
    }
}
