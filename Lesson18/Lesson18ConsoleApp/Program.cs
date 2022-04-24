Console.WriteLine(Task1());
Task2();
Task3();
Task4();

static string Task1()
{
    //Дан символ "<любой, сами решите>" и строка с текстом. Найти слово, которое заканчивается на данный символ.
    //Если слова нет, то долно вернуться null. Если больше одного -> исключение.
    var symbol = "q";
    var text = "LINQ ( Language-Integrated Query ) представляет простой и удобный язык запросов к" +
        " источнику данных";
    try
    {
        var word = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
        SingleOrDefault((word) => word.ToUpper().EndsWith(symbol.ToUpper()));
        if (word == null)
        {
            return $"в тексте нет слова, заканчивающегося на {symbol}";
        }   
        return word;
    }
    catch (Exception)
    {
        return $"В тексте больше одного слова, заканчивающихся на {symbol}";
    }
}
static void Task2()
{
    // Дано [5,8,0,-1,6,4,-1,-3]. Найти количество ее положительных элементов, а также их среднее значение. 
    var array = new[] { 5, 8, 0, -1, 6, 4, -1, -3 };
    Console.WriteLine($"количество чисел больше нуля: {array.Where(a => a >= 0).Count()}, " +
        $"среднее арифметическое этих чисел: {array.Where(a => a >= 0).Average()}");
    //или
    var resultArray = array.Where(a => a >= 0);
    Console.WriteLine($"количество чисел больше нуля: {resultArray.Count()}, " +
       $"среднее арифметическое этих чисел: {resultArray.Average()}");
}
static void Task3()
{
    //дана строка "Женя скоро будет свободен, а у вас все только начинается"
    //при помощи Linq убрать из строки все 'о'. Вывести на консоль результат.
    var text2 = "Женя скоро будет свободен, а у вас все только начинается";
    var result = text2.Where(c => c != 'о');

    foreach (var item in result)
    {
        Console.Write(item);
    }
}
static void Task4()
{
    //придумать задачу, в которой придется использовать join, where, take, skip и select.
    //Написать ваше реализацию.
}