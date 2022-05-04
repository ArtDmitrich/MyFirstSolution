using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCWLibrary.Task5
{
    public class MyMathClass
    {
        public int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else if (num == 0)
            {
                return 0;
            }
            return num * Factorial(num - 1);
        }
        public int Exponentiation(int num, int degree)
        {
            if(degree == 0)
            {
                return  1;
            }
            else if(degree == 1)
            {
                return num;
            }
            return num * Exponentiation(num, degree - 1);
        }          

    }
}
