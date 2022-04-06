using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13Library.Exception
{
    [Serializable]
    public class MyException : SystemException
    {
        private string shopName;
        public string ShopName
        {
            get
            {
                return shopName;
            }
        }
        public MyException() : base()
        {
        }
        public MyException(string value) :
            base(String.Format($"магазина с названием {value} не существует"))
        {
            shopName = value;
        }
        public MyException(string value, string message) : base(message)
        {
            shopName = value;

        }
        public MyException(string value, string message, SystemException inner) : base(message, inner)
        {
            shopName = value;

        }
        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}