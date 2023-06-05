using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class UpcomingGamesController : Controller
{
    private readonly ILogger<UpcomingGamesController> _logger;

    public UpcomingGamesController(ILogger<UpcomingGamesController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetUpcomingGames")]
    public UpcomingGamesModel GetUpComingGame()
    {
        UpcomingGamesClient client = new UpcomingGamesClient();
        return client.GetUpcomingGamesAsync().Result;
    }
}