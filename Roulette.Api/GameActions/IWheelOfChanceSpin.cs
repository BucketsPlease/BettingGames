namespace Roulette.Api.GameActions
{
    public interface IWheelOfChanceSpin
    {
        int Spin(int startIndex, int endIndex);
    }
}