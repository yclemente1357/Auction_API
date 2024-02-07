using Microsoft.EntityFrameworkCore;
using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\tocod\source\leilaoDbNLW.db");
    }
}
