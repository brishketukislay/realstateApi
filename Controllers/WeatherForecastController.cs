using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[] // readonly string
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")] //  GetWeatherForecast api
    public IEnumerable<WeatherForecast> Get() // get api
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast // select index
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)), // date format
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
