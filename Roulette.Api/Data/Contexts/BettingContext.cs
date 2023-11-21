using Microsoft.EntityFrameworkCore;
using Roulette.Api.Data.Models;

namespace Roulette.Api.Data.Contexts
{
    public class BettingContext : DbContext
    {
        public DbSet<Bet> Bets { get; set; }

        public BettingContext(DbContextOptions<BettingContext> options) : base(options)
        {
        }
    }
}
