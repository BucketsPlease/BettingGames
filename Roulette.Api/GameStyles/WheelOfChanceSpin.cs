namespace Roulette.Api.GameStyles
{
    public class WheelOfChanceSpin : IWheelOfChanceSpin
    {

        private readonly Random random = new Random();

        public int Spin(int startIndex, int endIndex)
        {
            return random.Next(startIndex, endIndex + 1);
        }
    }
}
