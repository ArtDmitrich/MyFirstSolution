using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Library
{
    public class GreenPrinter: Printer
    {
        public GreenPrinter (string name): base (name)
        {

        }
        public override void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
