using Lesson10Library.Clases;

var items = new MyItem[]
{
    new (1), new (2), new (3), new (4), new (5), new (6)
};

var myList = new MyList(items);
myList.Add(new MyItem(7));

myList.Clear();

Console.WriteLine();