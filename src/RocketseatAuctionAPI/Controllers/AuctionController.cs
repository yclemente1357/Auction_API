using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionAPI.Entities;
using RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;
using Swashbuckle.AspNetCore;

namespace RocketseatAuctionAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrrentAuction()
    {

        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if (result is null)
        {
            return NoContent();
        }

        return Ok(result);
    }
}

