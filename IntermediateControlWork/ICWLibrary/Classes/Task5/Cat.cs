using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }
        public string Color { get; set; }
        public override void Info()
        {
            Console.WriteLine($"Cat: {this.Name}, Age:{this.Age}, Color: {this.Color}"); ;
        }
    }
}
