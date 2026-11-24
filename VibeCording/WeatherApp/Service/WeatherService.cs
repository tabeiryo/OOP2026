using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp.Services;

public class WeatherService
{
    private readonly HttpClient _httpClient = new();

    public async Task<WeatherData> GetCurrentWeatherAsync(
    double latitude,
    double longitude)
    {

        string url =
    "https://api.open-meteo.com/v1/forecast" +
    $"?latitude={latitude}" +
    $"&longitude={longitude}" +
    "&current=temperature_2m,relative_humidity_2m,wind_speed_10m,weather_code" +
    "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
    "&timezone=Asia/Tokyo";

        string json = await _httpClient.GetStringAsync(url);

        using JsonDocument document = JsonDocument.Parse(json);

        var current =
    document.RootElement.GetProperty("current");

        var daily =
    document.RootElement.GetProperty("daily");

        double temperature =
            current.GetProperty("temperature_2m")
                   .GetDouble();

        int humidity =
            current.GetProperty("relative_humidity_2m")
                   .GetInt32();

        double windSpeed =
            current.GetProperty("wind_speed_10m")
                   .GetDouble();

        int weatherCode =
            current.GetProperty("weather_code")
                   .GetInt32();

        var dates =
    daily.GetProperty("time");

        var weatherCodes =
            daily.GetProperty("weather_code");

        var maxTemperatures =
            daily.GetProperty("temperature_2m_max");

        var minTemperatures =
            daily.GetProperty("temperature_2m_min");

        var precipitationProbabilities =
            daily.GetProperty("precipitation_probability_max");

        List<ForecastDay> forecasts = new();

        for (int i = 0; i < dates.GetArrayLength(); i++)
        {
            forecasts.Add(new ForecastDay
            {
                Date = DateTime.Parse(
                    dates[i].GetString()!),

                WeatherCode =
                    weatherCodes[i].GetInt32(),

                MaxTemperature =
                    maxTemperatures[i].GetDouble(),

                MinTemperature =
                    minTemperatures[i].GetDouble(),

                PrecipitationProbability =
                    precipitationProbabilities[i].GetInt32()
            });
        }

        return new WeatherData
        {
            Temperature = temperature,
            Humidity = humidity,
            WindSpeed = windSpeed,
            WeatherCode = weatherCode,
            Forecasts = forecasts
        };
    }
}