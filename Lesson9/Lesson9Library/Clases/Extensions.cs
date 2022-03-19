using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson9Library.Interfaces;

namespace Lesson9Library.Clases
{
    public static class Extensions
    {
        public static void PrintListOnConsole(this MyCollection<IVehicle> myCollection)
        {
            Console.WriteLine($"{myCollection.Name} содержит следующий транспорт:");

            for (int i = 0; i < myCollection.Count; i++)
            {
                Console.WriteLine($"{i + 1}:{myCollection[i]}");
            }

            Console.WriteLine();
        }
        public static IVehicle ChooseVehicle(this MyCollection<IVehicle> myCollection)
        {         
            while(true)
            {
                Console.WriteLine("Выберите тип транспортного средства для добавления:");
                Console.WriteLine("1 - Автомобиль.\n2 - Мотоцикл.\n3 - Лодка.");
                switch (Console.ReadLine())
                {
                    case "1":
                        return new Car(EntryName(), myCollection.EntryAge());
                    case "2":
                        return new Bike(EntryName(), myCollection.EntryAge());
                    case "3":
                        return new Boat(EntryName(), myCollection.EntryAge());
                    default:
                        Console.WriteLine("Пункт меню не найден");
                        break;
                }
            }
            
        }
        private static string EntryName ()
        {
            Console.WriteLine("Введите название:");
            var name = Console.ReadLine();
            if (name == null)
            {
                return "Без названия";
            }

            return name;
        }
        private static int EntryAge(this MyCollection<IVehicle> myCollection)
        {
            bool result;
            int number;

            do
            {
                Console.WriteLine($"Введите год выпуска:");
                result = int.TryParse(Console.ReadLine(), out number);
                if (result == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Некорректный ввод. Год выпуска не может быть отрицательным.");
                    result = false;
                }
                Console.WriteLine();
            }
            while (!result);

            return number;
        }
        public static int EntryIndex (this MyCollection<IVehicle> myCollection)
        {
            bool result;
            int number;

            do
            {
                Console.WriteLine($"Введите номер транспорта из списка:");
                result = int.TryParse(Console.ReadLine(), out number);
                if (result == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                }
                else if (number > myCollection.Count)
                {
                    Console.WriteLine("Такого номера в списке не найдено");
                    result = false;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Некорректный ввод. Номер из списка не может быть отрицательным.");
                    result = false;
                }
                Console.WriteLine();
            }
            while (!result);

            return number;
        }

    }
}
