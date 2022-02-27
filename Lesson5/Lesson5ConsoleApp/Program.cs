using Lesson5Library;

bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию5. Меню:" +
    "\n1 - Задача 1 <Метод класса ArrayWorker для инвертирования массива>" +
    "\n2 - Задача 2 <Метод класса ArrayWorker для добавления элемента по индексу в массив>" +
    "\n3 - Задача 3 <Класс Cone и его методы>" +
    "\n4 - Выход из программы" +
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
            Task3();
            break;
        case "4":
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


static void Task1()
{
    Console.WriteLine("---------- Задача 1 <Метод класса ArrayWorker для инвертирования массива> ----------");
    Console.WriteLine("У нас есть массив:");
    var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    PrintArray(array);

    Console.WriteLine("Создадим один экземпляр класса ArrayWorker.\nВызовем метод класса для инвертирования " +
        "массива и выведем результат на экран:");

    var arrayWorker = new ArrayWorker();
    array = arrayWorker.ReverseArray(array);
    PrintArray(array);   

    Console.WriteLine("--------------- Конец задачи ---------------");
}
static void Task2()
{
    Console.WriteLine("---------- Задача 1 <Метод класса ArrayWorker для добавления элемента по индексу " +
        "в массив> ----------");
    Console.WriteLine("У нас есть массив:");

    var array = new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
    PrintArray(array);

    Console.WriteLine("Создадим один экземпляр класса ArrayWorker.\nВызовем метод класса для добавления " +
        "элемента по индексу в массив и выведем результат на экран:");


    var index = NumberEntry("индекс элемента в массиве, в который мы вставим число");
    var number = NumberEntry("число, которое мы поставим на заданный индекс");
    Console.WriteLine($"Мы пробуем добавить число {number} по индексу {index}:");

    var arrayWorker = new ArrayWorker();
    array = arrayWorker.AddInArray(array, index, number);    
    PrintArray(array);

    Console.WriteLine("--------------- Конец задачи ---------------");
}
static void Task3()
{
    Console.WriteLine("---------- Задача 3 <Класс Конус и его методы> ----------");
    Console.WriteLine("Унас есть класс <Конус>. Создадим экземпляр этого класса:");

    var radius = NumberEntry("радиус основания конуса");
    var height = NumberEntry("высоту конуса");
    Console.WriteLine($"Мы создали экземпляр класса Cone с высотой {height} и радиусом основания {radius}.");

    var cone = new Cone(radius, height);
    var baseArea = cone.BaseArea();
    var totalSurfaceArea = cone.TotalSurfaceArea();

    Console.WriteLine($"Площадь поверхности основания данного конуса равна: {baseArea:f}");
    Console.WriteLine($"Полная площадь поверхности данного конуса равна: {totalSurfaceArea:f}");
    Console.WriteLine("--------------- Конец задачи ---------------");
}
static void PrintArray (int[] array) 
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
