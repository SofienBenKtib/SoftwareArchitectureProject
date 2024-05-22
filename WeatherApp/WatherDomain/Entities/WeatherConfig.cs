namespace WeatherApp.WatherDomain.Entities;
/// <summary>
/// Represents the configuration settings for weather data.
/// </summary>
public class WeatherConfig
{
    public bool HasTemperature { get; set; }
    public bool HasPression { get; set; }
    public bool HasWind { get; set; }
    public bool HasPrecepitation { get; set; }
}