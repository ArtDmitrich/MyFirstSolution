using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Library
{
    public static class Extensions
    {
        public static string FindThickBook (this Library library, List<Book> books)
        {
            var temp = 0;

            for (int i = 0; i < books.Count; i++)
            {
                if(books[temp].GetBookNumberOfPages() < books[i].GetBookNumberOfPages())
                {
                    temp = i;
                }
            }

            return books[temp].ToString();
        }
        public static int[] BubleSort (this int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
