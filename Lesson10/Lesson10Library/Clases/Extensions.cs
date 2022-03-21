using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Library.Clases
{
    public static class Extensions
    {
        public static void PrintListOnConsole (this MyList myList)
        {
            Console.WriteLine("Список элементов в MyList:");

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
