namespace GameBotAPI.Models;

public class GameScreenshotModel
{
    public List<resultscreen> Results { get; set; }
    public class resultscreen
    {
        public Uri image { get; set; }
    }
}