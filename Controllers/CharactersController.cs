using Microsoft.AspNetCore.Mvc;

namespace RickAndMortyAPI2.Controllers;

[ApiController]
[Route("[controller]")]
public class CharactersController : ControllerBase
{
    [HttpGet(Name = "GetCharacters")]
    public Character GetCharacter()
    {

        try
        {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            using (var reader = new StreamReader(@".\data\characters.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }

            return  new Character
            {
                id = "1",
                name = "Annie",
                status = "Alive",
                species = "Human",
                gender = "Female",
                episode = "1,5,3"
            }; 

            // return Enumerable.Range(1, 5).Select(i => new Character
            // {
            //     id = $"{i}",
            //     name = "Annie",
            //     status = "Alive",
            //     species = "Human",
            //     gender = "Female",
            //     episode = "1,5,3"
            // }).ToList();

        }
        catch (System.Exception)
        {

            throw;
        }
    }

}