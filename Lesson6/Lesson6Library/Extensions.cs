using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Library
{
    public static class Extensions
    {
        public static string FindThickBook (this Library library)
        {
            var temp = 0;
            var tempBooks = library.GetBooksFromLibrary();

            for (int i = 1; i < tempBooks.Count; i++)
            {
                if(tempBooks[temp].GetBookNumberOfPages() < tempBooks[i].GetBookNumberOfPages())
                {
                    temp = i;
                }
            }

            return tempBooks[temp].ToString();
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
