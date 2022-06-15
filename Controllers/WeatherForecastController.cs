using Microsoft.AspNetCore.Mvc;

namespace RickAndMortyAPI2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<People> Hola()
    {
        // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        // {
        //     Date = DateTime.Now.AddDays(index),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();

        return Enumerable.Range(1, 5).Select(index => new People
        {
            Name = $"{index}"
        })
        .ToArray();
    }

    private void getCharacters()
    {
        using (var reader = new StreamReader(@".\data\characters.csv"))
        {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('\t');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }
        }
    }
}
