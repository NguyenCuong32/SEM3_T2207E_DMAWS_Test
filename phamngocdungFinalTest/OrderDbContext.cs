using Microsoft.EntityFrameworkCore;
using phamngocdungFinalTest.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace phamngocdungFinalTest
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderModel>().HasKey(x => x.Id);
            modelBuilder.Entity<OrderModel>().Property(p => p.Id)
                                            .ValueGeneratedOnAdd()
                                            .HasDefaultValue(1);
            modelBuilder.Entity<OrderModel>().ToTable("OrderTbl");
        }
        public DbSet<OrderModel> Orders { get; set; }
    }
}
