namespace Roulette.Api.Games
{
    public interface IRouletteGame
    {
        Task<string> PlayRouletteAsync(string region, int betAmount, int selectedNumber);
    }
}