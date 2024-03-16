using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ваше имя");
        string name = Console.ReadLine();

        Console.WriteLine("Введите количество заказа:");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите товар:");
        string product = Console.ReadLine();

        Console.WriteLine("Введите адрес доставки:");
        string address = Console.ReadLine();

        Console.WriteLine("\nПодтверждение введенных данных:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Количество заказа: {quantity}");
        Console.WriteLine($"Товар: {product}");
        Console.WriteLine($"Адрес доставки: {address}");
    }
}