using Demo.Application.DataAcsess;
using Demo.Application.Repositories;
using Demo.Infrastructure.Services.SarvarXServices;
using Demo.Infrastructure.Services.UserServices;
using Microsoft.EntityFrameworkCore;

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
builder.Services.AddScoped<ISarvarXRepository, SarvarXRepository>();
builder.Services.AddScoped<ISarvarXService, SarvarXService>();


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
