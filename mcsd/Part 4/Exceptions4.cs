using System;
using System.Runtime.ExceptionServices;

namespace Chapter1
{
    class Exceptions4
    {
        public static void Run()
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string text = Console.ReadLine();
                int output = int.Parse(text);
            }
            catch (Exception ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}