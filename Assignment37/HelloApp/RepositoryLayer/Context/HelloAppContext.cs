using System;
using Microsoft.EntityFrameworkCore;
namespace RepositoryLayer.Context
{
	public class HelloAppContext:DbContext
	{
		public HelloAppContext(DbContextOptions<HelloAppContext> options):base(options)
		{
		}
		public virtual DbSet<Entity.UserEntity> Users { get; set; }
        // Add this if needed
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=HelloWorldDB;User Id=sa;Password=StrongPassword@123;TrustServerCertificate=True;");
            }
        }
    }
}

