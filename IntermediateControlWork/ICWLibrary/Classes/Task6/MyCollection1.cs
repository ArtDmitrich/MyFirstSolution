using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICWLibrary.Interfaces;

namespace ICWLibrary.Classes.Task6
{
    public class MyCollection1<T>: IMyInterface<T>
    {
        public List<T> MyList { get; set; } = new List<T>();
        public MyCollection1(List<T> myList)
        {
            MyList = myList;
        }
        public T this[int index]
        {
            get
            {
                return MyList[index];
            }
        }

        public void AddInCollection(T item)
        {
            MyList.Add(item);
        }

        public T ReadFromCollection(int index)
        {
            return MyList[index];
        }
    }
}
