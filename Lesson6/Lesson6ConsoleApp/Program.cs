using Lesson6Library;

var books1 = new List<Book>()
{
    new Book ("Война и мир", 870),
    new Book ("Dante`s Hell", 340),
    new Book ("Азбука", 32),
    new Book ("Отцы и дети", 270),
    new Book ("Выживание в лесу", 135)
};
var library1 = new Library ("Library1", books1);

bool menuCheck = true;

do
{
    Console.WriteLine("Домашнее задание по Занятию6. Меню:" +
    "\n1 - Поиск книги по номеру" +
    "\n2 - Поиск книги по названию" +
    "\n3 - Поиск самой 'толстой' книги" +
    "\n4 - Сортировка массива чисел по возрастанию методом 'Пузырек'" +
    "\n5 - Выход из программы" +
    "\nВыберите пункт меню:");

    switch (Console.ReadLine())
    {
        case "1":
            Task1(library1);
            break;
        case "2":
            Task2(library1);
            break;
        case "3":
            Task3(library1);
            break;
        case "4":
            Task4();
            break;
        case "5":
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

static void Task1(Library library)
{
    Console.WriteLine("---------- Выбран поиск книги по номеру ----------");

    var result = library.FindBook(NumberEntry("номер книги"));
    Console.WriteLine(result);

    Console.WriteLine("------------------------------");
}
static void Task2(Library library)
{
    Console.WriteLine("---------- Выбран поиск книги по названию ----------");

    Console.WriteLine("Введите название книги:");

    var bookName = Console.ReadLine();
    if (bookName == null)
    {
        Console.WriteLine("Название книги не введено");
        return;
    }

    var result = library.FindBook(bookName);
    Console.WriteLine(result);

    Console.WriteLine("--------------- Конец задачи ---------------");
}

static void Task3(Library library)
{
    Console.WriteLine("---------- Выбран поиск самой 'толстой' книги ----------");

    var result = library.FindThickBook(library.GetBooksFromLibrary());
    Console.WriteLine($"Самая толстая книга в библиотеке: {result}");

    Console.WriteLine("--------------- Конец задачи ---------------");
}
static void Task4()
{
    Console.WriteLine("---------- Сортировка массива с помощью алгоритма пузырек ----------");

    Console.WriteLine("Дано: неотсортированный массив целых чисел");
    var array = new [] {3, 7, 65, -4, 34, 99, 101, 34, 21, 65};
    PrintArray(array);

    Console.WriteLine("Отсортируем по возрастанию и выведем на экран");
    array = array.BubleSort();
    PrintArray(array);

    Console.WriteLine("--------------- Конец задачи ---------------");
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
static void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item}\t");

    Console.WriteLine();
}