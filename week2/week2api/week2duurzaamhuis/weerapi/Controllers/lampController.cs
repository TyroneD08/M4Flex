using Microsoft.AspNetCore.Mvc;
using weerapi.Models;

namespace weerapi.Controllers;

[ApiController]
[Route("[controller]")]
public class lampController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<lampController> _logger;

    public lampController(ILogger<lampController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLampen")]
    public IEnumerable<lampController> Get([FromQuery] string? city)
    {
        return Enumerable.Range(1, 5).Select(index => new lampController
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            City = city
        })
        .ToArray();
    }
}