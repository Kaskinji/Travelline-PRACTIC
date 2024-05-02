using Fighters.Models.Fighters;
using System.Diagnostics;

namespace Fighters
{
    public class GameMaster
    {
        public IFighter PlayAndGetWinner(IFighter firstFighter, IFighter secondFighter)
        {
            int round = 1;
            while (true)
            {
                Console.WriteLine($"Раунд {round++}.");

                if (firstFighter.Speed > secondFighter.Speed )
                {
                    Fight(firstFighter, secondFighter);
                    Fight(secondFighter, firstFighter);
                }
                else
                {
                    Fight(secondFighter, firstFighter);
                    Fight(firstFighter, secondFighter);
                }

                if (secondFighter.IsDead())
                {
                    return firstFighter;
                }
                else
                {
                    return secondFighter;
                }
            }

            throw new UnreachableException();
        }

        private void Fight(IFighter roundOwner, IFighter opponent)
        {
            int damage = roundOwner.CalculateDamage();
            opponent.TakeDamage(damage);

            Console.WriteLine(
                $"Боец {opponent.Name} получает {damage} урона. " +
                    $"Количество жизней: {opponent.CurrentHealth}");      
        }
    }
}
