using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Library.Enums
{
    [Flags]
    public enum NewsCategories
    {
        News = 1,
        Events = 2,
        Sport = 4,
        Weather = 8,
        Humor = 16
    }    
}
