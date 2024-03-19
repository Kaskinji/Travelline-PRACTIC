using System;

class Program
{

    static void Main()
    {
        DateTime TodayDate = DateTime.Now;
        Console.WriteLine("ваше имя");
        string? name = Console.ReadLine();

        Console.WriteLine("Введите количество заказа:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите название товара:");
        string? product = Console.ReadLine();

        Console.WriteLine("Введите адрес доставки:");
        string? address = Console.ReadLine();
        Console.WriteLine("\nПодтверждение введенных данных:");
        Console.WriteLine($"Здравствуйте, {name}, вы заказали {quantity} {product} на адрес {address}, верно?");
        Console.WriteLine("Это верно? (1)Yes (2)No");
        string? answer = Console.ReadLine();
        if (answer == '1'.ToString())
        {
            Console.WriteLine($"{name}, ваш заказ: {product} в коллличестве: {quantity} оформлен, ожидайте доставку по адресу: {address} к {TodayDate}");
        }
        else
        Console.WriteLine("Пожалуйста, перепроверьте свои данные");
    }
}