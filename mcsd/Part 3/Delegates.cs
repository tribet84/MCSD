using System;

namespace Chapter1
{
    public class Delegates
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        public static void Run()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // output 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // output 12
        }
    }
}
