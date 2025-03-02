using BusinessLayer.Interface;
using BusinessLayer.Services;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using NLog.Extensions.Logging;

var logger = NLog.LogManager.Setup().LoadConfigurationFromFile("/Users/rahulkumarair/Projects/EmployeeRegistration/EmployeeRegistration/nlog.config").GetCurrentClassLogger();
try
{
    
    logger.Info("Starting application...");
    var builder = WebApplication.CreateBuilder(args);

    AppContext.SetSwitch("Switch.Microsoft.Data.SqlClient.UseManagedNetworkingOnMacOS", true);
    AppContext.SetSwitch("Switch.Microsoft.Data.SqlClient.DisableSqlServerPerformanceCounters", true);

    builder.Services.AddLogging(loggingBuilder =>
    {
        loggingBuilder.ClearProviders();
        loggingBuilder.AddNLog();
    });


    builder.Services.AddControllers();
    builder.Services.AddScoped<IEmployeeRegisterationBL, EmployeeRegisterationBL>();
    builder.Services.AddScoped<IEmployeeRegisterationRL, EmployeeRegisterationRL>();
    builder.Services.AddDbContext<EmployeeRegisterationContext>(options => options.UseSqlServer("Server=localhost,1433;Database=Employee;User ID=sa;Password=StrongPassword@123;TrustServerCertificate=True;"));

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch(Exception ex)
{
    logger.Error(ex, "Application start failed");
}
finally
{
    NLog.LogManager.Shutdown();
}

