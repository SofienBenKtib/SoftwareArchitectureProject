using WeatherApp.WatherDomain.Entities;

namespace WeatherApp.WatherDomain.Services;

/// <summary>
/// Defines methods for managing and collecting weather data.
/// </summary>
public interface IWeatherOut
{
    public void StartCollect();

    public WeatherConfig GetWeatherConfig();

    public void SetWeatherConfig(WeatherConfig _weatherConfig);
}