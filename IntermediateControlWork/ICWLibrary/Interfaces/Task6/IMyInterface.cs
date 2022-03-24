using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary.Interfaces
{
    public interface IMyInterface<T>
    {
        public void AddInCollection(T item);
        public T ReadFromCollection(int index);
       
    }
}
