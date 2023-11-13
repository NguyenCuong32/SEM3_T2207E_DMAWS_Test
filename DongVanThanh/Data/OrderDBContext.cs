using DongVanThanh.Models;
using Microsoft.EntityFrameworkCore;

namespace DongVanThanh.Data
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderModel>().ToTable("OrderTbl");
        }
        public DbSet<OrderModel> OrderModels;
        public DbSet<DongVanThanh.Models.OrderModel> OrderModel { get; set; } = default!;

    }
}
