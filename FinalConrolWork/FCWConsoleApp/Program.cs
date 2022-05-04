using FCWLibrary.Task2;
using FCWLibrary.Task3;
using FCWLibrary.Task4;
using FCWLibrary.Task5;

//Task1();//готово
//Task2();//готово
//Task3();//готово, доделывал после контрольной
//Task4();//готово 
Task5();

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
    var myCollection = new List<int>();
    myCollection.AddNumbersInCollection(10);

    var myCollection2 = myCollection.OrderBy(x => x).TakeLast(myCollection.Count / 2).OrderByDescending(x => x).Select(x => x * x);
        
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
static void Task5()
{
    var math = new MyMathClass();

    Console.WriteLine(math.Exponentiation(-3,));
}

