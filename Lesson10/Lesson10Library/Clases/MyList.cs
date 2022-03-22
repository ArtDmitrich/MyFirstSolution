using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Library.Clases
{
    public class MyList: IList<MyItem>
    {
        private MyItem[] Items { get; set; }
        public MyList()
        {
            Items = new MyItem[0];
        }
        public MyList(MyItem[] items)
        {
            Items = items;
        }
        public MyItem this[int index] //
        { 
            get
            {
                return Items[index];
            }
            set
            {                
                Items[index] = value;
            }
        }

        public int Count => Items.Length; //

        public bool IsReadOnly //
        {
            get
            {
                return false;
            }
                
        }
        public void Add(MyItem item) //
        {            
            var temp = new MyItem[Items.Length + 1];

            for (int i = 0; i < Items.Length; i++)
            {
                temp[i] = Items[i];
            }

            temp[temp.Length - 1] = item;

            Items = new MyItem[temp.Length];
            Items = temp;
        }
        public void Add(MyItem[] items) //
        {
            var temp = new MyItem[Items.Length + items.Length];

            for (int i = 0; i < Items.Length; i++)
            {
                temp[i] = Items[i];
            }

            for (int j = Items.Length, k = 0; j < temp.Length; j++, k++)
            {
                temp[j] = items[k];
            }

            Items = new MyItem[temp.Length];
            Items = temp;
        }

        public void Clear() //
        {
            Items = new MyItem[0];
        }

        public bool Contains(MyItem item) //
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(Items[i], item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(MyItem[] array, int arrayIndex) // 
        {
            //все значения, которые не поместятся в исходный массив - не будут скопированы.
            //специально так оставил, метод называется скопировать, а не добавить

            for (int j = 0; arrayIndex < Items.Length; arrayIndex++, j++)
            {
                Items[arrayIndex] = array[j];
            }
        }
        public int IndexOf(MyItem item) //
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(Items[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, MyItem item) //
        {
            if(index >= 0 && index <= Items.Length)
            {
                var temp = new MyItem[Items.Length + 1];

                for (int i = 0, j = 0; i < temp.Length; i++, j++)
                {
                    if (i == index)
                    {
                        temp[i] = item;
                        i++;
                    }

                    temp[i] = Items[j];
                }

                Items = new MyItem[temp.Length];
                Items = temp;
            }
        }

        public bool Remove(MyItem item) //
        {            
            var index = IndexOf(item);
            var result = false;

            if(index != -1)
            {
                result = true;
            }

            if (result)
            {
                RemoveAt(index);
            }
            
            return result;
        }

        public void RemoveAt(int index) //
        {
            if(index >0 && index < Items.Length)
            {
                var temp = new MyItem[Items.Length - 1];

                for (int i = 0, j = 0; i < temp.Length; i++, j++)
                {
                    if (i == index)
                    {
                        j++;
                    }

                    temp[i] = Items[j];
                }

                Items = new MyItem[temp.Length];
                Items = temp;
            }
            
        }
        public IEnumerator<MyItem> GetEnumerator() //
        {
            return new MyEnumerator(Items);
        }
        IEnumerator IEnumerable.GetEnumerator() //
        {
            return GetEnumerator();
        }
    }
}
