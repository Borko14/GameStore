using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using GameStore.Api;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
    $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
    $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
    $"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
    $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}";

builder.Services.AddDbContext<GameStoreDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
