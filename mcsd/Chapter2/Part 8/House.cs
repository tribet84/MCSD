#define Address
#undef Price
using System;
using System.Diagnostics;

namespace Chapter2
{
    [Serializable]
    class House
    {
        public static void Init()
        {
            if (Attribute.IsDefined(typeof(House), typeof(SerializableAttribute)))
                Console.WriteLine("I'm serializable");
            else
                Console.WriteLine("I am not serializable.");
            PrintAddress();
            PrintPrice();
        }

        [Conditional("Address")]
        static void PrintAddress()
        {
            Console.WriteLine("My address goes here.");
        }

        [Conditional("Price")]
        static void PrintPrice()
        {
            Console.WriteLine("My price goes here.");
        }
    }
}
// output
// I'm serializable
// My address goes here.