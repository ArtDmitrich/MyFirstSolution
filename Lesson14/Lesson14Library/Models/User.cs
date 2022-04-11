using Lesson14Library.Attributes;

namespace Lesson14Library.Models
{
    public class User
    {
        [MyForAllMembers(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$")]
        private string Name { get; set; }
        [MyForAllMembers(@"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$")]
        private string email;
        public User(string name, string email)
        {
            Name = name;
            this.email = email;
        }
        public override string ToString()
        {
            return $"User";
        }
    }
}
