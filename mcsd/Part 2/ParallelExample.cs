using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    class ParallelExample
    {
        public static void Run()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });

            ParallelLoopResult result = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
                    {
                        if (i == 500)
                        {
                            Console.WriteLine(" Breaking loop");
                            loopState.Break();
                        }
                        return;
                    });
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
// output
// 09:28:13.6325997
// Breaking loop
// 09:28:17.6881146