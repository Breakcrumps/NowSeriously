using Microsoft.AspNetCore.Http.HttpResults;
using RiderWebAPI.Models;

namespace RiderWebAPI.Controllers;

public interface IWeatherForecastService
{
  public IEnumerable<WeatherForecast> Get();
  public Created<WeatherForecast> Post(WeatherForecast forecast);
}

public class WeatherForecastService : IWeatherForecastService
{
  private static readonly string[] Summaries =
  [
    "Freezing", "Bracing", "Chilly", "Cool", "Mild",
    "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
  ];
  
  public IEnumerable<WeatherForecast> Get()
  {
    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
      .ToArray();
  }

  public Created<WeatherForecast> Post(WeatherForecast forecast)
  {
    throw new NotImplementedException();
  }
  
  public string Hello(string name) => $"Hello, {name}!";
}