namespace Lesson14Library.Attributes
{
    //сделал три типа артибутов: для всего, для полей и для свойств
    //не решил как лучше, один атрибут на все или всеже разделять. оставил все
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal class MyForAllMembersAttribute:Attribute
    {
        private string pattern;
        public MyForAllMembersAttribute(string pattern)
        {
            this.pattern = pattern;
        }
        public virtual string Pattern
        {
            get { return pattern; }
        }
    }
}
