using Demo.Application.DataAcsess;
using Demo.Application.Repositories;
using Demo.Application.Repositories.KamronbekXRepositories;
using Demo.Application.Repositories.OrderRepositories;
using Demo.Application.Repositories.PersonRepositories;
using Demo.Infrastructure.Services.KamronbekXServices;
using Demo.Infrastructure.Services.OrdersService;
using Demo.Infrastructure.Services.PersonServices;
using Demo.Infrastructure.Services.UserServices;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DemoDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DemoStagingConnection"));
});

builder.Services.AddScoped<IDemoRepository, DemoRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IKamronbekRepository, KamronbekXRepository>();
builder.Services.AddScoped<IKamronbekXService, KamronbekXService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPersonService, PersonService>(); 

builder.Services.AddControllersWithViews()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
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
