using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary
{
    public class MyString
    {
        public char[] CharArray { get; set; }
        public MyString(char[] charArray)
        {
            CharArray = charArray;
        }
        public MyString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                CharArray[i] = str[i];
            }
        }
        public void Reverse()
        {
            CharArray.Reverse();
        }
    }
}
