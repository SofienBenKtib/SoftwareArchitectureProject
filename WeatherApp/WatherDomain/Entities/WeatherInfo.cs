namespace WeatherApp.WatherDomain.Entities;

/// <summary>
/// Represents weather information with details about temperature, pressure, and wind speed.
/// </summary>
public class WeatherInfo
{
    public double Temperature { get; set; }
    public double Pression { get; set; }
    public double Wind { get; set; }
}