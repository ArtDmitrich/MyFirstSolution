using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using Lesson14Library.Attributes;

namespace Lesson14Library.Models
{
    public class MyValidator
    {
        public List<MemberInfo> NotValidList { get; set; } = new List<MemberInfo>();
        public bool PropertiesValidator(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var result = true;
            NotValidList.Clear();

            for (int i = 0; i < properties.Length; i++)
            {
                var attributes = properties[i].GetCustomAttributes();

                foreach (var attrebutes in attributes)
                {
                    var tempAttribute = attrebutes as MyForPropertiesAttribute;
                    if (tempAttribute != null)
                    {
                        var tempValue = Convert.ToString(properties[i].GetValue(obj));
                        if (!Regex.IsMatch(tempValue, tempAttribute.Pattern, RegexOptions.IgnoreCase))
                        {
                            NotValidList.Add(properties[i]);
                            result = false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
