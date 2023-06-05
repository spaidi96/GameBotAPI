using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class GameScreenshotController : Controller
{
    private readonly ILogger<GameScreenshotController> _logger;

    public GameScreenshotController(ILogger<GameScreenshotController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetGameScreenshot")]
    public GameScreenshotModel GetScreenshotGame (string game_pk)
    {
        GameScreenshotsClient client = new GameScreenshotsClient();
        return client.GetScreenshotGameAsync(game_pk).Result;
    }
}



