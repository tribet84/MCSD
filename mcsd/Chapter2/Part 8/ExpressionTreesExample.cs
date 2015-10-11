using System;
using System.Linq.Expressions;

namespace Chapter2
{
    class ExpressionTreesExample
    {
        public static void BuildExpression()
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                    Expression.Constant("Hello ")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("World!")
                 )
            );
        }
    }
}
