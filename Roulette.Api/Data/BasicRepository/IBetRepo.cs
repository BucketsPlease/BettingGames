using Roulette.Api.Data.Models;

namespace Roulette.Api.Data.BasicRepository
{
    public interface IBetRepo
    {
        Task AddBetAsync(Bet bet);

        Task<List<Bet>> GetPreviousBetsAsync();
    }
}