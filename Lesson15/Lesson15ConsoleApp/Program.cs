using Lesson15Library.Exceptions;
using Lesson15Library.Models;
//укажем назание файла, который будем искать и путь к папке, в которой будем искать
var path = @"C:\Users\User\source\repos\MyFirstSolution\MyFirstSolution\Lesson15\FolderForTask";
var fileName = "I`m Here";
TryFindAndCompressTheFile(path, fileName);
//программа ищет до первого совпадения. как только подходящий файл найден,
//создается архиватор и запускается сжатие
//если не найден и вложенных папок не осталось - генерируем кастомное исключение

static void TryFindAndCompressTheFile(string path, string fileName)
{
    try
    {
        var searchEngine = new SearchEngine();
        var file = searchEngine.FindFile(path, fileName + "*");
        if (file == null)
        {
            throw new FileNotFoundCustomException(fileName);
        }
        var archiver = new Archiver();
        archiver.CompressFile(file.FullName);
        Console.WriteLine("Архивация прошла успешно, путь к архиву:");
        Console.WriteLine(archiver.PathToLastCompressedFile);
    }
    catch (FileNotFoundCustomException e)
    {
        Console.WriteLine(e.Message);
    }
}