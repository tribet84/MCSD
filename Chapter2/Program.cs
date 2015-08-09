using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMoney m = new MyMoney(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;
            Console.Read();
        }
    }
}
