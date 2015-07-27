using System;
namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Events4 p = new Events4();
            p.CreateAndRaise();
            Console.Read();
        }
    }
}
