using System;
using System.Net.Http;
using GameBotAPI.Models;
using Newtonsoft.Json;

namespace GameBotAPI.Clients;

public class GameClient
{
    private static HttpClient _client;
    private static string _address;
    private static string _apiKey;

    public GameClient()
    {
        _address = Constants.address;
        _apiKey = Constants.apiKey;
        _client = new HttpClient();
        _client.BaseAddress = new Uri(_address);
    }
    
    public async Task<GameInfoModel> GetGamesAsync(string id)
    {
        var response = await _client.GetAsync($"https://api.rawg.io/api/games/{id}?key={_apiKey}");
        var content = response.Content.ReadAsStringAsync().Result;
        response.EnsureSuccessStatusCode();
        var result = JsonConvert.DeserializeObject<GameInfoModel>(content);
        return result;
    }
}