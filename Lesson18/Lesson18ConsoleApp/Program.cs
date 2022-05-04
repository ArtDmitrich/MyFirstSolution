using Lesson18Library;

Task1();
Task2();
Task3();
Task4();

static void Task1()
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
            Console.WriteLine($"в тексте нет слова, заканчивающегося на {symbol}");
        }
        Console.WriteLine("на букву {0} завканчивается слово {1}", symbol, word);
    }
    catch (Exception)
    {
        Console.WriteLine($"В тексте больше одного слова, заканчивающихся на {symbol}");
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
    //Задача: есть список людей и список фамилий. на основании списка фамилий, найти всех членов каждой семьи
    //Написать ваше реализацию.
    var peoples = new List<People>
    {
        new Parent { LastName = "Иванов(а)", FirstName = "Игорь"},
        new Parent { LastName = "Иванов(а)", FirstName = "Светлана"},
        new Parent { LastName = "Дедько", FirstName = "Степан"},
        new Child { LastName = "Иванов(а)", FirstName = "Инна"},
        new Child { LastName = "Дедько", FirstName = "Евгения"},
        new Parent { LastName = "Дедько", FirstName = "Евгений"},
        new Parent { LastName = "Евдокимов(а)", FirstName = "Людмила"},
        new Parent { LastName = "Евдокимов(а)", FirstName = "Андрей"},
        new Child { LastName = "Дедько", FirstName = "Жанна"},
        new Child { LastName = "Евдокимов(а)", FirstName = "Владимир"},
        new Child { LastName = "Лук-ко", FirstName = "Умка"},
        new Child { LastName = "Лук-ко", FirstName = "бел IT"},
        new Parent { LastName = "Петров(а)", FirstName = "Петр"},
        new Parent { LastName = "Петров(а)", FirstName = "Анна"},
        new Child { LastName = "Евдокимов(а)", FirstName = "Святослав"},
        new Child { LastName = "Небывалый", FirstName = "Иосиф"},
        new Child { LastName = "Лук-ко", FirstName = "Николя"},
        new Parent { LastName = "Лук-ко", FirstName = "Батьк"}

    };
    var lastNameList = new List<string>
    {
        "Иванов(а)", "Дедько", "Евдокимов(а)", "Лук-ко", "Петров(а)"
    };

    //по задаче нужно использовать join (для объединения). тут выбрал GroupJoin который еще и группирует
    var families = lastNameList.GroupJoin(peoples, c => c, p => p.LastName,
        (c, familyMember) => new { FamilyName = c, Members = familyMember } );

    foreach (var family in families)
    {
        Console.WriteLine($"{family.FamilyName}:");
        foreach (var member in family.Members)
        {
            Console.WriteLine($"Имя: {member.FirstName}");
        }
        Console.WriteLine();
    }
    //выбрать самую яркую личность из списка. ну или просто одну фамилию и последнего члена из списка
    //(слишком легко. но я не знаю какую задачу придумать на where, take, skip и select. воображения не хватает :( )
    var resultFam = peoples.Where((f) => f.LastName == "Лук-ко");
    var result = resultFam.Skip(resultFam.Count() - 1).Take(1).Select((x) => x.FirstName = "Солнцеподобный");

    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}