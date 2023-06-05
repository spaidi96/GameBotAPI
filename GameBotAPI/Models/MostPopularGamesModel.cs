namespace GameBotAPI.Models;

public class MostPopularGamesModel
{
    public List<MostPopularResults> Results { get; set; }
    public class MostPopularResults
    {
        public string name { get; set; }
        public string released { get; set; }
        public string rating { get; set; }
        public string rating_top { get; set; }
        public string background_image { get; set; }
    }
}