using System;
using System.Net.Http.Headers;
using GameBotAPI.Clients;
using GameBotAPI.Controllers;

namespace GameBotAPI;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient<GameClient>(client =>
        {
            client.BaseAddress = new Uri("https://api.rawg.io");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });
        services.AddTransient<GameClient>();
        services.AddSingleton<GameClient>();
    }
}

