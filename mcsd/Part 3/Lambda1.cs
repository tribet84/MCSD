using System.IO;

namespace Chapter1
{
    public class Lambda1
    {
        public delegate int Calculate(int x, int y);

        public static void Run()
        {
            Calculate calc =
                (x, y) =>
                {
                    System.Console.WriteLine("Adding numbers...");
                    return x + y;
                };
            int result = calc(3, 5);
        }
    }
}
// output
// Adding numbers...