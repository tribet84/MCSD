using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Tasks1
    {
        public static void Run()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
        }
    }
}