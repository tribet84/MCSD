using System;

namespace Chapter1
{
    class Exceptions3
    {
        public static void Run()
        {
            try
            {
                ProcessArithmeticFunction();
            }
            catch (SumException ex)
            {
                throw new WrongSalaryException("Error while processing your salary", ex);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }

        public static void ProcessArithmeticFunction() { }
    }

    public class WrongSalaryException : Exception
    {
        public WrongSalaryException(string s, Exception e) { }
    }

    public class SumException : Exception { }
}
