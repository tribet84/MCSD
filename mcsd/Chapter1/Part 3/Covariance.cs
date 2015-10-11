using System.IO;

namespace Chapter1
{
    public class Covariance
    {
        public delegate TextWriter CovarianceDel();

        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }

        public static void Run()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
