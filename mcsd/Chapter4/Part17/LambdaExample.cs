using System;

namespace Chapter4
{
    public static class LambdaExample
    {
        public static void Run()
        {
            // Using Func<T,T> 
            Func<int, int> myDelegate =
                delegate(int x)
                {
                    return x * 2;
                };
            System.Console.WriteLine(myDelegate(2)); // Displays 4

            // Using lambda
            Func<int, int> myDelegate1 = x => x * 2;
            System.Console.WriteLine(myDelegate1(2)); // Dispalays 4
        }
    }
}