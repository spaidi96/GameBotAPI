using GameBotAPI.Data;
using GameBotAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameBotAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class WishListController : ControllerBase
{
   
    private readonly DataContext _dataContext;
    public WishListController(DataContext context)
    {
        _dataContext = context;
    }
    
    
    [HttpPost(Name = "AddWishList")]
    public async Task<ActionResult<List<WishListGamesModel>>> AddGameToWishList(WishListGamesModel wishListGamesModel)
    {
        _dataContext.WishListGamesModels.Add(wishListGamesModel);
        await _dataContext.SaveChangesAsync();
        return Ok(await _dataContext.WishListGamesModels.ToListAsync());
    }

    [HttpGet(Name = "GetWishList")]
    public async Task<ActionResult<List<WishListGamesModel>>> GetGamesFromWishList()
    {
        return Ok(await _dataContext.WishListGamesModels.ToListAsync());
    }

    [HttpDelete(Name = "DeleteWishList")]
    public async Task<ActionResult<List<WishListGamesModel>>> DeleteGameFromWishList(
        WishListGamesModel wishListGamesModel)
    {
        _dataContext.WishListGamesModels.Remove(wishListGamesModel);
        await _dataContext.SaveChangesAsync();
        return Ok(await _dataContext.WishListGamesModels.ToListAsync());
    }
}