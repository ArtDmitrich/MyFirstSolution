using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson9Library.Interfaces;

namespace Lesson9Library.Clases
{
    public class Boat: IMovable, IVehicle, IComparable
    {
        public string Name { get; }
        public int Age { get; }
        public Boat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Move()
        {
            return $"{this.Name} плывет";
        }
        public override string ToString()
        {
            return $"лодка {this.Name}, год выпуска: {this.Age}";
        }
        public int CompareTo(object? obj)
        {
            if (obj is IVehicle vehicle)
            {
                return Age.CompareTo(vehicle.Age);
            }
            else
            {
                throw new ArgumentException("Некоректное значение параметра");
            }
        }
    }
}
