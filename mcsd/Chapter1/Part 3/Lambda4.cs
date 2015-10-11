using System;

namespace Chapter1
{
    public class Lambda4
    {
        public static void Run()
        {
            Action myDelegate = getDelegate();
            myDelegate();
            myDelegate();
        }

        static Action getDelegate()
        {
            int counter = 0;
            return delegate
            {
                Console.WriteLine("counter={0}",counter);
                counter++;
            };
        }
    }
}
// output
//counter=0
//counter=1