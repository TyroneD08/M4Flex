namespace weerapi.Models;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public string City {get;set;}
}

namespace huisapi.Models;

public class Lampen{
    public bool Led1 {get; set;}
    public bool Led2 {get; set;}
    public bool Led3 {get; set;}
}