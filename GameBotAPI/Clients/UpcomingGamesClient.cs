using GameBotAPI.Models;
using Newtonsoft.Json;

namespace GameBotAPI.Clients;

public class UpcomingGamesClient
{
    private static HttpClient _client;
    private static string _address;
    private static string _apiKey;

    public UpcomingGamesClient()
    {
        _address = Constants.address;
        _apiKey = Constants.apiKey;
        _client = new HttpClient();
        _client.BaseAddress = new Uri(_address);
    }

    public async Task<UpcomingGamesModel> GetUpcomingGamesAsync()
    {
        var response = await _client.GetAsync($"https://api.rawg.io/api/games?dates=2023-06-01,2024-10-10&ordering=-added&key={_apiKey}");
        var content = response.Content.ReadAsStringAsync().Result;
        response.EnsureSuccessStatusCode();
        var result = JsonConvert.DeserializeObject<UpcomingGamesModel>(content);
        return result;
    }
}