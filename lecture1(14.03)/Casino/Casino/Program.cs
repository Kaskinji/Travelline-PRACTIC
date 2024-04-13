using System;

class Program
{
    static void Main()
    {
        int balance = 10000;

        while (balance > 0)
        {
            Console.WriteLine("ваш баланс: " + balance);
            Console.Write("введите вашу ставку: ");
            try
            {
                int bet = Convert.ToInt32(Console.ReadLine());

                if (bet >= balance)
                {
                    Console.WriteLine("Вы не можете поставить больше вашего баланса");
                    continue;
                }

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 21);

                if (randomNum >= 18)
                {
                    int multiplicator = rnd.Next(1, 17);
                    int win = bet * (1 + (multiplicator * (randomNum % 17)));
                    balance += win;
                    Console.WriteLine("вы выиграли " + win + " рублей!");
                }
                else
                {
                    balance -= bet;
                    Console.WriteLine("Вы проиграли. Попробуйте снова.");

                }
                if (balance == 0)
                {
                    Console.WriteLine("Игра окончена.Ваш баланс = 0!");
                }
            }
            catch (FormatException e)
            { Console.WriteLine("Ошибка ввода числа. Пожалуйста, введите корректное число."); }
        }
    }
}