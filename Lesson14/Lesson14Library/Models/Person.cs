using Lesson14Library.Attributes;

namespace Lesson14Library
{    
    public class Person
    {        
        [MyForProperties(@"^[a-zа-я]{2,16}$")]
        public string FirstName { get; }
        [MyForProperties(@"^[a-zа-я]{2,16}$")]
        public string LastName { get; }
        [MyForFields(@"^[a-zа-я]{2,16}$")]
        private string secondName;
        [MyForProperties("[1-2][9,0][0-9][0-9]$")]
        public int YearOfBirth { get; }
        public Person(string lastName, string firstName,string secondName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            this.secondName = secondName;
            YearOfBirth = yearOfBirth;
        }
        public int GetPersonAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
        public override string ToString()
        {
            return $"Person"; 
        }
    }
}
