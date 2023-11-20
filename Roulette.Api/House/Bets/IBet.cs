namespace Roulette.Api.House.Bets
{
    public interface IBet
    {
        decimal CalculatePayout(int winningNumber);
    }

}
