using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext(DbContextOptions options) : DbContext(options)
{
    //Items is optional, EF will create the Items table because of the 1:1 relationship between Auction and Item
    //public DbSet<Item> Items { get; set; }
    public DbSet<Auction> Auctions { get; set; }

}
