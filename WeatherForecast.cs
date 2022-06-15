namespace RickAndMortyAPI2;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}


public class People
{
    public string? Name { get; set; }
}

public class Character
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? status { get; set; }
    public string? species { get; set; }
    public string? type { get; set; }
    public string? gender { get; set; }
    public string? origin { get; set; }
    public string? location { get; set; }
    public string? episode { get; set; }
    public string? created { get; set; }
}