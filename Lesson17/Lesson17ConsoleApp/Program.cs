using Lesson17Library.Models;
Task1();
Task2();

static void Task1()
{
    //a. Создавать List машинок и добавлять в него 100000 элементов так, чтобы Age был различным у объектов.
    var carList = new CarList();
    carList.AddCarsWithRandomAge(100000);
    //создадим кастомный секундомер для наших операций
    var myStopwatch = new MyStopwatch();

    //б. обычным foreach пройтись по листу и изменить Age на (343 * 34 * DateTime.Now.Millisecond * 77 * (DateTime.Now.Minute + 5)) / DateTime.Now.Minute
    //var age = (343 * 34 * DateTime.Now.Millisecond * 77 * (DateTime.Now.Minute + 5)) / DateTime.Now.Minute;
    //сразу хотел просто передавать везде эту переменную age, но понял, что суть задачи в вычислении при каждой итерации.
    //при этом всеже сделал наблюдение интересное: если переменная вычислена заранее:
    //обычные for и foreach выполняют операцию примерно за 1 мс, Parallel.Foreach гдето за 30-40мс, Parallel.For примерно за 8мс
    //но если переменную вычисляем каждый раз, то:
    //обычные for и foreach где-то за 12-17, Parallel.Foreach гдето за 25-30мс, Parallel.For примерно за 3мс
    
    var result = myStopwatch.GetOperationTime(carList.SetAgeInCarsForeach);
    Console.WriteLine($"Foreach: {result} ms");

    //в.сделать это же в for цикле
    result = myStopwatch.GetOperationTime(carList.SetAgeInCarsFor);
    Console.WriteLine($"For: {result} ms");

    //г. сделать это же в for Parallel.ForEach
    result = myStopwatch.GetOperationTime(carList.SetAgeInCarsParallelForeach);
    Console.WriteLine($"Parallel.ForEach: {result} ms");

    //д. сделать это же в for Parallel.For
    result = myStopwatch.GetOperationTime(carList.SetAgeInCarsParallelFor);
    Console.WriteLine($"Parallel.For: {result} ms");
    Console.WriteLine();
}
static void Task2()
{
    var pathToFile1 = @"C:\Users\User\source\repos\MyFirstSolution\MyFirstSolution\Lesson17\FilesForTask\first.txt";
    var pathToFile2 = @"C:\Users\User\source\repos\MyFirstSolution\MyFirstSolution\Lesson17\FilesForTask\second.txt";
    var pathToFile3 = @"C:\Users\User\source\repos\MyFirstSolution\MyFirstSolution\Lesson17\FilesForTask\third.txt";
    //создал кастомный редактр текстовых файлов
    var textEditor = new TextFileEditor() { PathToFileToWrite = pathToFile3 };
    //попробовал через пул, работает, однозначный плюс, что не нужно создавать новые потоки
    //но нельзя устанавливать приоритет и не получилось реализовать способ передачи двух параметров
    //пришлось создавать дополнительное свойство в редакторе, чтобы он хранил путь, куда будем записывать
    ThreadPool.QueueUserWorkItem(textEditor.ReadAndWriteForTask, pathToFile1);
    ThreadPool.QueueUserWorkItem(textEditor.ReadAndWriteForTask, pathToFile2);
    //при создании новых потоков, тратится на них ресурсы,
    //но прямо при создании можно передать лямбда-выражение, а не создавать где-то дополнитеьный метод и как-то изловчаться в передаче переменных
    var thread1 = new Thread(()=> textEditor.WriteTextToFile(textEditor.ReadTextFromFile(pathToFile1), pathToFile3));
    var thread2 = new Thread(()=> textEditor.WriteTextToFile(textEditor.ReadTextFromFile(pathToFile2), pathToFile3));
   
    thread1.Start();
    thread2.Start();
    //не знаю что будет лучше, поэтому оба варианта оставил
    Console.WriteLine();
}