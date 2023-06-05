using GameBotAPI.Clients;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class GameStoreController : Controller
{
    private readonly ILogger<GameStoreController> _logger;

    public GameStoreController(ILogger<GameStoreController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetGameStore")]
    public GameStoreModel GetGameStore(string game_pk)
    {
        GameStoreClient client = new GameStoreClient();
        return client.GetStoreGameAsync(game_pk).Result;
    }
}