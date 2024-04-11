class Program
{

    static void Main()
    {
        DateTime todayDate = DateTime.Now;
        Console.WriteLine("Введите ваше имя");
        string? name = Console.ReadLine();

        Console.WriteLine("Введите количество вашего товара:");
        int? productQuantity = 0;
        try
        {
           productQuantity = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод числа. Попробуйте ещё раз");
        };
            Console.WriteLine("Введите название вашего товара:");
            string? product = Console.ReadLine();

            Console.WriteLine("Введите адрес доставки:");
            string? address = Console.ReadLine();

            Console.WriteLine("\nПодтверждение введенных данных:");
            Console.WriteLine($"Здравствуйте, {name}, вы заказали {productQuantity} {product} на адрес {address}, верно?");
            Console.WriteLine("-- да, нет");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "да":
                    Console.WriteLine($"{name}, ваш заказ: {product} в количестве: {productQuantity} оформлен, ожидайте доставку по адресу: {address} к {todayDate}");
                    break;
                default:
                    Console.WriteLine("Пожалуйста, перепроверьте свои данные");
                    break;
            }     
    }
}