using System.ComponentModel.DataAnnotations;

namespace GameBotAPI.Models;

public class WishListGamesModel
{
    [Key]
    public string name { get; set; }
    public string description { get; set; }
}