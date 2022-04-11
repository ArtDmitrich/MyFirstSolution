using Lesson14Library;
using Lesson14Library.Models;
using Lesson14Library.Extensions;

//создаем пару объектов разных классов
var somePerson = new Person("Сетинский", "Артем","Дмитриевич", 1992);
var someCar = new Car("BMW", "X5", 2010, "ZFA22300005556777");
var someUser = new User("АЯВамПокажуОткудаНаБеларусьГотовилосНападение", "klain92@mail.ru");
//создаем валидатор
var myValidator = new ValidatorForMyCustomAttrebutes();
var resultOfValid = myValidator.AllMembersValidation(somePerson);
//пропустим наши объекты через валидатор
Console.WriteLine($"Результат валидации {somePerson}: {resultOfValid}");
if(resultOfValid == false)
{
    myValidator.NotValidList.PrintListOnConsole();
}

resultOfValid = myValidator.AllMembersValidation(someCar);

Console.WriteLine($"Результат валидации {someCar}: {resultOfValid}");
if (resultOfValid == false)
{
    myValidator.NotValidList.PrintListOnConsole();
}

resultOfValid = myValidator.PropertiesValidation(someUser);

Console.WriteLine($"Результат валидации {someUser}: {resultOfValid}");
if (resultOfValid == false)
{
    myValidator.NotValidList.PrintListOnConsole();
}