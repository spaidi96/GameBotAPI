using Newtonsoft.Json;
using RawgNET.Models;

namespace GameBotAPI.Models;

public class GameInfoModel
{
    public string name { get; set; }
    public List<developers> Developers { get; set; }
    public List<genres> Genres { get; set; }
    public string description { get; set; }
    public string metacritic { get; set; }
    public string released { get; set; }
    public Uri background_image { get; set; }
    public class developers
    {
        public string name { get; set; }
    }
    public class genres
    {
        public string name { get; set; }
    }

   
}