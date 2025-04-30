using System;
using System.Collections.Generic;

namespace Helper
{
    public static class CollectionHelper
    {
        public static void PrintList(List<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
