namespace Roulette.Api.House.Bets.GameBetTypes
{
    public enum RouletteBetType
    {
        Straight, // Bet on a single number
        Single,//Bet on a single number
        Split,//Bet on two vertically/horizontally adjacent numbers
        Street,//Bet on three consecutive numbers in a horizontal line
        Corner,//Bet on four numbers that meet at one corner
        Square,//Bet on four numbers that meet at one corner
        SixLine,//Bet on six consecutive numbers that form two horizontal lines
        DoubleStreet, //A three-number bet that involves at least one zero: 0-1-2 (either layout); 0-2-3 (single-zero only); 0-00-2 and 00-2-3 (double-zero only)
        Trio, //A three-number bet that involves at least one zero: 0-1-2 (either layout); 0-2-3 (single-zero only); 0-00-2 and 00-2-3 (double-zero only)
        Basket, //A three-number bet that involves at least one zero: 0-1-2 (either layout); 0-2-3 (single-zero only); 0-00-2 and 00-2-3 (double-zero only)
        FirstFour,//Bet on 0-1-2-3 (Single-zero layout only)
        TopLine //Bet on 0-00-1-2-3 (Double-zero layout only)
    }
}
