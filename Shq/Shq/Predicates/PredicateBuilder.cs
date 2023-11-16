using Shq.Keywords;
using System.Linq.Expressions;
using System.Reflection;

namespace Shq.Predicates
{
    public static class PredicateBuilder
    {

        public static Expression<Func<T, bool>> BuildPredicate<T>(IEnumerable<string> queries)
        {
            Expression predicate = null;


            for (int index = 1; index < queries.Count() - 1; index++)
            {
                var query = queries.ElementAt(index);

                if (KeywordDictionary.Contains(query))
                {
                    var methodExpression = GetExpressionTree(queries.ElementAt(index - 1), queries.ElementAt(index + 1));

                    predicate = predicate != null ?
                        Expression.Or(predicate, methodExpression)
                            :
                        methodExpression;
                }
            }

            return Expression.Lambda<Func<T, bool>>(predicate!);
        }

        private static MethodCallExpression GetExpressionTree<T>(string propertyName, T propertyValue) =>
            ExpressionCall(propertyValue, BodyExpression(ParameterExpression<T>(), propertyName), MethodInformation<T>());

        private static ParameterExpression ParameterExpression<T>() =>
            Expression.Parameter(typeof(T), "property");

        private static MemberExpression BodyExpression(ParameterExpression parameter, string propertyName) =>
            Expression.PropertyOrField(parameter, propertyName);

        private static MethodInfo MethodInformation<T>() =>
            typeof(T).GetMethod("Contains", new[] { typeof(T), typeof(StringComparison) })!;

        private static MethodCallExpression ExpressionCall<T>(T value, MemberExpression body, MethodInfo methodInformation) =>
            Expression.Call(body, methodInformation, Expression.Constant(value, typeof(string)), Expression.Constant(StringComparison.OrdinalIgnoreCase));
    }
}
