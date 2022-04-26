using FCWLibrary.Task2;
using FCWLibrary.Task3;
using FCWLibrary.Task4;

//Task1();//готово
//Task2 - готово
Task3();
//Task4();//готово 
static void Task1()
{
    int[,] array = new int[3, 3]
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 },
    };

    for (int i = 0; i < Math.Sqrt(array.Length); i++)
    {
        for (int j = i + 1; j < Math.Sqrt(array.Length); j++)
        {
            array[i, j] = 1;
        }
    }

    for (int i = 0; i < Math.Sqrt(array.Length); i++)
    {
        for (int j = 0; j < Math.Sqrt(array.Length); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
static void Task3()
{
    //не готово. вообще не понял суть задачи про какие половины коллекций и как их брать
    //При помощи LINQ отсортировать коллекцию по возрастанию и вернуть вторую половину
    //коллекции (округляя вверх если число элементов нечётное) остортированную по убыванию,
    //где каждый элемент будет возведён в квадрат.
    var myCollection = new List<int>();
    myCollection.AddNumbersInCollection(30);

    var myCollection2 = myCollection.OrderBy(x => x);
    var myCollection3 = myCollection.OrderByDescending(x => x * x);
    for (int i = myCollection.Count / 2; i < myCollection.Count; i++)
    {

    }
    Console.WriteLine();
}
static void Task4()
{
    var list = new List<SomeClass>()
    {
        new SomeClass(),
        new SomeClass(),
        new SomeClass()
    };

    for (int i = 0; i < 20; i++)
    {
        var random = new Random();

        list[random.Next(0, 3)].SomeMethod();
    }
}

