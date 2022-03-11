using Sales.Application;
using Sales.DataAccess;
using Sales.Domain;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
