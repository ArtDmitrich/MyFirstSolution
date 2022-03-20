using Lesson9Library.Clases;
using Lesson9Library.Interfaces;


Console.WriteLine("Домашняя работа по Занятие9 <Интерфейсы>");

var list1 = new List<IVehicle>()
{
    new Car("Reno", 2020),
    new Boat("Russkij voennij korabl`", 1980),
    new Bike("Suzuki", 2008),
    new Boat("Aurora", 2000),
    new Car("BMW", 1998),
    new Bike("Ducati", 2013),
    new Car("KIA", 2021),
    new Boat("ship", 2022),
    new Bike("Ural", 1977),
    new Car("Vaz", 1999),
    new Boat("motor boat", 2007)   

};

var myCollection = new MyCollection<IVehicle>("My Collection", list1);
var menuCheck = true;

Console.WriteLine("У нас есть объект MyCollection, содержащий список разного транспорт");

do
{
    Console.WriteLine();
    Console.WriteLine("Меню:\n1 - Вывести на экран список транспортных средств.\n2 - Узнать общее количество транспорта в списке." +
        "\n3 - Добавить новое транспортное средство.\n4 - Получить информацию о транспортном средстве по номеру в списке." +
        "\n5 - Удалить элемент из списка по индексу.\n6 - Отсортировать список по году выпуска." +
        "\n7 - Очистить список.\n8 - Выход из меню.");
    Console.WriteLine();
    switch (Console.ReadLine())
    {
        case "1":
            myCollection.PrintListOnConsole();
            break;
        case "2":
            Console.WriteLine($"Всего транспортных средств в {myCollection.Name}: {myCollection.Count}");
            break;
        case "3":
            myCollection.AddInCollection(myCollection.ChooseVehicle());
            break;
        case "4":
            Console.WriteLine(myCollection[myCollection.EntryIndex() - 1]);
            break;
        case "5":
            myCollection.DeleteAt(myCollection.EntryIndex() - 1);
            break;
        case "6":
            myCollection.Sort();
            break;
        case "7":
            myCollection.ClearAllCollection();
            break;
        case "8":
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