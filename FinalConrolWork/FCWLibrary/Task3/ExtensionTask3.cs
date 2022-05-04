using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCWLibrary.Task3
{
    public static class ExtensionTask3
    {
        public static void AddNumbersInCollection(this List<int> collection, int count)
        {
            var random = new Random();
            for (var i = 0; i < count; i++)
            {
                collection.Add(random.Next(0, 10));
            }
        }
    }
}
