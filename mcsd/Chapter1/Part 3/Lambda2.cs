using System;
using System.IO;

namespace Chapter1
{
    public class Lambda2
    {
        public static void Run()
        {
            Func<int,int,int> calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers...");
                    return x + y;
                };
            int result = calc(3, 5);
        }
    }
}
// output
// Adding numbers...