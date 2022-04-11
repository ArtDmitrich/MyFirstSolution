using System.Text.RegularExpressions;
using System.Reflection;
using Lesson14Library.Extensions;

namespace Lesson14Library.Models
{
    public class ValidatorForMyCustomAttrebutes
    {
        //валидатор для всего, что может хранить значение в классах и помечено кастомным атрибутом.
        //оставил 3 вариации метода, в зависимости от цели использования валидатора:
        //1) нужна валидация только свойств 2) только полей 3) всего, что содержит кастомный атрибут
        public List<MemberInfo> NotValidList { get; set; } = new List<MemberInfo>();
        public bool PropertiesValidation(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            NotValidList.Clear();

            return Validation(properties, obj);
        }
        public bool FieldsValidation(object obj)
        {
            var type = obj.GetType();
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            NotValidList.Clear();

            return Validation(fields, obj);
        }
        public bool AllMembersValidation (object obj)
        {
            var type = obj.GetType();
            var members = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            NotValidList.Clear();

            return Validation(members, obj);            
        }
        private bool Validation (MemberInfo[] members, object obj)
        {
            var result = true;

            for (int i = 0; i < members.Length; i++)
            {
                var attributes = members[i].GetCustomAttributes();

                foreach (var attrebute in attributes)
                {
                    if (attrebute != null)
                    {
                        var tempValue = Convert.ToString(members[i].GetValue(obj));
                        if (!Regex.IsMatch(tempValue, attrebute.GetPattern(), RegexOptions.IgnoreCase))
                        {
                            NotValidList.Add(members[i]);
                            result = false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
