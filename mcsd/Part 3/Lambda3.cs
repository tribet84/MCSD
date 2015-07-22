using System;

namespace Chapter1
{
    public class Lambda3
    {
        public static void Run()
        {
            Action<int, int> calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers...");
                    Console.WriteLine("Result: " + (x + y));
                };
            calc(3, 5);
        }
    }
}
// output
// Adding numbers...
// Result: 8