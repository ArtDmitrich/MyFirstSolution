using Lesson7Library;
bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию7. Меню:" +
    "\n1 - Задача 1 <Работа с массивом: вод с консоли и сортировка по убыванию>" +
    "\n2 - Задача 2 <Двумерный массив: поиск и вывод на экран макс значений каждого ряда>" +
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
    Console.WriteLine("---------- Задача 1 <Работа с массивом: ввод с консоли и сортировка по убыванию> ----------");
    Console.WriteLine("Создадим массив целых чисел из 6 элементов:");

    var array = new int[6];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = NumberEntry($"число для {i + 1}-го элемента массива");
    }
    Console.WriteLine();
    Console.WriteLine("Готово! У нас получился массив чисел:");
    PrintArray(array);

    Console.WriteLine("Теперь отсортируем его по убыванию и снова выведем на экран:");
    array = array.QuickSort();
    PrintArray(array);

    Console.WriteLine("--------------- Конец задачи ---------------");
}

static void Task2() //Решение Задачи2
{
    Console.WriteLine("---------- Задача 2 <Двумерный массив: поиск и вывод на экран макс значений каждого" +
        " ряда> ----------");
    Console.WriteLine("Дано: ");

    
    Console.WriteLine("--------------- Конец задачи ---------------");
}

static void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item}\t");

    Console.WriteLine();
}
static int NumberEntry(string text)
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