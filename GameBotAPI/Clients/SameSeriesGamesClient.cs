using GameBotAPI.Models;
using Newtonsoft.Json;

namespace GameBotAPI.Clients;

public class SameSeriesGamesClient
{
    private static HttpClient _client;
    private static string _address;
    private static string _apiKey;

    public SameSeriesGamesClient()
    {
        _address = Constants.address;
        _apiKey = Constants.apiKey;
        _client = new HttpClient();
        _client.BaseAddress = new Uri(_address);
    }

    public async Task<SameSeriesGamesModel> GetSameSerirsGamesAsync(string game_pk)
    {
        var response = await _client.GetAsync($"https://api.rawg.io/api/games/{game_pk}/game-series?key={_apiKey}");
        var content = response.Content.ReadAsStringAsync().Result;
        response.EnsureSuccessStatusCode();
        var result = JsonConvert.DeserializeObject<SameSeriesGamesModel>(content);
        return result;
    }
}