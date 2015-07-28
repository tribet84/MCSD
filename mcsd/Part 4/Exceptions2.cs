using System;

namespace Chapter1
{
    class Exceptions2
    {
        public static void Run()
        {
            string s = Console.ReadLine();
            try
            {
                int age = int.Parse(s);
                if (age == 10) Environment.FailFast("Special number was introduced");
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
