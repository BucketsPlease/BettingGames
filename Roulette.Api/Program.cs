using Microsoft.EntityFrameworkCore;
using Roulette.Api.Data.BasicRepository;
using Roulette.Api.Data.Contexts;
using Roulette.Api.ExceptionHandlers;
using Roulette.Api.Games;
using Roulette.Api.GameStyles;
using Roulette.Api.House.Bets;

var builder = WebApplication.CreateBuilder(args);

//db
builder.Services.AddDbContext<BettingContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IWheelOfChanceSpin, WheelOfChanceSpin>();        
builder.Services.AddScoped<IRouletteGame, RouletteGame>();
builder.Services.AddScoped<IBet, RouletteBet>();
builder.Services.AddScoped<IBetRepo , BetRepo>();

var app = builder.Build();

//middleware
app.UseMiddleware<GlobalExceptionHandler>();

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
