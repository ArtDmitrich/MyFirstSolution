using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Library.Models
{
    public class Car
    {
        static int counter = 0;
        public int Age;
        public string Name;
        public Car(int age)
        {
            Age = age;
            counter++;
            Name = "Car" + counter.ToString();
        }
    }
}
