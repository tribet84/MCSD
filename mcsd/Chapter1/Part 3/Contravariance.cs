using System.IO;

namespace Chapter1
{
    public class Contravariance
    {
        public static void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        public static void Run()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}
