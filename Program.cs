using Microsoft.EntityFrameworkCore;
using portfoliotracker.Data;
using portfoliotracker.Repository;
using portfoliotracker.Service;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<PfTrackerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PfTrackerConnectionString"))
);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PfTrackerDbContext>();

    db.Database.Migrate(); // ensures schema is up to date
    await DbSeeder.SeedData(db);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
