using Fighters.Models.Fighters;

namespace Fighters
{
    public class Program
    {
        public static void Main()
        {
            IFighter firstFighter = FighterCreator.CreateFighter();
            IFighter secondFighter = FighterCreator.CreateFighter();
            GameMaster master = new GameMaster();
            IFighter winner = master.PlayAndGetWinner(firstFighter, secondFighter);

            Console.WriteLine($"Выигрывает  {winner.Name}");
        }
    }
}