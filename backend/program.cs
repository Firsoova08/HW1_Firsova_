// See https://aka.ms/new-console-template for more information
string name=Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Сегодня {DateTime.Now.DayOfWeek}");
Console.Write("Хотите продолжить? (y/n): ");
        string answer = Console.ReadLine()?.ToLower();
        if (answer == "y")
        {
            Console.WriteLine("Продолжаем работу...");
        }
        else if (answer == "n")
        {
            Console.WriteLine("Программа завершена. До свидания!");
        }