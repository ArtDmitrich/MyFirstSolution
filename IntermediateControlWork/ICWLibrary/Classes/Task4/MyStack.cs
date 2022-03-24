using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary
{
    public class MyStack
    {
        public int[] Stack { get; set; }
        public MyStack(int[] stack)
        {              
            Stack = stack;
        }
        public int Pop()
        {
            if (Stack.Length == 0)
            {
                return 0;
            }                

            return Stack[Stack.Length - 1];
        }
        public void Push(int number)
        {
            if (Stack.Length == 0)
            {
                Stack = new int[] {number};
            }

            Stack[Stack.Length - 1] = number;
        }

    }
}
