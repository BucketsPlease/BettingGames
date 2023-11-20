namespace Roulette.Api.Games
{
    public interface IRouletteGame
    {
        string PlayRoulette(string region, int bet, int selectedNumber);
    }
}