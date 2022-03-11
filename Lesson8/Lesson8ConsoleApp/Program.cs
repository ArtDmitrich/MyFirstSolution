using Lesson8Library;
var room = new Room("Room 1");
var printers = new List<Printer>
{
    new Printer("Стандартный принтер"),
    new GreenPrinter("Зеленый принтер"),
    new BluePrinter("Синий принтер")
};

Console.WriteLine("Домашнее задание по Занятию8");
bool menuCheck = true;

do
{
    Console.WriteLine($"Мы находимся в {room}\nНам доступны следующие действия:" +
        "\n1 - Назначить принтер в данную комнату (если в комнате есть принтер, новый заменит текущий)" +
        "\n2 - Заставить этот ленивый принтер работать" +
        "\n3 - Бахнуть пивка" +
        "\n4 - Делать вид, что вы работаете до конца раб. дня (выход из программы)" +
        "\n Выберите пункт меню:");
    Console.WriteLine();

    switch (Console.ReadLine())
    {
        case "1":
            var printer = printers.ChoosePrinter();
            room.SetPrinterInThisRoom(printer);
            break;
        case "2":
            room.MakeThisLazyPrinterWork("*Текст для печати*");
            break;
        case "3":
            room.BeerInRoom();
            break;
        case "4":
            Console.WriteLine("День прошел незаметно, пора домой.");
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