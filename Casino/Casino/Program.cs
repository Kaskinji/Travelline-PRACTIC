using System;

class Program
{
    static void MAIN()
    {
        int balance = 10000;

        while (balance > 1)
        {
            Console.WriteLine("Your balance: " + balance);
            Console.Write("Enter your bet: ");
            int bet = Convert.ToInt32(Console.ReadLine());

            if (bet > balance)
            {
                Console.WriteLine("You cannot bet more than your balance. Try again.");
                continue;
            }

            Random rnd = new Random();
            int randomNum = rnd.Next(1, 21);

            if (randomNum >= 18)
            {
                int multiplicator = rnd.Next(1, 17);
                int win = bet * (1 + (multiplicator * (randomNum % 17)));
                balance += win;
                Console.WriteLine("You won " + win + " units!");
            }
            else
            {
                balance -= bet;
                Console.WriteLine("You lost. Try again.");
            }
        }

        Console.WriteLine("Game over. Your balance is 0. Thanks for playing!");
    }
}