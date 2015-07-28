using System;

namespace Chapter1
{
    class Exceptions1
    {
        public static void Run()
        {
            try
            {
                int age = Int32.Parse("Fourteen");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error in the format provided.");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception raised.");
                throw;
            }
        }
    }
}
// output
// Error in the format provided.