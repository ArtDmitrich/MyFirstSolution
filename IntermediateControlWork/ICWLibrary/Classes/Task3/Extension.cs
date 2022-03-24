using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICWLibrary
{
    public static class Extension
    {
        public static string DateOfCreationOfTheWorld(this DateTime dateTime)
        {
            return $"День {dateTime.Day: dd} месяца {dateTime.Month: MMMM} года {dateTime.Year: yyyy} от сотворения мира";
        }

    }
}
