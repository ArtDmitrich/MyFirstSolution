using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Library
{
    public class Printer
    {
        private string Name { get;}
        public Printer (string name)
        {
            Name = name;
        }
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
