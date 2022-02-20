bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию3. Меню:" +
    "\n1 - Задача 1 <Площадь поверхности конуса>\t2 - Задача 2 <Базовые операции>" +
    "\n3 - Задача 3 <Нахождение НОД>\t4 - Выход из программы");
    
    switch (Console.ReadLine())
    {
        case "1" :
            Task1();
            break;
        case "2" :
            Task2();
            break;
        case "3":
            Task3();
            break;
        case "4":
            menuCheck = false;
            break;
        default :
            Console.WriteLine("Пункт меню не найден.");
            break;
    }
    Console.WriteLine();
}
while (menuCheck);

static void Task1() // Решение Задачи1
{
    Console.WriteLine("Для нахождения площади поверхности круглого конуса," +
    "\nнеобходимо ввести параметры: r – радиус основания и l – образующая." +
    "\nВсе расчеты проводятся в сантиметрах");

    Console.WriteLine("Длина радиуса");
    var radius = NumberEntryUnsigned();
    Console.WriteLine("Длина образующей");
    var generatrix = NumberEntryUnsigned();
    Console.WriteLine($"Введенные данные: радиус - {radius}см, образующая - {generatrix}см");
    Console.WriteLine($"Площадь конуса равна {Math.PI * radius * (radius + generatrix)}см²");
    Console.WriteLine();
}

static int NumberEntryUnsigned() //метод для ввода чисел. Задача 1
{    
    bool result;
    int number;

    do
    {
        Console.WriteLine("Введите число:");
        result = int.TryParse(Console.ReadLine(), out number);
        if (number < 0 || result == false)
        {
            result = false;
            Console.WriteLine("Некорректный ввод. Повторите попытку.");
        }
        Console.WriteLine();
    }
    while (!result);
   
    return number;
}

static void Task2() // Решение. Задачи2
{
    Console.WriteLine("Имеется 3 переменные типа int x = 14, y = 1, и z = 5");
    int x = 14;
    int y = 1;
    int z = 5;

    Console.WriteLine("Результатом операции x += y - x++ * z; будет:");
    x += y - x++ * z;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");

    Console.WriteLine("Результатом операции z = --x – y * 5; будет:");
    z = --x - y * 5;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");

    Console.WriteLine("Результатом операции y /= x + 5 % z; будет:");
    y /= x + 5 % z;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");

    Console.WriteLine("Результатом операции z = x++ + y * 5; будет:");
    z = x++ + y * 5;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");

    Console.WriteLine("Результатом операции x = y - x++ * z; будет:");
    x = y - x++ * z;
    Console.WriteLine($"x = {x}, y = {y}, z = {z}");
    Console.WriteLine();
}

static void Task3() //Решение Задачи3
{
    Console.WriteLine("Приступаем к нахождению НОД группы чисел.");
    List<int> listOfNumbers = FillingListOfNumbers();
    int temp = listOfNumbers[0];

    for (int i = 1; i < listOfNumbers.Count; i++)
    {
        temp = FindGreatestCommonDivisor(Math.Abs(temp), Math.Abs(listOfNumbers[i]));
    }

    Console.WriteLine("Итоговая группа чисел:");
    PrintListOfNumber(listOfNumbers);
    Console.WriteLine($"НОД для группы чисел равен: {temp}");
    Console.WriteLine();
}

static List<int> FillingListOfNumbers () // Метод заполнения коллекции. Задача3
{
    Console.WriteLine("Для ввода чисел, следуйте инструкциям (необходимо ввести минимум 2 числа)");

    List<int> listOfNumbers = new();
    bool menuCheck = true;

    do
    {
        Console.WriteLine("Меню добавления чисел в группу:" +
            "\n1 - добавить число\t2 - отобразить группу чисел\t3 - закончить заполнение группы чисел");
        switch (Console.ReadLine())
        {
            case "1":
                listOfNumbers.Add(NumberEntry());
                break;
            case "2":
                PrintListOfNumber(listOfNumbers);
                break;
            case "3":
                if (listOfNumbers.Count < 2)
                {
                    Console.WriteLine("Введено меньше 2 чисел");
                    break;
                }
                menuCheck = false;
                break;
            default:
                Console.WriteLine("Пункт меню не найден.");
                break;
        }
    }
    while (menuCheck);

    return listOfNumbers;
}

static int NumberEntry() //метод для ввода чисел. Задача 3. не разобрался почему не получилось реализовать перегрузку метода для ввода чисел
{
    bool result;
    int number;

    do
    {
        Console.WriteLine("Введите число:");
        result = int.TryParse(Console.ReadLine(), out number);
        if (number == 0 || result == false)
        {
            result = false;
            Console.WriteLine("Некорректный ввод. Повторите попытку.");
        }
        Console.WriteLine();
    }
    while (!result);

    return number;
}

static void PrintListOfNumber (List<int> list) // метод вывода коллекции на консоль. Задача3
{
    foreach (int n in list)
        Console.Write($"{n}\t");

    Console.WriteLine();
}

static int FindGreatestCommonDivisor(int firstNumber, int secondNumber) // Метод нахождения НОД двух чисел
{    
    if (secondNumber > firstNumber)
    {
        var temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }
    int number = 1;

    do
    {
        int remainder = firstNumber % secondNumber;
        if (remainder == 0)
        {
            number = secondNumber;
        }

        firstNumber = secondNumber;
        secondNumber = remainder;
    } while (secondNumber != 0);

    return number;
}