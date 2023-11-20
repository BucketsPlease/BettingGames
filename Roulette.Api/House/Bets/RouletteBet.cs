namespace Roulette.Api.House.Bets
{
    public class RouletteBet : IBet
    {
        public decimal CalculatePayout(int amount)
        {
            return amount * 35; // The payout ratio for a straight bet in roulette
        }
    }
}
