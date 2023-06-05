using GameBotAPI.Models;
using Newtonsoft.Json;

namespace GameBotAPI.Clients;

public class MostPopularGamesClient
{
    private static HttpClient _client;
    private static string _address;
    private static string _apiKey;

    public MostPopularGamesClient()
    {
        _address = Constants.address;
        _apiKey = Constants.apiKey;
        _client = new HttpClient();
        _client.BaseAddress = new Uri(_address);
    }

    public async Task<MostPopularGamesModel> GetMostPopularGamesByDateAsync(string first_date, string second_date)
    {
        var response = await _client.GetAsync($"https://api.rawg.io/api/games?dates={first_date},{second_date}&ordering=-added&key={_apiKey}");
        var content = response.Content.ReadAsStringAsync().Result;
        response.EnsureSuccessStatusCode();
        var result = JsonConvert.DeserializeObject<MostPopularGamesModel>(content);
        return result;
    }
}