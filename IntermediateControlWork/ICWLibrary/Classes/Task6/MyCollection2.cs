using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICWLibrary.Interfaces;

namespace ICWLibrary.Classes.Task6
{
    public class MyCollection2<T> : IMyInterface<T> where T : class
    {
        public T[] Items { get; set; }
        public MyCollection2(T[] items)
        {
            Items = items;
        }

        public void AddInCollection(T item)
        {
            if (Items == null)
            {
                Items = new T[] {item};
            }

            var temp = new T[Items.Length + 1];

            for (int i = 0; i < Items.Length; i++)
            {
                temp[i] = Items[i];
            }

            temp[Items.Length] = item;
            Items = new T[temp.Length];
            Items = temp;
        }

        public T ReadFromCollection(int index)
        {
            return Items[index];
        }
    }
}
