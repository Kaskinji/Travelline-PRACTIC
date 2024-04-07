using Fighters.Models.Armors;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using Fighters.Models.Classes;
using System.Diagnostics;


namespace Fighters
{

    public static class AddFighter
    {
        public static Fighter NewFighter()
        {
            Console.WriteLine("Выберете имя персонажа:");
            string name = Console.ReadLine() ?? throw new Exception("Ошибка ввода имени");
            IRace newRace = MyRace();
            IClass newClass = MyClass();
            IWeapon newWeapon = MyWeapon();
            IArmor newArmor = MyArmor();
            return new Fighter(name, newRace, newClass, newArmor, newWeapon);
        }
        private static IRace MyRace()
        {
            Console.WriteLine("Выберите расу:");
            Console.WriteLine("1. Норд");
            Console.WriteLine("2. Аргонианин");
            Console.WriteLine("3. Тёмный эльф");
            Console.WriteLine("4. Каджит");

            return GetInput(1, 4) switch
            {
                1 => new Nord(),
                2 => new Argonianin(),
                3 => new Dark_Elf(),
                4 => new Kadjite(),
            };
        }

        private static IClass MyClass()
        {
            Console.WriteLine("Выберите класс:");
            Console.WriteLine("1. Воин");
            Console.WriteLine("2. Маг");
            Console.WriteLine("3. Ассасин");
            Console.WriteLine("4. Паладин");

            return GetInput(1, 4) switch
            {
                1 => new Warrior(),
                2 => new Wizard(),
                3 => new Assassin(),
                4 => new Paladin(),
            };
        }

        private static IWeapon MyWeapon()
        {
            Console.WriteLine("Выберите оружие:");
            Console.WriteLine("1. Меч");
            Console.WriteLine("2. Топор");
            Console.WriteLine("3. Копьё");
            Console.WriteLine("4. Лук");

            return GetInput(1, 4) switch
            {
                1 => new Sword(),
                2 => new Axe(),
                3 => new Spear(),
                4 => new Bow(),
            };
        }

        private static IArmor MyArmor()
        {
            Console.WriteLine("Выберите снаряжение:");
            Console.WriteLine("1. Щит");
            Console.WriteLine("2. Броня");
            Console.WriteLine("3. Шлем");
            Console.WriteLine("4. Без снаряжения");

            return GetInput(1, 4) switch
            {
                1 => new Shield(),
                2 => new Hauberk(),
                3 => new Helmet(),
                4 => new None(),
            };
        }

        private static int GetInput(int minValue, int maxValue)
        {
            int choice = 0;
            while (true)
            {
                Console.Write("Выберите опцию: ");
                if (!int.TryParse(Console.ReadLine(),out choice) || choice < minValue || choice > maxValue)
                {
                    Console.WriteLine($"Введите число от {minValue} до {maxValue}!");
                    continue;
                }
                break;
            }
            return choice;
        }

    }
    //=================================================================================================================================//
    public class GameMaster
    {
        public IFighter PlayAndGetWinner(IFighter firstFighter, IFighter secondFighter)
        {
            int round = 1;
            while (true)
            {
                Console.WriteLine($"Раунд {round++}.");

                // First fights second
                if (FightAndCheckIfOpponentDead(firstFighter, secondFighter))
                {
                    return firstFighter;
                }

                // Second fights first
                if (FightAndCheckIfOpponentDead(secondFighter, firstFighter))
                {
                    return secondFighter;
                }

                Console.WriteLine();
            }

            throw new UnreachableException();
        }

        private bool FightAndCheckIfOpponentDead(IFighter roundOwner, IFighter opponent)
        {
            int damage = roundOwner.CalculateDamage();
            opponent.TakeDamage(damage);

            Console.WriteLine(

                $"Боец {opponent.Name} получает {damage} урона. " +
                $"Количество жизней: {opponent.CurrentHealth}");

            return opponent.CurrentHealth < 1;
        }
        //=================================================================================================//

        public class Program
        {
            public static void Main()
            {
                var firstFighter = AddFighter.NewFighter();
                var secondFighter = AddFighter.NewFighter();

                var master = new GameMaster();
                var winner = master.PlayAndGetWinner(firstFighter, secondFighter);

                Console.WriteLine($"Выигрывает  {winner.Name}");

            }
        }
    }
}