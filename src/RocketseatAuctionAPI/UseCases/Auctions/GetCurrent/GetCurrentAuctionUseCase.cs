using Microsoft.EntityFrameworkCore;
using RocketseatAuctionAPI.Entities;
using RocketseatAuctionAPI.Repositories;

namespace RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction =>  auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends); 
    }
}
