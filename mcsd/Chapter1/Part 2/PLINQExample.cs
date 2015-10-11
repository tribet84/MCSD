using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class PLINQExample
    {
        public static void Run()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach(int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
// output
// 2
// 0
// 4
// 6
// 8