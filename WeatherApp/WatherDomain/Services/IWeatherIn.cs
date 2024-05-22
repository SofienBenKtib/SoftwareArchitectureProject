
namespace WeatherApp.WatherDomain.Services;
/// <summary>
/// Defines a method to write weather data values.
/// </summary>
public interface IWeatherIn
{
    public void WriteWeatherValue(string valueType, string value);
}