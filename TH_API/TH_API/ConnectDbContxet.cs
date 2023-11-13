using Microsoft.EntityFrameworkCore;
using TH_API.Models;

namespace TH_API;

public class ConnectDbContxet : DbContext
{
    public  ConnectDbContxet(DbContextOptions<ConnectDbContxet> options) : base(options)
    {}
    public DbSet<Order> Orders { get; set; }
}