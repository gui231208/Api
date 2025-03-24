using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiSegundoDS.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApiSegundoDSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiSegundoDSContext") ?? throw new InvalidOperationException("Connection string 'ApiSegundoDSContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
