using Microsoft.EntityFrameworkCore;

namespace DMAWS.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<OrderTbl> OrderTbls { get; set; }
}