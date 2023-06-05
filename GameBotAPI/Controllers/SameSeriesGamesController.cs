using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class SameSeriesGamesController : Controller
{
    private readonly ILogger<SameSeriesGamesController> _logger;

    public SameSeriesGamesController(ILogger<SameSeriesGamesController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetSameSeriesGames")]
    public SameSeriesGamesModel GetSameGames(string game_pk)
    {
        SameSeriesGamesClient client = new SameSeriesGamesClient();
        return client.GetSameSerirsGamesAsync(game_pk).Result;
    }
}