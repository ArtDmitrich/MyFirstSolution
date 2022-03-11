using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Library
{
    public static class Extensions
    {
        public static void PrinterNullError (this Room room)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR! В комнате нет принтера! Назначьте принтер!");
            Console.ResetColor();
        }
        public static Printer ChoosePrinter(this List<Printer> printers)
        {
            Console.WriteLine("На выбор есть следующие принтеры:");
            printers.PrintList();
            
            Console.WriteLine("Введите название принтера, который вы хотите назначить:");

            var printerName = Console.ReadLine();

            if (printerName == null)
            {
                Console.WriteLine($"Название принтера не введено. Принтер назначен по умолчанию: {printers[0]}");
                return printers[0];                
            }
         

            for (int i = 0; i < printers.Count; i++)
            { 
                if (printers[i].ToString().ToUpper() == printerName.ToUpper())
                {
                    return printers[i];
                }
            }

            Console.WriteLine($"Данного принтера нету в списке. Принтер назначен по умолчанию: {printers[0]}");
            return printers[0];
        }
        private static void PrintList(this List<Printer> printers)
        {
            foreach (Printer printer in printers)
                Console.WriteLine(printer);

            Console.WriteLine();
        }
        public static void BeerInRoom(this Room room)
        {
            var random = new Random();
            var result = random.Next(0, 4);
            if (result == 3)
            {
                Console.WriteLine("Вас спалили! Пиво отняли, а вас заставили вернуться к работе :(");
                return;
            }

            Console.WriteLine("Золотой вкус, которого ты достоин :)");
        }
    }
}
