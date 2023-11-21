using Roulette.Api.Data.BasicRepository;
using Roulette.Api.Factories.WheelOfChanceGames;
using Roulette.Api.House.Bets;

namespace Roulette.Api.Games
{
    public class RouletteGame : IRouletteGame
    {
        private readonly IBet _bet;
        private readonly IBetRepo _betRepoistory;
        public RouletteGame(IBet bet, IBetRepo betRepoistory)
        {
            _bet = bet;
            _betRepoistory = betRepoistory;
        }

        public async Task<string> PlayRouletteAsync(string region, int betAmount, int selectedNumber) 
        {
            if (selectedNumber < 0)
            {
                throw new ArgumentNullException(nameof(selectedNumber));
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentNullException(nameof(region));
            }

            int? result = null;
            //Note: Region roulette https://en.wikipedia.org/wiki/Roulette#:~:text=The%20pockets%20of%20the%20roulette,red%20and%20even%20are%20black.
            //Note: Fun fact while researching europe copied America by adding the 00 to give the odss back to the house.
            switch (region.ToLower())
            {
                case "eu":
                    var europeanRouletteWheel = WheelOfChanceFactory.CreateRouletteWheel(GameTypes.GameTypes.EuropeanRoulette);
                    //Note: Fun fact while researching europe copied America by adding the 00 to give the odss back to the house.
                    result = europeanRouletteWheel.Spin(0, 36);
                    break;
                case "us":
                    var americanRouletteWheel = WheelOfChanceFactory.CreateRouletteWheel(GameTypes.GameTypes.EuropeanRoulette);
                    result = americanRouletteWheel.Spin(0, 37);
                    break;
                default:
                    break;
            }

            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

           await _betRepoistory.AddBetAsync(new Data.Models.Bet
            {
                Amount = result.Value,
                BetNumber = selectedNumber,
            });

            if (result.Value != selectedNumber)
            {
                return $"Sorry you did not win, the winning number was {selectedNumber}, try again?";
            }

            return $"Congratulations your bet of {betAmount} and number selection of {selectedNumber} just won you {_bet.CalculatePayout(betAmount)}";
        }
    }
}
