using FlexibleQuery.Keywords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Flexible.Expressions
{
    public static class LINQBuilder
    {

        public static MethodCallExpression Build(IEnumerable<string> queries)
        {
            foreach(var query in queries)
            {
                if (KeywordDictionary.Contains())
                {
                    throw new NotImplementedException();
                }
            }
        }

        private static ParameterExpression ParameterExpression<T>() =>
            Expression.Parameter(typeof(T), "property");

        private static MemberExpression BodyExpression(ParameterExpression parameter, string propertyName) =>
            Expression.PropertyOrField(parameter, propertyName);

        private static MethodInfo MethodInformation(string method, Type type) =>
            type.GetMethod(method, new[] { type, type })!;
    }
}
