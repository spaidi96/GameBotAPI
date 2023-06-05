using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;

[Route("[controller]")]
[ApiController]

public class GamesController : ControllerBase
{
    private readonly ILogger<GamesController> _logger;

    public GamesController(ILogger<GamesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetGameInfo")]
    public GameInfoModel GetGame(string id)
    {
        GameClient client = new GameClient();
        return client.GetGamesAsync(id).Result;
    }
}


