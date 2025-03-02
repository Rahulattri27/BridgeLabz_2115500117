using BusinessLayer.Services;
using BusinessLayer.Interface;
using RepositoryLayer.Services;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
AppContext.SetSwitch("Switch.Microsoft.Data.SqlClient.UseManagedNetworkingOnMacOS", true);
AppContext.SetSwitch("Switch.Microsoft.Data.SqlClient.DisableSqlServerPerformanceCounters", true);


builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloBL,RegisterHelloBL>();
builder.Services.AddScoped<IRegisterHelloRL,RegisterHelloRL>();
var connectionstring = builder.Configuration.GetConnectionString("Sqlconnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionstring));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

