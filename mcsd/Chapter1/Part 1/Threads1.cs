using System;
using System.Threading;

namespace Chapter1
{
    public static class Threads1
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Run() 
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
        }
    }
}
// Main thread: Do some work.
// ThreadProc: 0
// ThreadProc: 1
// ThreadProc: 2
// ThreadProc: 3
// ThreadProc: 4
// ThreadProc: 5
// ThreadProc: 6
// ThreadProc: 7
// ThreadProc: 8
// ThreadProc: 9
// Main thread: Do some work.
// Main thread: Do some work.
// Main thread: Do some work.