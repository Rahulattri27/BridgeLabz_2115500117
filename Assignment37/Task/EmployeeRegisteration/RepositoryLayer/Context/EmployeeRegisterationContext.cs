using System;
using Microsoft.EntityFrameworkCore;
namespace RepositoryLayer.Context
{
	public class EmployeeRegisterationContext:DbContext
	{
		public EmployeeRegisterationContext(DbContextOptions<EmployeeRegisterationContext> options):base(options)
		{
		}
		public virtual DbSet<Entity.EmployeeEntity> Employees { get; set; }
        // Add this if needed
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Employee;UserId=sa;Password=StrongPassword@123;TrustServerCertificate=True;");
            }
        }
    }
}

