using FinanceService.Services;
using FinanceService.Repositories;
using FinanceService.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<StockDbContext>();
builder.Services.AddAutoMapper(typeof(Program));  // Register AutoMapper
builder.Services.AddScoped<IStockRepository, StockRepository>();    // Register DAL
builder.Services.AddScoped<IStockService, StockService>();       // Register BAL
builder.Services.AddGrpc();
// builder.Services.AddSingleton<IConfiguration>(provider =>
//             new ConfigurationBuilder()
//                 .AddJsonFile("appsettings.json")
//                 .Build());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<IsCarValueForMoneyService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
