using Microsoft.EntityFrameworkCore;
using Ruby.Drum.Domain.Catalog;

namespace Ruby.Drum.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
        
    }

    public DbSet<Item> Items { get; set; }
}
