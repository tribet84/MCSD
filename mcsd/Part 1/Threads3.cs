using System;
using System.Threading; 

namespace Chapter1
{
    public static class Threads3
    {
        public static void Run()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;

            t.Join();
        }
    }
}