using System.Diagnostics;

namespace Chapter3
{
    public static class DebugExample
    {
        public static void HowToUseTheDebugClass()
        {
            Debug.WriteLine("Here we go!");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLine(i > 0, "i is greater than zero");
        }
    }
}