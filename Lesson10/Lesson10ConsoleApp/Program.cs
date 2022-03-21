using Lesson10Library.Clases;

var items = new[]
{
    new MyItem("one"),
    new MyItem("two"),
    new MyItem("three"),
    new MyItem("four"),
    new MyItem("five")

};

var myList1 = new MyList(items);
//проверяем реализацию IEnumerator
myList1.PrintListOnConsole();

//пробуем получить элемент по индексу
Console.WriteLine(myList1[2]);

//пробуем установить элемент по индексу
var item6 = new MyItem("six");
myList1[2] = item6;
myList1.PrintListOnConsole();

//пробуем получить количество элементов в MyList
Console.WriteLine($"количество элементов в Mylist: {myList1.Count()}");

//получим значение свойсва ReadOnly
Console.WriteLine($"MyList IsReadOnly: {myList1.IsReadOnly}");

//пробуем добавить новый элемент в MyList
myList1.Add(new MyItem("seven"));
Console.WriteLine("MyList после добавления одного элемента:");
myList1.PrintListOnConsole();

//пробуем домавить массив в MyList
var items2 = new MyItem[]
{
    new MyItem("fourteen"),
    new MyItem("fifteen"),
    new MyItem("sixteen")
};
myList1.Add(items2);
Console.WriteLine("MyList после добавления массива элементов:");
myList1.PrintListOnConsole();

//очистим MyList
Console.WriteLine("Очистим MyList");
myList1.Clear();
myList1.PrintListOnConsole();

//проверим есть ли элемент в MyList
myList1 = new MyList(items);
var item8 = new MyItem("eight");
Console.WriteLine($"результат поиска элемента {item8} в MyList:{myList1.Contains(item8)}");

//пробуем скопировать в MyList массив, начиная с указанного индекса
Console.WriteLine("MyList до копирования:");
myList1.PrintListOnConsole();
var items3 = new MyItem[]
{
    item8,
    new MyItem("nine"),
    new MyItem("ten"),
    new MyItem("eleven")
};
myList1.CopyTo(items3, 3);
Console.WriteLine("MyList после копирования:");
myList1.PrintListOnConsole();

//найдем индекс элемента в MyList
var index = myList1.IndexOf(item8);
if(index == -1)
{
    Console.WriteLine($"элемента {item8} в MyList нет");
}
else
{
    Console.WriteLine($"элемент {item8} находится в MyList под индексом {index}");
}

//пробуем вставить новый элемент в MyList
Console.WriteLine("MyList до вставки элемента:");
myList1.PrintListOnConsole();
myList1.Insert(1, new MyItem("twelve"));
Console.WriteLine("MyList после вставки элемента по индексу 1:");
myList1.PrintListOnConsole();

//проверим удаление элемента. сразу два метода (один вызывает другой)
Console.WriteLine("Mylist дo попытки удаления:");
myList1.PrintListOnConsole();

var result = myList1.Remove(item8);
Console.WriteLine($"получилось ли удалить {item8}: {result}");
Console.WriteLine("MyList после удаления");
myList1.PrintListOnConsole();
Console.WriteLine();

Console.WriteLine("пробуем удалить элемент, которого нет в Mylist");
Console.WriteLine("Mylist дo попытки удаления:");
myList1.PrintListOnConsole();

var item9 = new MyItem("thirteen");
result = myList1.Remove(item9);
Console.WriteLine($"получилось ли удалить {item9}: {result}");
Console.WriteLine("MyList после удаления");
myList1.PrintListOnConsole();