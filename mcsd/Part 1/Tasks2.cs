using System;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Tasks2
    {
        public static void Run()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            Console.WriteLine(t.Result);    //  Displays 42
        }
    }
}