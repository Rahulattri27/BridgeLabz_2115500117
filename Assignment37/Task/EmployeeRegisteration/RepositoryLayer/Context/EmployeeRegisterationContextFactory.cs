using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RepositoryLayer.Context
{
    public class EmployeeRegisterationContextFactory : IDesignTimeDbContextFactory<EmployeeRegisterationContext>
    {
        public EmployeeRegisterationContext CreateDbContext(string[] args)
        {
            // Read configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<EmployeeRegisterationContext>();
            var connectionString = config.GetConnectionString("Sqlconnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new EmployeeRegisterationContext(optionsBuilder.Options);
        }
    }
}