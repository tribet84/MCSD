using System;

namespace Chapter2
{
    class Types1
    {
        enum Days : byte
        {
            Sat = 1,
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri
        };

        public static void Run()
        {
            // to compare we need to cast to type: "byte"
            Days day = Days.Mon;
            if ((byte)day == 3)
            {
                Console.WriteLine("Today is Monday");
            }
        }
    }
}
// output
// Today is Monday 