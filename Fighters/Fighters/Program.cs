using Fighters.Models.Fighters;

namespace Fighters
{
    public class Program
    {
        public static void Main()
        {
            var firstFighter = FighterCreator.CreateFighter();
            var secondFighter = FighterCreator.CreateFighter();
            var master = new GameMaster();
            var winner = master.PlayAndGetWinner(firstFighter, secondFighter);

            Console.WriteLine($"Выигрывает  {winner.Name}");
        }
    }
}