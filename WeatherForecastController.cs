using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
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

    [HttpPost()]
    public IActionResult Post(string weather)
    {
        return Ok("Weather is created");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id)
    {
        return Ok($"");
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id,string name)
    {
        return Ok($"Updated {name}");
    }
    [HttpHead()]
    public IActionResult Head(string weather)
    {
        return Ok($"Hatdog");
    }
    [HttpGet("{id}")]

    public IActionResult GetWeatherById(int id)
    {
        return Ok($"This is the weather {id}");
    }
}