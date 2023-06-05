using GameBotAPI.Controllers;
using GameBotAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameBotAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<WishListGamesModel> WishListGamesModels => Set<WishListGamesModel>();
}