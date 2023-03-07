using Microsoft.EntityFrameworkCore;

namespace ItemPriceHistoryTracker.Data
{   
    public class ItemDbContext:DbContext
    {
        public ItemDbContext(DbContextOptions <ItemDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Item { get; set; }

    }
}
