using Lesson14Library;
using Lesson14Library.Models;
using System.Reflection;
using System.Text.RegularExpressions;

var somePerson = new Person("Артем", "Smith", 192);
var someCar = new Car("BMW", "X5", 2010, "ZFA22300005556777");

var myValidator = new MyValidator();
var resultOfValidPerson = myValidator.PropertiesValidator(somePerson);
Console.WriteLine($"Результат валидации: {resultOfValidPerson}");
if (!resultOfValidPerson)
{
    Console.WriteLine("Свойства, которые не прошли валидацию:");

    foreach (var item in myValidator.NotValidList)
    {
        Console.WriteLine(item.Name);
    }

    Console.WriteLine();
}
Console.WriteLine();

resultOfValidPerson = myValidator.PropertiesValidator(someCar);
Console.WriteLine($"Результат валидации: {resultOfValidPerson}");
if (!resultOfValidPerson)
{
    Console.WriteLine("Свойства, которые не прошли валидацию:");

    foreach (var item in myValidator.NotValidList)
    {
        Console.WriteLine(item.Name);
    }

    Console.WriteLine();
}