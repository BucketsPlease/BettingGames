using Roulette.Api.GameActions;
using Roulette.Api.Games.GameTypes;

namespace Roulette.Api.Factories.WheelOfChanceGames
{
    public static class WheelOfChanceFactory
    {
        public static WheelOfChanceSpin CreateRouletteWheel(GameTypes gameType)
        {
            switch (gameType)
            {
                case GameTypes.EuropeanRoulette:
                    return new WheelOfChanceSpin();
                case GameTypes.AmericanRoulette:
                    return new WheelOfChanceSpin(); 
                default:
                    throw new ArgumentException("Invalid game type");
            }
        }
    }
}
