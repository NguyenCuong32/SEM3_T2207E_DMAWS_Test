using System;
using examTranHien.Models;
using Microsoft.EntityFrameworkCore;

namespace examTranHien
{
	public class ExamDbContext:DbContext
	{
		public ExamDbContext(DbContextOptions<ExamDbContext>options):base(options)
		{
		}
		public DbSet<Class> Class { get; set; }
		public DbSet<Student> Student { get; set; }
	}
}
