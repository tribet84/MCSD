using System.Diagnostics;

namespace Chapter3
{
    public static class ReadPerformanceCounters
    {
        public static void HowToReadPerformanceCounters()
        {
            System.Console.WriteLine("Press escape to exit.");
            using (PerformanceCounter pc = new PerformanceCounter("Memory", "Available bytes"))
            {
                string text = "Available memory: ";
                System.Console.WriteLine(text);
                do
                {
                    System.Console.WriteLine(pc.RawValue);
                    System.Console.SetCursorPosition(text.Length, System.Console.CursorTop);
                } while (System.Console.ReadKey(true).Key != System.ConsoleKey.Escape);
            }
        }
    }
}
// OUTPUT: 
// Press escape to exit.
// Available memory:
// 3295600640