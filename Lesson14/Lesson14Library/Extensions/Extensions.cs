using System.Reflection;
using Lesson14Library.Attributes;

namespace Lesson14Library.Extensions
{
    public static class Extensions
    {
        //изначально расстроился, что MemberInfo не имеет метод GetValue()
        //пока не понял, что можно же самому написать :)
        internal static object GetValue(this MemberInfo memberInfo, object obj)
        {
            if (memberInfo is PropertyInfo)
            {
                return ((PropertyInfo)memberInfo).GetValue (obj);
            }
            else if (memberInfo is FieldInfo)
            {
                return ((FieldInfo)memberInfo).GetValue(obj);
            }
            else
            {
                return null;
            }
        }
        internal static string GetPattern(this Attribute attribute)
        {
            if (attribute is MyForAllMembersAttribute)
            {
                var temp = (MyForAllMembersAttribute)attribute;
                return temp.Pattern;
            }
            else if(attribute is MyForFieldsAttribute)
            {
                var temp = (MyForFieldsAttribute)attribute;
                return temp.Pattern;
            }
            else if (attribute is MyForPropertiesAttribute)
            {
                var temp = (MyForPropertiesAttribute)attribute;
                return temp.Pattern;
            }
            else
            {
                return string.Empty;
            }
        }
        public static void PrintListOnConsole (this List<MemberInfo> list)
        {
            foreach (var memberInfo in list)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }
    }
}
