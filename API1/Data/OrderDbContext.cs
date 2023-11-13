using API1.Model;
using Microsoft.EntityFrameworkCore;


namespace API1.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Order> OrderTbl { get; set; }
    }
}