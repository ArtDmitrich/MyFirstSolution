using Lesson7Library;
bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию7. Меню:" +
    "\n1 - Задача 1 <Работа с массивом: ввод с консоли и сортировка по убыванию>" +
    "\n2 - Задача 2.1 <Двумерный массив: поиск и вывод на экран макс значений каждого ряда>" +
    "\n3 - Задача 2.2 <Сделал второй вариант Задачи2, но с использованием ступенчатого массива>" +
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
    Console.WriteLine("Унас есть двумерный массив (матрица):");
    var matrix = new int[3, 3]
    {
        {25, 41, 57 },
        {31, 4, 75 },
        {5, 7, 61 }
    };
    PrintMatrix(matrix);

    Console.WriteLine("Выведем на экран значения максимального элемента каждого ряда:");
    var maxIndex = Math.Sqrt(matrix.Length);


    for (int i = 0; i < maxIndex; i++)
    {
        Console.WriteLine($"Максимальный элемент на {i + 1}-й строке: {matrix.FindMaxInRow(i)}");
    }
    
    Console.WriteLine("--------------- Конец задачи ---------------");
}
//Решение Задачи2. Собственный вариант работы с матрицей. По-моему, в работе с матрицей, ступенчатый массив удобнее
//Проще работать с циклами и доступны методы массива для каждой строки
static void Task3() 
{
    Console.WriteLine("---------- Задача 2 <Альтернативный вариант работы с матрицей> ----------");
    Console.WriteLine("Унас есть матрица:");
    var matrix = new int[][]
    {
        new []{25, 41, 57 },
        new []{31, 4, 75 },
        new []{5, 7, 61 }
    };
    PrintMatrix2(matrix);

    Console.WriteLine("Выведем на экран значения максимального элемента каждого ряда:");

    for (int i = 0; i < matrix[0].Length; i++)
    {
        Console.WriteLine($"Максимальный элемент на {i + 1}-й строке: {matrix[i].Max()}");
    }

    Console.WriteLine("--------------- Конец задачи ---------------");
}

static void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item}\t");

    Console.WriteLine();
}
static void PrintMatrix(int[,] matrix)
{
    var maxIndex = Math.Sqrt(matrix.Length);

    for (int i = 0; i < maxIndex; i++)
    {
        for (int j = 0; j < maxIndex; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
static void PrintMatrix2 (int [][] matrix)
{
    for (int i = 0; i < matrix[0].Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            Console.Write($"{matrix[i][j]}\t");
        }

        Console.WriteLine();
    }

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