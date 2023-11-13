using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using exam_api_nguyenmanhhieu.Models;

namespace exam_api_nguyenmanhhieu.Data
{
    public class InforClientModelDBContext : DbContext
    {
        public InforClientModelDBContext(DbContextOptions<InforClientModelDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<InforClientModel> InforClients { get; set; }

    }
}


