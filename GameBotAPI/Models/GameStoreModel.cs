namespace GameBotAPI.Models;

public class GameStoreModel
{
    public List<results> Results { get; set; }
    public class results
    {
        public string url { get; set; }
    }
}