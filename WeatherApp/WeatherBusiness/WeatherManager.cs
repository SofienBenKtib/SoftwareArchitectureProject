using WeatherApp.WatherDomain.Entities;
using WeatherApp.WatherDomain.Services;

namespace WeatherApp.WeatherBusiness;

/// <summary>
/// Manages weather configuration and information, and interacts with weather data collection.
/// </summary>
public class WeatherManager
{
    public WeatherConfig weatherConfig;
    public WeatherInfo weatherInfo;
    public IWeatherOut WeatherOut;
}