using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCWLibrary.Task2
{
    public static class Extension
    {
        public static string GetStringFromInt (this int number)
        {
            var result = new StringBuilder();
            var tempList = new List<string>();
            var flag = true;
            while (flag)
            {
                tempList.Add(GetText(number % 10));
                number /= 10;
                if(number == 0)
                {
                    flag = false;
                }
            }

            for (int i = tempList.Count - 1; i >= 0; i--)
            {
                result.Append(tempList[i] + " ");
            }

            return result.ToString();
        }
        private static string GetText(int number)
        {
            switch (number)
            {
                case 0: return "ноль";
                case 1: return "один";
                case 2: return "два";
                case 3: return "три";
                case 4: return "четыре";
                case 5: return "пять";
                case 6: return "шесть";
                case 7: return "семь";
                case 8: return "восемь";
                case 9: return "девять";
                default: return null;
            }
        }
    }
}
