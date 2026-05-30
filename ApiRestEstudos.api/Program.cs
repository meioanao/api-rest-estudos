using Microsoft.EntityFrameworkCore;
using ApiRestEstudos.Api.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=locationsdb;Username=postgres;Password=12345678"));

var app = builder.Build();


app.MapControllers();

// app.UseHttpsRedirection(); 

app.Run();