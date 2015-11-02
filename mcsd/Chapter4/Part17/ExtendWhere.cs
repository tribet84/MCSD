using System;
using System.Collections.Generic;

namespace Chapter4
{
    public static class ExtendWhere
    {
        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}