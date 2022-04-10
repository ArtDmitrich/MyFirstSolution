using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson14Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MyForPropertiesAttribute: Attribute
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
