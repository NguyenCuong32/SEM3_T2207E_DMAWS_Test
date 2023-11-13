using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderModel>().ToTable("OrderTbl");

        }
        public DbSet<OrderModel> Orders { get; set; }
    }
}

