namespace GameBotAPI.Models;

public class UpcomingGamesModel
{
    public List<resultupcoming> Results { get; set; }
   
    public class resultupcoming
    {
        public string name { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
        public List<short_screenshots> Screenshots { get; set; }

        public class short_screenshots
        {
            public string image { get; set; }
        }
    }
}