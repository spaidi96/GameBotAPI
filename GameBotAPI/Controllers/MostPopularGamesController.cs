using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class MostPopularGamesController : Controller
{
    private readonly ILogger<MostPopularGamesController> _logger;

    public MostPopularGamesController(ILogger<MostPopularGamesController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetMostPopularGames")]
    public MostPopularGamesModel GetGame(string first_date, string second_date)
    {
        MostPopularGamesClient client = new MostPopularGamesClient();
        return client.GetMostPopularGamesByDateAsync(first_date, second_date).Result;
    }
}