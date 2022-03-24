using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary
{
    public class Dog: Animal
    {

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public string Breed { get; set; }
        public override void Info()
        {
            Console.WriteLine($"Dog: {this.Name}, Age:{this.Age}, Breed: {this.Breed}"); ;
        }
    }
}
