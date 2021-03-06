namespace Lesson14Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class MyForPropertiesAttribute: Attribute
    {
        private string pattern;
        public MyForPropertiesAttribute(string pattern)
        {
            this.pattern = pattern;
        }
        public virtual string Pattern
        {
            get { return pattern; }
        }
    }
}
