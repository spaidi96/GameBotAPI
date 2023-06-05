namespace GameBotAPI.Models;

public class SameSeriesGamesModel
{
    public List<SameSeriesResult> Results { get; set; }
    public class SameSeriesResult
    {
        public string name { get; set; }
        public string released { get; set; }
        public Uri background_image { get; set; }
    }
}