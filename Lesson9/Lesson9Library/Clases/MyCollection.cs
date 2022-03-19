using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson9Library.Interfaces;

namespace Lesson9Library.Clases
{
    public class MyCollection<T> where T : IVehicle
    {
        public string Name { get; }
        private List<T> Collection { get; set; } = new List<T>();
        public int Count
        {
            get { return Collection.Count; }
        }
        public MyCollection(string name, List<T> collection)
        {
            Name = name;
            Collection = collection;
        }
        public T this[int index]
        {
            get
            {                
                return Collection[index];
            }
        }
        public void AddInCollection(T item)
        {
            Collection.Add(item);
        }
        public void ClearAllCollection()
        {
            Collection.Clear();
        }
        public void DeleteAt(int index)
        {
            Collection.RemoveAt(index);
        }
        public void Sort()
        {
            Collection.Sort();
        }
    }
}
