using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Library.Clases
{
    public class MyList : IList<MyItem>
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

            temp[Items.Length] = item;

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
            var temp = new MyItem[Items.Length + 1];

            for (int i = 0, j = 0; i < temp.Length; i++, j++)
            {
                if(i == index)
                {
                    temp[i] = item;
                    continue;
                }
                
                temp[i] = Items[j];
            }

            Items = new MyItem[temp.Length];
            Items = temp;
        }

        public bool Remove(MyItem item) //
        {
            var result = false;
            var index = -1;

            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(Items[i], item))
                {
                    index = i;
                    result = true;
                    break;
                }
            }

            if (result)
            {
                RemoveAt(index);
            }
            
            return result;
        }

        public void RemoveAt(int index) //
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
        public IEnumerator<MyItem> GetEnumerator()
        {
            return MyEnumerator<MyItem>.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
