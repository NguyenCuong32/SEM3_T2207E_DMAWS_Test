using Microsoft.EntityFrameworkCore;

namespace DMAWS_Test.model
{
    public class OrderSystemContext  : DbContext
    {

        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {

        }
        public DbSet<OrderTbl> OrderTbl { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
