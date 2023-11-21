using Microsoft.EntityFrameworkCore;
using Roulette.Api.Data.Contexts;
using Roulette.Api.Data.Models;

namespace Roulette.Api.Data.BasicRepository
{
    public class BetRepo : IBetRepo
    {
        private readonly BettingContext _context;

        public BetRepo(BettingContext context)
        {
            _context = context;
        }

        public async Task AddBetAsync(Bet bet)
        {
            _context.Bets.Add(bet);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Bet>> GetPreviousBetsAsync()
        {
            return await _context.Bets.ToListAsync();
        }
    }
}
