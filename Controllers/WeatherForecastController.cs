using Microsoft.AspNetCore.Mvc;
using RiderWebAPI.Models;

namespace RiderWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController
  (
    ILogger<WeatherForecastController> logger,
    WeatherForecastService weatherForecastService
  ) : ControllerBase
{
  
  [HttpGet(Name = "GetWeatherForecast")]
  [Route("example")]
  public IEnumerable<WeatherForecast> Get() => 
    weatherForecastService.Get();

  [HttpGet(Name = "currentDay")]
  [Route("today")]
  public WeatherForecast GetToday() =>
    weatherForecastService.Get().First();

  [HttpPost]
  public void Post([FromBody] string name) =>
    WriteLine(weatherForecastService.Hello(name));
}