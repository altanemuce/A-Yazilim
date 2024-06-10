using Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ExampleDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected IConfiguration _configuration;
        public ExampleDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            _configuration = configuration;
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<BidSheet> BidSheets { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferCart> OfferCarts { get; set; }
        public DbSet<OfferCartItem> OfferCartItems { get; set; }
        public DbSet<OfferComparison> OfferComparisons { get; set; }
        public DbSet<OfferComparisonItem> OfferComparisonItems { get; set; }
        public DbSet<OfferLog> OfferLogs { get; set; }
        public DbSet<OfferItem> OfferItems { get; set; }
        public DbSet<CurrentLog> CurrentLogs { get; set; }

    }
}
