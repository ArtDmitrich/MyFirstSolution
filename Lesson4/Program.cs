bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию4. Меню:" +
    "\n1 - Задача 1 <Определение промежутка чисел>\t2 - Задача 2 <Поиск чисел кратных заданному>" +
    "\n3 - Выход из программы" +
    "\nВыберите пункт меню:");

    switch (Console.ReadLine())
    {
        case "1":
            Task1();
            break;
        case "2":
            Task2();
            break;        
        case "3":
            Console.WriteLine("Да пабачэння!");
            menuCheck = false;
            break;
        default:
            Console.WriteLine("Пункт меню не найден.");
            break;
    }
    Console.WriteLine();
}
while (menuCheck);
Console.ReadKey();
static void Task1() //Решение Задачи1
{
    Console.WriteLine("---------- Задача 1 <Определение промежутка чисел> ----------");
    Console.WriteLine("Дано: у нас есть три промежутка чисел:" +
        "\nот 0 до 30, от 31 до 60 и от 61 до 100");

    var number = NumberEntry("число");

    if (number <= 30 && number >= 0)
    {
        Console.WriteLine("Число относится к промежутку от 0 до 30");
    }    
    else if (number <= 60 && number >= 31)
    {
        Console.WriteLine("Число относится к промежутку от 31 до 60");
    }
    else if (number <= 100 && number >= 61)
    {
        Console.WriteLine("Число относится к промежутку от 61 до 100");
    }
    else
    {
        Console.WriteLine("Я такого числа не знаю");
    }

    Console.WriteLine("--------------- Конец задачи ---------------");
}
static int NumberEntry(string text) //метод для ввода чисел. Задача 1
{
    bool result;
    int number;

    do
    {
        Console.WriteLine($"Введите {text}:");
        result = int.TryParse(Console.ReadLine(), out number);
        if (result == false)
        {
            Console.WriteLine("Некорректный ввод. Повторите попытку.");
        }
        Console.WriteLine();
    }
    while (!result);

    return number;
}
static void Task2() //Решение Задачи2
{
    Console.WriteLine("---------- Задача 2 <Поиск чисел кратных заданному> ----------");
    var number = NumberEntry("число для проверки кратности");
    var rangeStart = NumberEntry("начало диапазона");
    var rangeEnd = NumberEntry("конец диапазона");    

    Console.WriteLine($"Приступаем к поиску чисел кратных {number} в диапазоне от {rangeStart} до {rangeEnd}");
    string? result = null;

    while (true)
    {
        if(rangeStart % number == 0)
        {
            result += $"{rangeStart}, ";
        }

        if (rangeStart == rangeEnd)
        {
            break;
        }

        rangeStart++;        
    }

    if(result == null)
    {
        result = $"В заданном диапазоне нет чисел кратных {number}";
    }
    else
    {
        result = result.Remove(result.Length - 2);
    }

    Console.WriteLine(result);
    Console.WriteLine("--------------- Конец задачи ---------------");
}