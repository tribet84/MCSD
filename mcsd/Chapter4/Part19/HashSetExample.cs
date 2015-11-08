using System;
using System.Collections.Generic;

namespace Chapter4
{
    public static class HashSetExample
    {
        private static HashSet<int> evenSet = new HashSet<int>();

        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    evenSet.Add(i);
                }
            }
            DisplaySet(evenSet);
        }

        private static void DisplaySet(HashSet<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(" {0}", item);
            }
        }
    }
}
// OUTPUT
// 0 2 4 6 8