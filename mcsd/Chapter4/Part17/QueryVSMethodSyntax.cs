using System.Linq;

namespace Chapter4
{
    public static class QueryVSMethodSyntax
    {
        public static void Run()
        {
            int[] data = { 1, 2, 5, 8, 11 };

            // query syntax
            var result = from d in data
                         where d % 2 == 0
                         select d;

            // method syntax
            var result1 = data.Where(d => d % 2 == 0);

            // result = 2 8
            // result1 = 2 8
        }
    }
}