using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Library.Clases
{
    public class MyEnumerator : IEnumerator<MyItem>
    {
        private MyItem[] myItems;
        private int index;
        private MyItem myItem;
        public MyEnumerator(MyItem[] myItems)
        {
            this.myItems = myItems;
            index = -1;
            myItem = new MyItem("default");
        }
        public MyItem Current
        {
            get
            {
                return myItem;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            //не понял что здесь надо реализовать. но пока и без этого работало :)
        }

        public bool MoveNext()
        {
            index++;

            if(index >= myItems.Length)
            {
                return false;
            }
            else
            {
                myItem = myItems[index];
            }

            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
