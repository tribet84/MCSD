using System;

namespace Chapter4.Part19
{
    class ArrayExamples
    {
        public void Main()
        {
            // Single array
            int[] arrayOfInt = new int[10];

            foreach (int i in arrayOfInt)
            {
                Console.Write(i); // Displays 0123456789
            }
            Console.Write(Environment.NewLine);

            // Two-dimensional array
            string[,] array2D = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            Console.WriteLine(array2D[0,0]); // one
            Console.WriteLine(array2D[1,1]); // four

            // Jagged array
            int[][] jaggedArray = 
            {
                new int[] {1,3,5,7,9},
                new int[] {3,4,2}
            };
        }
    }
}