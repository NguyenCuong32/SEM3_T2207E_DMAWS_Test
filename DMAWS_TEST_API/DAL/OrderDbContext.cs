using DMAWS_TEST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DMAWS_TEST_API.DAL
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

        public DbSet<Order> OrderTbl { get; set; }
    }
}
