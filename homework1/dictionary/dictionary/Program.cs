using System;
using System.Collections.Generic;

class Translator
{
    private static Dictionary<string, string> translations = new Dictionary<string, string>();

    static void Main()
    {
        Console.WriteLine("Welcome to Translator!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. AddTranslation");
            Console.WriteLine("2. RemoveTranslation");
            Console.WriteLine("3. ChangeTranslation");
            Console.WriteLine("4. Translate");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTranslation();
                    break;
                case "2":
                    RemoveTranslation();
                    break;
                case "3":
                    ChangeTranslation();
                    break;
                case "4":
                    Translate();
                    break;
                default:
                    Console.WriteLine("Неверно введённые данные. Повторите попытку.");
                    break;
            }
        }
    }

    static void AddTranslation()
    {
        Console.Write("Введите слово на русском ");
        string word = Console.ReadLine();

        Console.Write("Введите перевод на английском ");
        string translation = Console.ReadLine();

        translations[word] = translation;

        Console.WriteLine("Перевод сохранён!");
    }

    static void RemoveTranslation()
    {
        Console.Write("введите слово на русском, которое хотите удалить: ");
        string word = Console.ReadLine();

        if (translations.ContainsKey(word))
        {
            translations.Remove(word);
            Console.WriteLine("перевод слова удалён!");
        }
        else
        {
            Console.WriteLine("Перевод не найден.");
        }
    }

    static void ChangeTranslation()
    {
        Console.Write("введите слово на русском, у которого желаете сменить превод: ");
        string word = Console.ReadLine();

        if (translations.ContainsKey(word))
        {
            Console.Write("введите новый перевод: ");
            string newTranslation = Console.ReadLine();
            translations[word] = newTranslation;
            Console.WriteLine("перевод изменён успешно!");
        }
        else
        {
            Console.WriteLine("Перевод не найден.");
        }
    }

    static void Translate()
    {
        Console.Write("Введите слово на русском для перевода: ");
        string word = Console.ReadLine();

        if (translations.ContainsKey(word))
        {
            Console.WriteLine($"перевод: {translations[word]}");
        }
        else
        {
            Console.WriteLine("Перевод не найден.");
        }
    }
}