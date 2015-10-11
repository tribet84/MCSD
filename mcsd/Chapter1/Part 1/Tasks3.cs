using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Tasks3
    {
        public static void Run()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);    //  Displays 84
        }
    }
}