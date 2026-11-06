using System;
using System.Collections.Generic;

class Program
{
    static List<string> users = new List<string>() { "Иван Иванов", "Анна Петрова", "Сергей Сидоров" };

    static List<string> books = new List<string>() { "Дежавю", "Кэрри", "1984", "Гарри Поттер", "Цветы для Элджернона" };

    static void ChooseBook()
    {
        Console.WriteLine("список книг:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i]);
        }

        Console.WriteLine("введите номер книги:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("вы взяли книгу: " + books[number - 1]);
    }
    static void CreateCard(string fullName)
    {
        users.Add(fullName);
        Console.WriteLine("карточка создана!");
    }

    static void Main()
    {
        Console.WriteLine("введите имя:");
        string name = Console.ReadLine();

        Console.WriteLine("введите фамилию:");
        string surname = Console.ReadLine();

        string fullName = name + " " + surname;

        if (users.Contains(fullName))
        {
            Console.WriteLine("вы есть в списке! Предлагаем вам книгу.");
            ChooseBook();
        }
        else
        {
            Console.WriteLine("вас нет в списке. Завести карточку? (да/нет)");
            string answer = Console.ReadLine();

            if (answer == "да")
            {
                CreateCard(fullName);
                Console.WriteLine("теперь можете взять книгу.");
                ChooseBook();
            }
            else
            {
                Console.WriteLine("без карточки книгу выдать нельзя.");
            }
        }

        Console.ReadLine();
    }
}