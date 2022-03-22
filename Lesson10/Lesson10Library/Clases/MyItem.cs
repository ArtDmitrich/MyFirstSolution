using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Library.Clases
{
    public class MyItem: IEqualityComparer<MyItem>
    {
        public int Id { get;}
        public string Name { get; }
        private static int counter;
        public MyItem(string name)
        {
            counter++;
            Id = counter;
            Name = name;
        }
        public bool Equals(MyItem x, MyItem y) //
        {
            if(x == null || y == null)
            {
                return false;
            }
            else if (x.Id == y.Id && x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode([DisallowNull] MyItem obj) //
        {
            return Id.GetHashCode() + 3 * Name.GetHashCode();
        }
        public override string ToString() //
        {
            return $"ID:{this.Id} Name:{this.Name}";
        }
    }
}
