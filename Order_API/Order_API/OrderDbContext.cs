using Microsoft.EntityFrameworkCore;
using Order_API.Models;

namespace Order_API;

public class OrderDbContext : DbContext
{
    public  OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
    {}
    public DbSet<Order> OrderTbl { get; set; }
    
}