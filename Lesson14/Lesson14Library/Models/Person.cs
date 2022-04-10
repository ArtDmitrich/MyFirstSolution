using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lesson14Library.Attributes;

namespace Lesson14Library
{    
    public class Person
    {        
        [MyForProperties(@"^[a-zа-я]{2,16}$")]
        public string FirstName { get; }
        [MyForProperties(@"^[a-zа-я]{2,16}$")]
        public string LastName { get; }
        [MyForProperties("[1-2][9,0][0-9][0-9]")]
        public int YearOfBirth { get; }
        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }
        public int GetPersonAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
    }
}
