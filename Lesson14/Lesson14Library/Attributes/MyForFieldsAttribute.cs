namespace Lesson14Library.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class MyForFieldsAttribute : Attribute
    {
        private string pattern;
        public MyForFieldsAttribute(string pattern)
        {
            this.pattern = pattern;
        }
        public virtual string Pattern
        {
            get { return pattern; }
        }
    }
}
