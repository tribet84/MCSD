using System;
using System.Linq;

namespace Chapter1
{
    class PLINQExample2
    {
        public static void Run()
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
        }
    }
}
// output
// 0
// 2
// 4
// 6
// 8